namespace CsSSWrap
{
    public partial class ScreenSaverForm : Form
    {
        private Random _random = new Random();
        private Point _mousePos;

        public ScreenSaverForm(Rectangle bounds)
        {
            InitializeComponent();

            // フォームのサイズを与えられたサイズで置き換える
            Bounds = bounds;
        }

        private void ScreenSaverForm_Load(object sender, EventArgs e)
        {
            // マウスカーソル非表示
            Cursor.Hide();

            // 最前面に表示
            TopMost = true;

            // 一定時間(ミリ秒)毎に呼ばれる処理を設定
            moveTimer.Interval = 1000;
            moveTimer.Tick += new EventHandler(moveTimer_Tick);
            moveTimer.Start();
        }

        // 一定時間毎に呼ばれる処理
        private void moveTimer_Tick(object? sender, EventArgs e)
        {
            // labelの表示位置をランダムに変える
            label1.Left = _random.Next(Math.Max(1, Bounds.Width - label1.Width));
            label1.Top = _random.Next(Math.Max(1, Bounds.Height - label1.Height));
        }

        private void ScreenSaverForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ScreenSaverForm_MouseDown(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void ScreenSaverForm_KeyDown(object sender, KeyEventArgs e)
        {
            Application.Exit();
        }

        private void ScreenSaverForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Application.Exit();
        }

        private void ScreenSaverForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_mousePos.IsEmpty)
            {
                int dx = _mousePos.X - e.X;
                int dy = _mousePos.Y - e.Y;
                int dist = 16;
                if ((dx * dx) + (dy * dy) > (dist * dist))
                {
                    Application.Exit();
                }
            }

            _mousePos = e.Location;
        }

    }
}
