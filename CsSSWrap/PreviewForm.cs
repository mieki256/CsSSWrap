using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsSSWrap
{
    public partial class PreviewForm : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);

        public PreviewForm(IntPtr hWnd, string name, string imagePath)
        {
            InitializeComponent();
            // 親のフォームを指定
            SetParent(Handle, hWnd);

            // GWL_STYLE = -16, WS_CHILD = 0x40000000
            SetWindowLong(Handle, -16, new IntPtr(GetWindowLong(Handle, -16) | 0x40000000));

            Rectangle ParentRect;
            GetClientRect(hWnd, out ParentRect);
            Size = ParentRect.Size;
            Location = new Point(0, 0);

            if (imagePath == "" || !File.Exists(imagePath) )
            {
                // 文字列(Label)のみを表示

                label1.Font = new Font("Tahoma", 11, FontStyle.Bold);
                if (name == "" || name == "None")
                {
                    label1.Text = Properties.Resources.AppliName;
                }
                else
                {
                    label1.Text = name;
                }
                label1.ForeColor = Color.DarkGreen;
                BackColor = Color.LawnGreen;
                label1.Location = new Point((152 - label1.Width) / 2, (112 - label1.Height) / 2);

                pictureBox1.Hide();
            }
            else
            {
                // bmp画像を表示
                pictureBox1.ImageLocation = imagePath;
                pictureBox1.Visible = true;
                label1.Hide();
            }
        }
    }
}
