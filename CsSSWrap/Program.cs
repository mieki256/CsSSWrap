using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Web;

namespace CsSSWrap
{
    public struct SSaverItem
    {
        public string Name { get; set; }  // Screensaver name
        public string Path { get; set; }  // File path
        public string Args { get; set; }  // Arguments
        public string Preview { get; set; }  // Preview bmp image file path

        public SSaverItem(string name, string path, string args, string preview)
        {
            this.Name = name;
            this.Path = path;
            this.Args = args;
            this.Preview = preview;
        }
    }

    public class AppliSaveData
    {
        public int SelectedIndex { get; set; }
        public List<SSaverItem> DataList { get; set; }
    }


    internal static class Program
    {
        private static Mutex? _mutex = new Mutex(false, Properties.Resources.MutexName);
        private static bool hasHandle = false;

        private static AppliSaveData? _saveData = new AppliSaveData();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Load settings file
            _saveData = LoadDataFile();

            if (args.Length >= 1)
            {
                string fg = args[0].ToLower().Trim().Substring(0, 2);
                if (fg == "/s")
                {
                    // Start fullscreen screensaver
                    FullScreenMode();
                }
                else if (fg == "/c")
                {
                    // Config mode
                    ConfigMode();
                }
                else if (fg == "/p" && args.Length >= 2)
                {
                    // Preview mode
                    IntPtr hWnd = new IntPtr(long.Parse(args[1]));
                    string name = GetExternalScreenSaverName(_saveData);
                    string imagePath = GetPreviewImagePath(_saveData);
                    PreviewMode(hWnd, name, imagePath);
                }
                else
                {
                    ConfigMode();
                }
            }
            else
            {
                ConfigMode();
            }
        }

        // フルスクリーンでスクリーンセーバーを表示
        static void FullScreenMode()
        {
            string externalSSaver = GetExternalScreenSaverPath(_saveData);
            string arguments = GetExternalScreenSaverArguments(_saveData);

            if (externalSSaver != "")
            {
                // 外部のスクリーンセーバーを起動
                ProcessStartInfo app = new ProcessStartInfo
                {
                    FileName = externalSSaver,
                    Arguments = arguments,
                    UseShellExecute = true,
                    ErrorDialog = true
                };
                Process.Start(app);  // 外部プログラムを実行
            }
            else
            {
                // 内蔵スクリーンセーバを表示
                StartInternalScreenSaver();
            }
        }

        // 内蔵スクリーンセーバを表示。多重起動も禁止する
        static void StartInternalScreenSaver()
        {
            try
            {
                try
                {
                    // 多重起動しているかチェック
                    if (_mutex == null)
                    {
                        hasHandle = false;
                    }
                    else
                    {
                        hasHandle = _mutex.WaitOne(0, false);
                    }
                }
                catch (AbandonedMutexException)
                {
                    // 前回のプロセスが異常終了してMutexが放置されている。
                    // この場合も所有権は取得できているので true 扱いにする。
                    hasHandle = true;
                }

                if (!hasHandle)
                {
                    // 既に起動しているので何もせずに戻る
                    //MessageBox.Show("Application is already running.");
                    return;
                }

                // スクリーン分のスクリーンセーバ用フォームを発生
                foreach (Screen scr in Screen.AllScreens)
                {
                    ScreenSaverForm ssaver = new ScreenSaverForm(scr.Bounds);
                    ssaver.Show();
                }
                Application.Run();
            }
            finally
            {
                // 処理が終わったら必ず mutex を解放
                if (_mutex != null)
                {
                    if (hasHandle)
                    {
                        try
                        {
                            _mutex.ReleaseMutex();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    _mutex.Dispose();
                    _mutex = null;
                }
            }
        }

        // 設定画面モード
        static void ConfigMode()
        {
            Application.Run(new SettingsForm());
        }

        // プレビュー画面モード
        static void PreviewMode(IntPtr hWnd, string name, string imagePath)
        {
            Application.Run(new PreviewForm(hWnd, name, imagePath));
        }

        // データ保存ディレクトリパスを返す
        public static string GetDataDir()
        {
            string roamingPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            return Path.Combine(roamingPath, Properties.Resources.AppliConfigDir);
        }

        // データ保存ファイルパスを返す
        public static string GetDataFilePath()
        {
            return Path.Combine(GetDataDir(), Properties.Resources.AppliConfigFile);
        }

        // データファイルを保存
        public static void SaveDataFile(AppliSaveData? _data)
        {
            string dataDir = GetDataDir();
            string dataFile = GetDataFilePath();

            // JSON化
            var options = new JsonSerializerOptions
            {
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(System.Text.Unicode.UnicodeRanges.All),
                WriteIndented = true
            };
            string jsonStr = JsonSerializer.Serialize(_data, options);

            try
            {
                // ディレクトリを作成
                Directory.CreateDirectory(dataDir);

                // ファイルを書き込み
                File.WriteAllText(dataFile, jsonStr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // データファイル(.json)を読み込む
        public static AppliSaveData? LoadDataFile()
        {
            string dataFile = GetDataFilePath();
            AppliSaveData? loadedData = new AppliSaveData();

            if (File.Exists(dataFile))
            {
                // ファイルが存在するので読み込む
                string json = File.ReadAllText(dataFile);
                return JsonSerializer.Deserialize<AppliSaveData>(json);
            }

            // ファイルが存在しない
            return InitListData();
        }

        // リストデータをデフォルト値で初期化
        public static AppliSaveData InitListData()
        {
            AppliSaveData data = new AppliSaveData();

            data.SelectedIndex = 0;
            data.DataList = new List<SSaverItem>();

            for (int i = 0; i < 1; i++)
            {
                SSaverItem item = new SSaverItem("None", "", "", "");
                data.DataList.Add(item);
            }
            return data;
        }

        // プレビュー画面用bmpのファイルパスを返す。空文字列もありえる。
        public static string GetPreviewImagePath(AppliSaveData? data)
        {
            if (data == null) return "";
            return data.DataList[data.SelectedIndex].Preview;
        }

        // 外部スクリーンセーバーのファイルパスを返す。空文字列もありえる。
        public static string GetExternalScreenSaverPath(AppliSaveData? data)
        {
            if (data == null) return "";
            string name = GetExternalScreenSaverName(data);
            if (name == "" || name == "None") return "";
            return data.DataList[data.SelectedIndex].Path;
        }

        // 外部スクリーンセーバーの引数を返す。空文字もありえる。
        public static string GetExternalScreenSaverArguments(AppliSaveData? data)
        {
            if (data == null) return "";
            string name = GetExternalScreenSaverName(data);
            if (name == "" || name == "None") return "";
            return data.DataList[data.SelectedIndex].Args;
        }

        // 外部スクリーンセーバの管理名を返す。空文字もありえる。
        public static string GetExternalScreenSaverName(AppliSaveData? data)
        {
            if (data == null) return "";
            int i = data.SelectedIndex;
            string name = data.DataList[i].Name;
            if (name == "" || name == "None") return "";
            return name;
        }
    }
}