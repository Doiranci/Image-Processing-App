using ImageProcessor.Processors;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Drawing.Drawing2D;
using AForge.Imaging.Filters;
using System.Runtime.CompilerServices;

namespace ProjectPictureManipulting
{

    public partial class Main : Form
    {


        private Rectangle selectionRectangle;
        public void LoadImageOnMainForm(Image image)
        {
            int width = 0;
            int height = 0;
            originalImage = new Bitmap(image);
            target_image = new Bitmap(image);
            double aspectRatio = 0;
            if (originalImage.Width > originalImage.Height)
            {
                aspectRatio = (double)originalImage.Height / originalImage.Width;
                if (aspectRatio * 1600 > 1280)
                {
                    height = 1280;
                }
                else
                {
                    height = (int)(aspectRatio * 1600);
                }
                aspectRatio = (double)originalImage.Width / originalImage.Height;
                if (aspectRatio * 1600 > 1440)
                {
                    width = 1440;
                }
                else
                {
                    width = (int)(aspectRatio * 1600);
                }

            }
            else if (originalImage.Width < originalImage.Height)
            {
                aspectRatio = (double)originalImage.Width / originalImage.Height;
                if (aspectRatio * 1600 > 1280)
                {
                    width = 1280;
                }
                else
                {
                    width = (int)(aspectRatio * 1600);
                }
                aspectRatio = (double)originalImage.Height / originalImage.Width;
                if (aspectRatio * 1600 > 1440)
                {
                    height = 1440;
                }
                else
                {
                    height = (int)(aspectRatio * 1600);
                }
            }
            else
            {
                width = 1440;
                height = 1440;
            }
            inputImage.Image = ResizeNow(width, height);
            inputImage.Image = image;
            originalImage = (Bitmap)inputImage.Image;
        }
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
        //Martin e gei

        public Main()
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
                originalImage = new Bitmap(ms);
                LoadImageOnMainForm(originalImage);
            }
        }
        Image target_image;
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





        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            if (inputImage.Image is null)
            {
                EmptyPictureBoxException();

            }
            else
            {
                inputImage.Image = ResizeNow(originalImage.Width, originalImage.Height);
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
                    inputImage.Image.Save(sfd.FileName, format);
                }

            }


        }
        bool isGreyscaled;
        Bitmap originalImage;
        private void btnGreyScale_Click(object sender, EventArgs e)
        {
            if (inputImage.Image is null)
            {
                EmptyPictureBoxException();
            }
            else
            {
                Bitmap defaultImage = new(inputImage.Image);

                if (!isGreyscaled)
                {
                    inputImage.Image = ConvertToGrayscale(defaultImage);
                    isGreyscaled = true;
                }
                else
                {
                    inputImage.Image = originalImage;
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
            if (inputImage.Image is null)
            {
                EmptyPictureBoxException();
            }

            // Get the current image from the PictureBox
            Image currentImage = inputImage.Image;

            if (currentImage != null)
            {
                // Rotate the image by 90 degrees clockwise
                currentImage.RotateFlip(RotateFlipType.Rotate90FlipNone);

                // Update the PictureBox with the rotated image
                inputImage.Image = currentImage;

                // Force the PictureBox to redraw
                inputImage.Invalidate();
            }
        }

        private void btnFlip_Click(object sender, EventArgs e)
        {
            if (inputImage.Image is null)
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
            if (inputImage.Image is null)
            {
                EmptyPictureBoxException();
            }

            // Get the current image from the PictureBox
            Image currentImage = inputImage.Image;

            if (currentImage != null)
            {
                // Flip the image horizontally
                currentImage.RotateFlip(RotateFlipType.RotateNoneFlipX);

                // Update the PictureBox with the flipped image
                inputImage.Image = currentImage;

                // Force the PictureBox to redraw
                inputImage.Invalidate();
            }
        }

        private void btnVerticleFlip_Click(object sender, EventArgs e)
        {
            if (inputImage.Image is null)
            {
                EmptyPictureBoxException();
            }
            // Get the current image from the PictureBox
            Image currentImage = inputImage.Image;

            if (currentImage != null)
            {
                // Flip the image horizontally
                currentImage.RotateFlip(RotateFlipType.RotateNoneFlipY);

                // Update the PictureBox with the flipped image
                inputImage.Image = currentImage;

                // Force the PictureBox to redraw
                inputImage.Invalidate();
            }
        }
        Bitmap adjustBitmap;
        private void Slider_Scroll(object sender, EventArgs e)
        {
            //pictureBox1.Image?.Dispose();
            inputImage.Image = AdjustBrightnessContrast(adjustBitmap, trbContrast.Value, trbBrightness.Value);
        }

        private void btnBrightnessContrast_Click(object sender, EventArgs e)
        {
            if (inputImage.Image is null)
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

                adjustBitmap = new Bitmap(inputImage.Image);
            }
        }

        private void btnDefaultBNC_Click(object sender, EventArgs e)
        {
            trbContrast.Value = 100;
            trbBrightness.Value = 0;
            inputImage.Image = AdjustBrightnessContrast(adjustBitmap, trbContrast.Value, trbBrightness.Value);
        }

        private void btnReisize_Click(object sender, EventArgs e)
        {

            if (inputImage.Image is null)
            {
                EmptyPictureBoxException();
            }
            else
            {
                ResizeImage resize = new ResizeImage();
                resize.LoadImageOnResizeForm(inputImage.Image);
                resize.Show();
                ResizeImage.formCloseMethod("Main");
            }
        }

        public static void EmptyPictureBoxException()
        {
            MessageBox.Show("You need to insert picture first!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBlur_Click(object sender, EventArgs e)
        {

            if (inputImage.Image is null)
            {
                EmptyPictureBoxException();
            }
            else
            {
                if (selectionRectangle.Width <= 0 || selectionRectangle.Height <= 0)
                {
                    MessageBox.Show("Please select a region to blur.", "Not valid operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                if (int.TryParse(txtbBlur.Text, out int blurScale))
                {

                    if (blurScale < 0)
                    {
                        blurScale = 0;
                    }
                    else if (blurScale > 20)
                    {
                        blurScale = 20;
                    }
                    txtbBlur.Text = blurScale.ToString();
                    for (int i = 0; i < blurScale; i++)
                    {
                        ApplyBlurToSelection();
                    }
                }
                else
                {
                    MessageBox.Show("Please select blur scale in the text box wich is from 1 to 20", "Not valid operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            if (inputImage.Image is null)
            {
                EmptyPictureBoxException();
            }
            else
            {
                // Get the scale factors for converting PictureBox coordinates to image coordinates
                float scaleX = (float)inputImage.Image.Width / inputImage.Width;
                float scaleY = (float)inputImage.Image.Height / inputImage.Height;

                // Calculate the starting point of the selection rectangle in image coordinates
                int startX = (int)(e.X * scaleX);
                int startY = (int)(e.Y * scaleY);


                selectionRectangle = new Rectangle(startX, startY, 0, 0);
                inputImage.Refresh();
            }

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            // Get the scale factors for converting PictureBox coordinates to image coordinates
            float scaleX = (float)inputImage.Image.Width / inputImage.Width;
            float scaleY = (float)inputImage.Image.Height / inputImage.Height;

            // Calculate the end point of the selection rectangle in image coordinates
            int endX = (int)(e.X * scaleX);
            int endY = (int)(e.Y * scaleY);



            selectionRectangle.Width = endX - selectionRectangle.X;
            selectionRectangle.Height = endY - selectionRectangle.Y;
            inputImage.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            // Get the scale factors for converting PictureBox coordinates to image coordinates
            float scaleX = (float)inputImage.Image.Width / inputImage.Width;
            float scaleY = (float)inputImage.Image.Height / inputImage.Height;

            // Calculate the end point of the selection rectangle in image coordinates
            int endX = (int)(e.X * scaleX);
            int endY = (int)(e.Y * scaleY);

            //MessageBox.Show($"Mouse Up - PictureBox: X: {e.X}, Y: {e.Y}, Image: X: {endX}, Y: {endY}");
            //MessageBox.Show($"Mouse Up scaleX: {scaleX}, scaleY: {scaleY}");


            selectionRectangle.Width = endX - selectionRectangle.X;
            selectionRectangle.Height = endY - selectionRectangle.Y;
            inputImage.Refresh();
            txtbBlur.Visible = !txtbBlur.Visible;
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            if (selectionRectangle != null && selectionRectangle.Width > 0 && selectionRectangle.Height > 0)
            {
                // Get the scale factors for converting image coordinates to PictureBox coordinates
                float scaleX = (float)inputImage.Width / inputImage.Image.Width;
                float scaleY = (float)inputImage.Height / inputImage.Image.Height;

                // Convert the selection rectangle from image coordinates to PictureBox coordinates
                Rectangle scaledRectangle = new Rectangle(
                    (int)(selectionRectangle.X * scaleX),
                    (int)(selectionRectangle.Y * scaleY),
                    (int)(selectionRectangle.Width * scaleX),
                    (int)(selectionRectangle.Height * scaleY));

                // Draw the selection rectangle on the PictureBox
                using (Pen pen = new Pen(Color.Red))
                {
                    e.Graphics.DrawRectangle(pen, scaledRectangle);
                }
            }
        }
        private void ApplyBlurToSelection()
        {
            Bitmap imageToBlur = (Bitmap)inputImage.Image.Clone();

            // Crop the selected region from the original image
            Rectangle croppedRect = new Rectangle(
                Math.Max(0, selectionRectangle.X),  // Ensure X is non-negative
                Math.Max(0, selectionRectangle.Y),  // Ensure Y is non-negative
                Math.Min(selectionRectangle.Width, imageToBlur.Width - selectionRectangle.X),  // Ensure width is within image bounds
                Math.Min(selectionRectangle.Height, imageToBlur.Height - selectionRectangle.Y));  // Ensure height is within image bounds

            if (croppedRect.Width <= 0 || croppedRect.Height <= 0)
            {
                MessageBox.Show("Selected region is outside the image bounds.", "Not valid operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Bitmap selectedRegion = imageToBlur.Clone(croppedRect, imageToBlur.PixelFormat);

            // Apply blur filter to the selected region
            AForge.Imaging.Filters.GaussianBlur filter = new AForge.Imaging.Filters.GaussianBlur();
            filter.Sigma = 20; // Adjust blur intensity here

            Bitmap blurredRegion = filter.Apply(selectedRegion);



            // Replace the selected region with the blurred region in the original image
            using (Graphics g = Graphics.FromImage(imageToBlur))
            {
                g.DrawImage(blurredRegion, croppedRect.Location);
            }

            // Update PictureBox with the modified image
            inputImage.Image = imageToBlur;



        }
        enum filterNames
        {
            AquaBlue = 0,
            Coral = 1,
            DarkViolet = 2,
            Default = 3
        }

        public static Image filterImage(Image inputImage, Color color)
        {
            Bitmap outputImage = new Bitmap(inputImage);

            Graphics g = Graphics.FromImage(outputImage);
            g.DrawImage(inputImage, 0, 0);



            g.FillRectangle(new SolidBrush(Color.FromArgb(100, color)), 0, 0, inputImage.Width, inputImage.Height);

            return outputImage;

        }
        bool isFiltered = false;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (inputImage.Image is null)
            {
                EmptyPictureBoxException();
            }
            else
            {
                if (!isFiltered)
                {
                    originalImage = new Bitmap(inputImage.Image);
                    int chosenColor = comboBox1.SelectedIndex;
                    Color color = Color.Transparent;


                    switch (chosenColor)
                    {
                        case (int)filterNames.AquaBlue:
                            color = Color.Aquamarine;
                            inputImage.Image = filterImage(originalImage, color);
                            break;
                        case (int)filterNames.Coral:
                            color = Color.Coral;
                            inputImage.Image = filterImage(originalImage, color);
                            break;
                        case (int)filterNames.DarkViolet:
                            color = Color.DarkViolet;
                            inputImage.Image = filterImage(originalImage, color);
                            break;
                        case (int)filterNames.Default:
                            inputImage.Image = originalImage;
                            break;
                        default:
                            break;
                    }

                    isFiltered = true;
                }
                else
                {
                    int chosenColor = comboBox1.SelectedIndex;
                    Color color = Color.Transparent;

                    switch (chosenColor)
                    {
                        case (int)filterNames.AquaBlue:
                            color = Color.Aquamarine;
                            inputImage.Image = filterImage(originalImage, color);
                            break;
                        case (int)filterNames.Coral:
                            color = Color.Coral;
                            inputImage.Image = filterImage(originalImage, color);
                            break;
                        case (int)filterNames.DarkViolet:
                            color = Color.DarkViolet;
                            inputImage.Image = filterImage(originalImage, color);
                            break;
                        case (int)filterNames.Default:
                            inputImage.Image = originalImage;
                            break;
                        default:
                            break;
                    }

                    isFiltered = true;
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void txtbBlur_TextChanged(object sender, EventArgs e)
        {

        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            if (inputImage.Image is null)
            {
                EmptyPictureBoxException();
            }
            else
            {
                comboBox1.Visible = !comboBox1.Visible;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputImage.Image is null)
            {
                EmptyPictureBoxException();

            }
            else
            {
                inputImage.Image = originalImage;

            }
        }

        private void btnUploadImage_MouseHover(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        private void btnUploadImage_MouseLeave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void btnSaveImage_MouseHover(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void btnSaveImage_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }
        private void button1_MouseHover_1(object sender, EventArgs e)
        {
            label11.Visible = true;
        }

        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            label11.Visible = false;
        }

        private void btnFlip_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = true;
        }
        private void btnFlip_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void btnRotate_MouseHover(object sender, EventArgs e)
        {
            label5.Visible = true;
        }


        private void btnRotate_MouseLeave(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void btnBrightnessContrast_MouseHover(object sender, EventArgs e)
        {
            label6.Visible = true;
        }

        private void btnBrightnessContrast_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void btnReisize_MouseHover(object sender, EventArgs e)
        {
            label7.Visible = true;
        }

        private void btnReisize_MouseLeave(object sender, EventArgs e)
        {
            label7.Visible = false;
        }

        private void btnGreyScale_MouseHover(object sender, EventArgs e)
        {
            label8.Visible = true;
        }

        private void btnGreyScale_MouseLeave(object sender, EventArgs e)
        {
            label8.Visible = false;
        }

        private void btnBlur_MouseHover(object sender, EventArgs e)
        {
            label9.Visible = true;
        }

        private void btnBlur_MouseLeave(object sender, EventArgs e)
        {
            label9.Visible = false;
        }

        private void btnFilter_MouseHover(object sender, EventArgs e)
        {
            label10.Visible = true;
        }

        private void btnFilter_MouseLeave(object sender, EventArgs e)
        {
            label10.Visible = false;
        }

        private void inputImage_DragDrop(object sender, DragEventArgs e)
        {
            bool isImageLoaded = false;
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                {
                    inputImage.Image = Image.FromFile(fileNames[0]);
                    isImageLoaded = true;

                }

            }
            if (isImageLoaded == true)
            {

                Image image = inputImage.Image;
                Bitmap pic = new(image);
            }
        }

        private void inputImage_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }

}
