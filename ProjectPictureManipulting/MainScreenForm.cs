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

namespace ProjectPictureManipulting
{
    public partial class MainScreenForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        public MainScreenForm()
        {
            InitializeComponent();
        }

        private void MainScreenForm_Load(object sender, EventArgs e)
        {
            pictureBox3.AllowDrop = true;
        }
        private void button1_Click(object sender, EventArgs e) // Switching to Main Form app
        {
            Main main = new Main();
            main.Show();
            this.Close();

        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {

                WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_DragDrop(object sender, DragEventArgs e)
        {
           
            bool isImageLoaded = false;
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                {
                    pictureBox3.Image = Image.FromFile(fileNames[0]);
                    isImageLoaded = true;

                }

            }
            if (isImageLoaded == true)
            {
                
                Image image = pictureBox3.Image;
                Bitmap pic = new(image);
                Main openMain = new Main();
                openMain.LoadImageOnMainForm(pic);
                openMain.Show();
                this.Close();
            }
        }

        private void pictureBox3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
