namespace ProjectPictureManipulting
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Header = new Panel();
            panel1 = new Panel();
            btnClose = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            btnUploadImage = new Button();
            btnSaveImage = new Button();
            inputImage = new PictureBox();
            label1 = new Label();
            btnGreyScale = new Button();
            saveFileDialog1 = new SaveFileDialog();
            panel2 = new Panel();
            btnRotate = new Button();
            btnFlip = new Button();
            btnHorizontalFlip = new Button();
            btnVerticleFlip = new Button();
            trbContrast = new TrackBar();
            trbBrightness = new TrackBar();
            btnBrightnessContrast = new Button();
            lblContrast = new Label();
            lblBrightness = new Label();
            btnDefaultBNC = new Button();
            btnReisize = new Button();
            btnBlur = new Button();
            txtbBlur = new TextBox();
            comboBox1 = new ComboBox();
            Header.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inputImage).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trbContrast).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbBrightness).BeginInit();
            SuspendLayout();
            // 
            // Header
            // 
            Header.BackColor = SystemColors.ActiveBorder;
            Header.Controls.Add(panel1);
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(800, 37);
            Header.TabIndex = 2;
            Header.MouseDown += OnMouseDown;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnMaximize);
            panel1.Controls.Add(btnMinimize);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(664, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(136, 37);
            panel1.TabIndex = 0;
            panel1.MouseDown += OnMouseDown;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(100, 8);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(24, 23);
            btnClose.TabIndex = 2;
            btnClose.Text = "\r\n";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.BackColor = Color.Transparent;
            btnMaximize.Cursor = Cursors.Hand;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Image = (Image)resources.GetObject("btnMaximize.Image");
            btnMaximize.Location = new Point(60, 8);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(23, 23);
            btnMaximize.TabIndex = 1;
            btnMaximize.Text = "\r\n";
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(18, 8);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(24, 23);
            btnMinimize.TabIndex = 0;
            btnMinimize.Text = "\r\n";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnUploadImage
            // 
            btnUploadImage.Location = new Point(15, 45);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(139, 32);
            btnUploadImage.TabIndex = 3;
            btnUploadImage.Text = "Upload Image";
            btnUploadImage.UseVisualStyleBackColor = true;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // btnSaveImage
            // 
            btnSaveImage.Location = new Point(160, 47);
            btnSaveImage.Name = "btnSaveImage";
            btnSaveImage.Size = new Size(63, 29);
            btnSaveImage.TabIndex = 4;
            btnSaveImage.Text = "Save";
            btnSaveImage.UseVisualStyleBackColor = true;
            btnSaveImage.Click += btnSaveImage_Click;
            // 
            // inputImage
            // 
            inputImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputImage.Location = new Point(3, 3);
            inputImage.Name = "inputImage";
            inputImage.Size = new Size(431, 293);
            inputImage.SizeMode = PictureBoxSizeMode.Zoom;
            inputImage.TabIndex = 5;
            inputImage.TabStop = false;
            inputImage.Paint += pictureBox1_Paint;
            inputImage.MouseDown += pictureBox1_MouseDown;
            inputImage.MouseMove += pictureBox1_MouseMove;
            inputImage.MouseUp += pictureBox1_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(232, 376);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 7;
            // 
            // btnGreyScale
            // 
            btnGreyScale.Location = new Point(229, 45);
            btnGreyScale.Name = "btnGreyScale";
            btnGreyScale.Size = new Size(98, 30);
            btnGreyScale.TabIndex = 8;
            btnGreyScale.Text = "Grey scale";
            btnGreyScale.UseVisualStyleBackColor = true;
            btnGreyScale.Click += btnGreyScale_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ButtonShadow;
            panel2.Controls.Add(inputImage);
            panel2.Location = new Point(12, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(437, 299);
            panel2.TabIndex = 9;
            panel2.Paint += panel2_Paint;
            // 
            // btnRotate
            // 
            btnRotate.Location = new Point(15, 83);
            btnRotate.Name = "btnRotate";
            btnRotate.Size = new Size(98, 24);
            btnRotate.TabIndex = 10;
            btnRotate.Text = "Rotate";
            btnRotate.UseVisualStyleBackColor = true;
            btnRotate.Click += btnRotate_Click;
            // 
            // btnFlip
            // 
            btnFlip.Location = new Point(160, 84);
            btnFlip.Name = "btnFlip";
            btnFlip.Size = new Size(99, 23);
            btnFlip.TabIndex = 11;
            btnFlip.Text = "Flip";
            btnFlip.UseVisualStyleBackColor = true;
            btnFlip.Click += btnFlip_Click;
            // 
            // btnHorizontalFlip
            // 
            btnHorizontalFlip.Location = new Point(130, 111);
            btnHorizontalFlip.Name = "btnHorizontalFlip";
            btnHorizontalFlip.Size = new Size(79, 22);
            btnHorizontalFlip.TabIndex = 12;
            btnHorizontalFlip.Text = "Horizontal";
            btnHorizontalFlip.UseVisualStyleBackColor = true;
            btnHorizontalFlip.Visible = false;
            btnHorizontalFlip.Click += btnHorizontalFlip_Click;
            // 
            // btnVerticleFlip
            // 
            btnVerticleFlip.Location = new Point(215, 111);
            btnVerticleFlip.Name = "btnVerticleFlip";
            btnVerticleFlip.Size = new Size(79, 22);
            btnVerticleFlip.TabIndex = 13;
            btnVerticleFlip.Text = "Verticle";
            btnVerticleFlip.UseVisualStyleBackColor = true;
            btnVerticleFlip.Visible = false;
            btnVerticleFlip.Click += btnVerticleFlip_Click;
            // 
            // trbContrast
            // 
            trbContrast.Location = new Point(447, 79);
            trbContrast.Maximum = 200;
            trbContrast.Name = "trbContrast";
            trbContrast.Size = new Size(154, 45);
            trbContrast.TabIndex = 14;
            trbContrast.Value = 100;
            trbContrast.Visible = false;
            trbContrast.Scroll += Slider_Scroll;
            // 
            // trbBrightness
            // 
            trbBrightness.Location = new Point(632, 79);
            trbBrightness.Maximum = 100;
            trbBrightness.Minimum = -100;
            trbBrightness.Name = "trbBrightness";
            trbBrightness.Size = new Size(168, 45);
            trbBrightness.TabIndex = 15;
            trbBrightness.Visible = false;
            trbBrightness.Scroll += Slider_Scroll;
            // 
            // btnBrightnessContrast
            // 
            btnBrightnessContrast.Location = new Point(550, 49);
            btnBrightnessContrast.Name = "btnBrightnessContrast";
            btnBrightnessContrast.Size = new Size(156, 24);
            btnBrightnessContrast.TabIndex = 16;
            btnBrightnessContrast.Text = "ContrastAndBrightness";
            btnBrightnessContrast.UseVisualStyleBackColor = true;
            btnBrightnessContrast.Click += btnBrightnessContrast_Click;
            // 
            // lblContrast
            // 
            lblContrast.AutoSize = true;
            lblContrast.Location = new Point(472, 127);
            lblContrast.Name = "lblContrast";
            lblContrast.Size = new Size(52, 15);
            lblContrast.TabIndex = 17;
            lblContrast.Text = "Contrast";
            lblContrast.Visible = false;
            // 
            // lblBrightness
            // 
            lblBrightness.AutoSize = true;
            lblBrightness.Location = new Point(695, 127);
            lblBrightness.Name = "lblBrightness";
            lblBrightness.Size = new Size(62, 15);
            lblBrightness.TabIndex = 18;
            lblBrightness.Text = "Brightness";
            lblBrightness.Visible = false;
            // 
            // btnDefaultBNC
            // 
            btnDefaultBNC.Location = new Point(591, 123);
            btnDefaultBNC.Name = "btnDefaultBNC";
            btnDefaultBNC.Size = new Size(54, 23);
            btnDefaultBNC.TabIndex = 19;
            btnDefaultBNC.Text = "Default";
            btnDefaultBNC.UseVisualStyleBackColor = true;
            btnDefaultBNC.Visible = false;
            btnDefaultBNC.Click += btnDefaultBNC_Click;
            // 
            // btnReisize
            // 
            btnReisize.Location = new Point(472, 196);
            btnReisize.Name = "btnReisize";
            btnReisize.Size = new Size(77, 31);
            btnReisize.TabIndex = 20;
            btnReisize.Text = "Resize";
            btnReisize.UseVisualStyleBackColor = true;
            btnReisize.Click += btnReisize_Click;
            // 
            // btnBlur
            // 
            btnBlur.Location = new Point(555, 196);
            btnBlur.Name = "btnBlur";
            btnBlur.Size = new Size(77, 31);
            btnBlur.TabIndex = 21;
            btnBlur.Text = "Blur";
            btnBlur.UseVisualStyleBackColor = true;
            btnBlur.Click += btnBlur_Click;
            // 
            // txtbBlur
            // 
            txtbBlur.Location = new Point(557, 234);
            txtbBlur.Name = "txtbBlur";
            txtbBlur.Size = new Size(74, 23);
            txtbBlur.TabIndex = 22;
            txtbBlur.Text = "Blur: 1-20";
            txtbBlur.TextAlign = HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "AquaBlue", "Coral", "DarkViolet", "Default" });
            comboBox1.Location = new Point(659, 196);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(129, 23);
            comboBox1.TabIndex = 23;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Main
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(txtbBlur);
            Controls.Add(btnBlur);
            Controls.Add(btnReisize);
            Controls.Add(btnDefaultBNC);
            Controls.Add(lblBrightness);
            Controls.Add(lblContrast);
            Controls.Add(btnBrightnessContrast);
            Controls.Add(trbBrightness);
            Controls.Add(trbContrast);
            Controls.Add(btnVerticleFlip);
            Controls.Add(btnHorizontalFlip);
            Controls.Add(btnFlip);
            Controls.Add(btnRotate);
            Controls.Add(panel2);
            Controls.Add(btnGreyScale);
            Controls.Add(label1);
            Controls.Add(btnSaveImage);
            Controls.Add(btnUploadImage);
            Controls.Add(Header);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Header.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)inputImage).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trbContrast).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbBrightness).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel Header;
        private Panel panel1;
        private Button btnMinimize;
        private Button btnClose;
        private Button btnMaximize;
        private Button btnUploadImage;
        private Button btnSaveImage;
        private PictureBox inputImage;
        private Label label1;
        private Button btnGreyScale;
        private SaveFileDialog saveFileDialog1;
        private Panel panel2;
        private Button btnRotate;
        private Button btnFlip;
        private Button btnHorizontalFlip;
        private Button btnVerticleFlip;
        private TrackBar trbContrast;
        private TrackBar trbBrightness;
        private Button btnBrightnessContrast;
        private Label lblContrast;
        private Label lblBrightness;
        private Button btnDefaultBNC;
        private Button btnReisize;
        private Button btnBlur;
        private TextBox txtbBlur;
        private ComboBox comboBox1;
    }
}
