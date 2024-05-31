using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ProjectPictureManipulting
{
    public partial class ResizeImage : Form
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
        Image target_image;
        Image defaultImage;
        int width;
        int height;
        public ResizeImage()
        {
            InitializeComponent();
        }
        public void LoadImageOnResizeForm(Image image)
        {
            pictureBoxResize.Image = image;
        }

        private void ResizeImage_Load(object sender, EventArgs e)
        {
            target_image = pictureBoxResize.Image;
            defaultImage = pictureBoxResize.Image;
            width = target_image.Width;
            height = target_image.Height;
            txtbWidth.Text = width.ToString();
            txtbHeight.Text = height.ToString();
        }
        private void formCloseMethod(string name)
        {
            Application.OpenForms
           .OfType<Form>()
           .Where(form => String.Equals(form.Name, name))
           .ToList()
           .ForEach(form => form.Close());
        }
        private void btnSaveResize_Click(object sender, EventArgs e)
        {
            Main mainWindow = new();
            mainWindow.LoadImageOnMainForm(pictureBoxResize.Image);
            mainWindow.Show();
            formCloseMethod("ResizeImage");
        }
        private void btnDefaultResize_Click(object sender, EventArgs e)
        {
            pictureBoxResize.Image = defaultImage;
        }

        public Bitmap ResizeNow(int target_width, int target_height)
        {
            if (target_width < 1)
            {
                target_width = 1;
            }
            if (target_height < 1)
            {
                target_height = 1;
            }
            Rectangle dest_rect = new Rectangle(0, 0, target_width, target_height);
            Bitmap destImage = new Bitmap(target_width, target_height);
            destImage.SetResolution(target_image.HorizontalResolution, target_image.VerticalResolution);
            using (var g = Graphics.FromImage(destImage))
            {
                g.CompositingMode = CompositingMode.SourceCopy;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                using (var wrapmode = new ImageAttributes())
                {
                    wrapmode.SetWrapMode(WrapMode.TileFlipXY);
                    g.DrawImage(target_image, dest_rect, 0, 0, target_image.Width, target_image.Height, GraphicsUnit.Pixel, wrapmode);
                }
            }
            return destImage;
        }
        private void btnPreviewImage_Click(object sender, EventArgs e)
        {
            width = int.Parse(txtbWidth.Text);
            height = int.Parse(txtbHeight.Text);
            pictureBoxResize.Image = ResizeNow(width, height);
        }

        private void pnl1080x1080_Click(object sender, EventArgs e)
        {
            width = 1080;
            height = 1080;
            txtbWidth.Text = width.ToString();
            txtbHeight.Text = height.ToString();
            pictureBoxResize.Image = ResizeNow(width, height);
        }

        private void pnl1280x720_Click(object sender, EventArgs e)
        {
            width = 1280;
            height = 720;
            txtbWidth.Text = width.ToString();
            txtbHeight.Text = height.ToString();
            pictureBoxResize.Image = ResizeNow(width, height);
        }

        private void pnl1920x1080_Click(object sender, EventArgs e)
        {
            width = 1920;
            height = 1080;
            txtbWidth.Text = width.ToString();
            txtbHeight.Text = height.ToString();
            pictureBoxResize.Image = ResizeNow(width, height);
        }

        private void pnl1080x1920_Click(object sender, EventArgs e)
        {
            width = 1080;
            height = 1920;
            txtbWidth.Text = width.ToString();
            txtbHeight.Text = height.ToString();
            pictureBoxResize.Image = ResizeNow(width, height);
        }

        private void pnl2560x1440_Click(object sender, EventArgs e)
        {
            width = 2560;
            height = 1440;
            txtbWidth.Text = width.ToString();
            txtbHeight.Text = height.ToString();
            pictureBoxResize.Image = ResizeNow(width, height);
        }

        private void pnl1200x675_Click(object sender, EventArgs e)
        {
            width = 1200;
            height = 675;
            txtbWidth.Text = width.ToString();
            txtbHeight.Text = height.ToString();
            pictureBoxResize.Image = ResizeNow(width, height);
        }

        private void pnl3840x2160_Click(object sender, EventArgs e)
        {
            width = 3840;
            height = 2160;
            txtbWidth.Text = width.ToString();
            txtbHeight.Text = height.ToString();
            pictureBoxResize.Image = ResizeNow(width, height);
        }

        private void pnl7680x4320_Click(object sender, EventArgs e)
        {
            width = 7680;
            height = 4320;
            txtbWidth.Text = width.ToString();
            txtbHeight.Text = height.ToString();
            pictureBoxResize.Image = ResizeNow(width, height);
        }

        private void lblInstagramPost_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }



        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            formCloseMethod("ResizeImage");

        }

        private void btnMaximize_Click(object sender, EventArgs e)
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

        private void btnDefaultResize_MouseHover(object sender, EventArgs e)
        {
            label16.Visible = true;
        }

        private void btnDefaultResize_MouseLeave(object sender, EventArgs e)
        {
            label16.Visible = false;
        }

        private void btnPreviewImage_MouseHover(object sender, EventArgs e)
        {
            label17.Visible = true;
        }

        private void btnPreviewImage_MouseLeave(object sender, EventArgs e)
        {
            label17.Visible = false;
        }

        private void btnSaveResize_MouseHover(object sender, EventArgs e)
        {
            label18.Visible = true;
        }

        private void btnSaveResize_MouseLeave(object sender, EventArgs e)
        {
            label18.Visible = false;
        }
    }
}
