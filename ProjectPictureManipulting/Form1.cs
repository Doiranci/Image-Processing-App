using ImageProcessor.Processors;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;

namespace ProjectPictureManipulting
{

    public partial class Form1 : Form
    {
        public Bitmap AdjustBrightnessContrast(Image image, int contrastValue, int brightnessValue)
        {
            float brightness = (brightnessValue / 100.0f);
            float contrast = contrastValue / 100.0f;
            var bitmap = new Bitmap(image.Width, image.Height, PixelFormat.Format32bppArgb);

            using (var g = Graphics.FromImage(bitmap))
            using (var attributes = new ImageAttributes())
            {
                float[][] matrix = {
            new float[] { contrast, 0, 0, 0, 0},
            new float[] {0, contrast, 0, 0, 0},
            new float[] {0, 0, contrast, 0, 0},
            new float[] {0, 0, 0, 1, 0},
            new float[] {brightness, brightness, brightness, 1, 1}
        };

                ColorMatrix colorMatrix = new ColorMatrix(matrix);
                attributes.SetColorMatrix(colorMatrix);
                g.DrawImage(image, new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                    0, 0, bitmap.Width, bitmap.Height, GraphicsUnit.Pixel, attributes);
                return bitmap;
            }
        }

        int grip = 16;
        int caption = 40;
        protected override void WndProc(ref Message m) // This makes the form drag-resizable
        {
            if (m.Msg == 0x84)
            {
                Point p = new Point(m.LParam.ToInt32());
                p = this.PointToClient(p);
                if (p.Y <= caption && p.Y >= grip)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (p.X >= this.ClientSize.Width - grip && p.Y >= this.ClientSize.Height - grip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
                if (p.X <= grip && p.Y >= this.ClientSize.Height - grip)
                {
                    m.Result = (IntPtr)16;
                    return;
                }
                if (p.X <= grip)
                {
                    m.Result = (IntPtr)10;
                    return;
                }
                if (p.X >= ClientSize.Width - grip)
                {
                    m.Result = (IntPtr)11;
                    return;
                }
                if (p.Y <= grip)
                {
                    m.Result = (IntPtr)12;
                    return;
                }
                if (p.Y >= this.ClientSize.Height - grip)
                {
                    m.Result = (IntPtr)15;
                    return;
                }
            }
            base.WndProc(ref m);
        }
        public static Bitmap ConvertToGrayscale(Bitmap original)
        {
            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            //get a graphics object from the new image
            Graphics g = Graphics.FromImage(newBitmap);

            //create the grayscale ColorMatrix
            ColorMatrix colorMatrix = new ColorMatrix(
               [
         [.3f, .3f, .3f, 0, 0],
         [.59f, .59f, .59f, 0, 0],
         [.11f, .11f, .11f, 0, 0],
         [0, 0, 0, 1, 0],
         [0, 0, 0, 0, 1]
               ]);

            //create some image attributes
            ImageAttributes attributes = new ImageAttributes();

            //set the color matrix attribute

            attributes.SetColorMatrix(colorMatrix);
            //draw the original image on the new image
            //using the grayscale color matrix
            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
               0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);

            //dispose the Graphics object
            g.Dispose();
            return newBitmap;
        }

        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg;  *.gif; *.bmp;)|*.jpg; *.jpeg;  *.gif; *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                MemoryStream ms = new MemoryStream(File.ReadAllBytes(open.FileName));
                pictureBox1.Image = new Bitmap(ms);
                originalImage = new Bitmap(ms);
            }

        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image is null)
            {
                EmptyPictureBoxException();

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
                    pictureBox1.Image.Save(sfd.FileName, format);
                }
                label1.Text = "Image saved successfully!!!!";
            }


        }
        bool isGreyscaled;
        Bitmap originalImage;
        private void btnGreyScale_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image is null)
            {
                EmptyPictureBoxException();
            }
            else
            {
                Bitmap defaultImage = new(pictureBox1.Image);

                if (!isGreyscaled)
                {
                    pictureBox1.Image = ConvertToGrayscale(defaultImage);
                    isGreyscaled = true;
                }
                else
                {
                    pictureBox1.Image = originalImage;
                    isGreyscaled = false;
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.MaximumSize = new(1200, 1600);

        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image is null)
            {
                EmptyPictureBoxException();
            }

            // Get the current image from the PictureBox
            Image currentImage = pictureBox1.Image;

            if (currentImage != null)
            {
                // Rotate the image by 90 degrees clockwise
                currentImage.RotateFlip(RotateFlipType.Rotate90FlipNone);

                // Update the PictureBox with the rotated image
                pictureBox1.Image = currentImage;

                // Force the PictureBox to redraw
                pictureBox1.Invalidate();
            }
        }

        private void btnFlip_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image is null)
            {
                EmptyPictureBoxException();
            }
            else
            {
                btnHorizontalFlip.Visible = !btnHorizontalFlip.Visible;
                btnVerticleFlip.Visible = !btnVerticleFlip.Visible;
            }
        }

        private void btnHorizontalFlip_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image is null)
            {
                EmptyPictureBoxException();
            }

            // Get the current image from the PictureBox
            Image currentImage = pictureBox1.Image;

            if (currentImage != null)
            {
                // Flip the image horizontally
                currentImage.RotateFlip(RotateFlipType.RotateNoneFlipX);

                // Update the PictureBox with the flipped image
                pictureBox1.Image = currentImage;

                // Force the PictureBox to redraw
                pictureBox1.Invalidate();
            }
        }

        private void btnVerticleFlip_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image is null)
            {
                EmptyPictureBoxException();
            }
            // Get the current image from the PictureBox
            Image currentImage = pictureBox1.Image;

            if (currentImage != null)
            {
                // Flip the image horizontally
                currentImage.RotateFlip(RotateFlipType.RotateNoneFlipY);

                // Update the PictureBox with the flipped image
                pictureBox1.Image = currentImage;

                // Force the PictureBox to redraw
                pictureBox1.Invalidate();
            }
        }
        Bitmap adjustBitmap;
        private void Slider_Scroll(object sender, EventArgs e)
        {
            //pictureBox1.Image?.Dispose();
            pictureBox1.Image = AdjustBrightnessContrast(adjustBitmap, trbContrast.Value, trbBrightness.Value);
        }

        private void btnBrightnessContrast_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image is null)
            {
                EmptyPictureBoxException();
            }
            else
            {
                trbBrightness.Visible = !trbBrightness.Visible;
                trbContrast.Visible = !trbContrast.Visible;
                lblBrightness.Visible = !lblBrightness.Visible;
                lblContrast.Visible = !lblContrast.Visible;
                btnDefaultBNC.Visible = !btnDefaultBNC.Visible;

                adjustBitmap = new Bitmap(pictureBox1.Image);
            }
        }

        private void btnDefaultBNC_Click(object sender, EventArgs e)
        {
            trbContrast.Value = 100;
            trbBrightness.Value = 0;
            pictureBox1.Image = AdjustBrightnessContrast(adjustBitmap, trbContrast.Value, trbBrightness.Value);
        }


        public static void EmptyPictureBoxException()
        {
            MessageBox.Show("You need to insert picture first!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }

}
