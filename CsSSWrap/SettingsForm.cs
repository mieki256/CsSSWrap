using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsSSWrap
{

    public partial class SettingsForm : Form
    {
        private static AppliSaveData? _data = new AppliSaveData();

        public SettingsForm()
        {
            InitializeComponent();

            _data = Program.LoadDataFile();
            UpdateListBox(_data);

            labelTitle.Text = Program.AppliName;
            labelVersion.Text = "ver. " + Program.AppliVersion;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ListBoxをデータ内容で更新
        public void UpdateListBox(AppliSaveData? data)
        {
            if (data == null) return;

            listBoxSSList.Items.Clear();

            for (int i = 0; i < data.DataList.Count; i++)
                listBoxSSList.Items.Add(data.DataList[i].Name);

            if (listBoxSSList.Items.Count > 0)
                listBoxSSList.SetSelected(data.SelectedIndex, true);
        }

        // ListBox上で選択が変化した時に呼ばれる処理
        private void listBoxSSList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_data == null) return;

            // ListBox上で選択中の項目のインデックス番号。-1なら未選択
            int i = listBoxSSList.SelectedIndex;

            if (i >= 0)
            {
                _data.SelectedIndex = i;
                textBoxName.Text = _data.DataList[i].Name;
                textBoxPath.Text = _data.DataList[i].Path;
                textBoxArgs.Text = _data.DataList[i].Args;
                textBoxPreview.Text = _data.DataList[i].Preview;
            }
        }

        // リストに追加
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (_data == null) return;

            string name = textBoxName.Text;
            string path = textBoxPath.Text;
            string args = textBoxArgs.Text;
            string preview = textBoxPreview.Text;

            if (name != "" && path != "")
            {
                listBoxSSList.Items.Add(name);
                _data.DataList.Add(new SSaverItem(name, path, args, preview));
            }
        }

        // 選択中の項目をリストから削除
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (_data == null) return;

            int i = listBoxSSList.SelectedIndex;
            if (i >= 0)
            {
                int idxmax = _data.DataList.Count;
                if (idxmax > 0 && idxmax > i)
                {
                    listBoxSSList.Items.RemoveAt(i);
                    _data.DataList.RemoveAt(i);
                }
            }
        }

        // データを保存
        private void buttonSave_Click(object sender, EventArgs e)
        {
            int i = listBoxSSList.SelectedIndex;
            if (i < 0)
            {
                MessageBox.Show("Please select from the list.");
                return;
            }

            Program.SaveDataFile(_data);
            Close();
        }

        public void UpdateItems()
        {
            if (_data == null) return;

            int i = listBoxSSList.SelectedIndex;
            if (i < 0) return;

            _data.SelectedIndex = i;
            string name = textBoxName.Text;
            string path = textBoxPath.Text;
            string args = textBoxArgs.Text;
            string preview = textBoxPreview.Text;
            SSaverItem item = new SSaverItem(name, path, args, preview);
            _data.DataList[i] = item;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateItems();
            UpdateListBox(_data);
        }

        private void buttonSelPath_Click(object sender, EventArgs e)
        {
            // ファイル選択ダイアログを表示してファイルパスを取得
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = ofd.FileName;
            }
        }

        private void buttonSelPreview_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                textBoxPreview.Text = ofd.FileName;
            }
        }

        private void buttonSelArgs_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                textBoxArgs.Text = ofd.FileName;
            }
        }
    }
}
