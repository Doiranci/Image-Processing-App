using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPictureManipulting
{
    public partial class ResizeImage : Form
    {
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
        }
        
        private void btnSaveResize_Click(object sender, EventArgs e)
        {
            Main mainWindow = new();
            mainWindow.LoadImageOnMainForm(pictureBoxResize.Image);
            mainWindow.Show();
        }

        private void btnDefaultResize_Click(object sender, EventArgs e)
        {
            pictureBoxResize.Image = defaultImage;
        }

        private Bitmap ResizeNow(int target_width, int target_height)
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
    }
}
