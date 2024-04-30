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
        int width;
        int height;
        public ResizeImage()
        {
            InitializeComponent();
        }
        private void ResizeImage_Load(object sender, EventArgs e)
        {
            target_image = pictureBoxResize.Image;
            width = target_image.Width;
            height = target_image.Height;
        }
        private void btnSaveResize_Click(object sender, EventArgs e)
        {
            if (pictureBoxResize.Image is null)
            {
                //EmptyPictureBoxException();

            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "JPeg Image|*.jpg|PNG Image|*.png";
                ImageFormat format = ImageFormat.Png;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string ext = Path.GetExtension(sfd.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".png":
                            format = ImageFormat.Png;
                            break;
                    }
                    pictureBoxResize.Image.Save(sfd.FileName, format);
                }
                label1.Text = "Image saved successfully!!!!";
            }


        }

        private void btnDefaultResize_Click(object sender, EventArgs e)
        {

        }
        public void SetImage(Image image)
        {
            pictureBoxResize.Image = image;
        }

        private Bitmap ResizeNow(int target_width, int target_height)
        {
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

        private void trbWidth_Scroll(object sender, EventArgs e)
        {
            width = (target_image.Width * trbWidth.Value) / 100;
            pictureBoxResize.Image = ResizeNow(width, height);
        }

        private void trbHeight_Scroll(object sender, EventArgs e)
        {
            height = (target_image.Height * trbHeight.Value) / 100;
            pictureBoxResize.Image = ResizeNow(width, height);
        }


    }
}
