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
            pictureBox1 = new PictureBox();
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
            btnFilter = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            label11 = new Label();
            Header.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inputImage).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbContrast).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbBrightness).BeginInit();
            SuspendLayout();
            // 
            // Header
            // 
            Header.BackColor = Color.FromArgb(11, 130, 187);
            Header.Controls.Add(panel1);
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(1238, 37);
            Header.TabIndex = 2;
            Header.MouseDown += OnMouseDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(10, 130, 190);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnMaximize);
            panel1.Controls.Add(btnMinimize);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1102, 0);
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
            btnClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
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
            btnMaximize.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMaximize.FlatAppearance.MouseOverBackColor = Color.Transparent;
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
            btnMinimize.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.Transparent;
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
            btnUploadImage.FlatAppearance.BorderSize = 0;
            btnUploadImage.FlatStyle = FlatStyle.Flat;
            btnUploadImage.Image = (Image)resources.GetObject("btnUploadImage.Image");
            btnUploadImage.Location = new Point(12, 44);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(61, 46);
            btnUploadImage.TabIndex = 3;
            btnUploadImage.UseVisualStyleBackColor = true;
            btnUploadImage.Click += btnUploadImage_Click;
            btnUploadImage.MouseLeave += btnUploadImage_MouseLeave;
            btnUploadImage.MouseHover += btnUploadImage_MouseHover;
            // 
            // btnSaveImage
            // 
            btnSaveImage.FlatAppearance.BorderSize = 0;
            btnSaveImage.FlatStyle = FlatStyle.Flat;
            btnSaveImage.Image = (Image)resources.GetObject("btnSaveImage.Image");
            btnSaveImage.Location = new Point(80, 44);
            btnSaveImage.Name = "btnSaveImage";
            btnSaveImage.Size = new Size(59, 46);
            btnSaveImage.TabIndex = 4;
            btnSaveImage.UseVisualStyleBackColor = true;
            btnSaveImage.Click += btnSaveImage_Click;
            btnSaveImage.MouseLeave += btnSaveImage_MouseLeave;
            btnSaveImage.MouseHover += btnSaveImage_MouseHover;
            // 
            // inputImage
            // 
            inputImage.AllowDrop = true;
            inputImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputImage.Location = new Point(0, -3);
            inputImage.Name = "inputImage";
            inputImage.Size = new Size(891, 517);
            inputImage.SizeMode = PictureBoxSizeMode.StretchImage;
            inputImage.TabIndex = 5;
            inputImage.TabStop = false;
            inputImage.DragDrop += inputImage_DragDrop;
            inputImage.DragEnter += inputImage_DragEnter;
            inputImage.Paint += pictureBox1_Paint;
            inputImage.MouseDown += pictureBox1_MouseDown;
            inputImage.MouseMove += pictureBox1_MouseMove;
            inputImage.MouseUp += pictureBox1_MouseUp;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(10, 427);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 7;
            // 
            // btnGreyScale
            // 
            btnGreyScale.FlatAppearance.BorderSize = 0;
            btnGreyScale.FlatStyle = FlatStyle.Flat;
            btnGreyScale.Image = (Image)resources.GetObject("btnGreyScale.Image");
            btnGreyScale.ImageAlign = ContentAlignment.BottomCenter;
            btnGreyScale.Location = new Point(12, 525);
            btnGreyScale.Name = "btnGreyScale";
            btnGreyScale.Size = new Size(60, 53);
            btnGreyScale.TabIndex = 8;
            btnGreyScale.UseVisualStyleBackColor = true;
            btnGreyScale.Click += btnGreyScale_Click;
            btnGreyScale.MouseLeave += btnGreyScale_MouseLeave;
            btnGreyScale.MouseHover += btnGreyScale_MouseHover;
            // 
            // panel2
            // 
            panel2.AllowDrop = true;
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ButtonShadow;
            panel2.Controls.Add(inputImage);
            panel2.Location = new Point(347, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(890, 514);
            panel2.TabIndex = 9;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1033, 463);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // btnRotate
            // 
            btnRotate.FlatAppearance.BorderSize = 0;
            btnRotate.FlatStyle = FlatStyle.Flat;
            btnRotate.Image = (Image)resources.GetObject("btnRotate.Image");
            btnRotate.Location = new Point(11, 317);
            btnRotate.Name = "btnRotate";
            btnRotate.Size = new Size(61, 53);
            btnRotate.TabIndex = 10;
            btnRotate.UseVisualStyleBackColor = true;
            btnRotate.Click += btnRotate_Click;
            btnRotate.MouseLeave += btnRotate_MouseLeave;
            btnRotate.MouseHover += btnRotate_MouseHover;
            // 
            // btnFlip
            // 
            btnFlip.BackColor = Color.FromArgb(52, 52, 52);
            btnFlip.FlatAppearance.BorderSize = 0;
            btnFlip.FlatStyle = FlatStyle.Flat;
            btnFlip.Image = (Image)resources.GetObject("btnFlip.Image");
            btnFlip.Location = new Point(12, 249);
            btnFlip.Name = "btnFlip";
            btnFlip.Size = new Size(60, 53);
            btnFlip.TabIndex = 11;
            btnFlip.UseVisualStyleBackColor = false;
            btnFlip.Click += btnFlip_Click;
            btnFlip.MouseLeave += btnFlip_MouseLeave;
            btnFlip.MouseHover += btnFlip_MouseHover;
            // 
            // btnHorizontalFlip
            // 
            btnHorizontalFlip.FlatStyle = FlatStyle.Flat;
            btnHorizontalFlip.ForeColor = SystemColors.ControlLight;
            btnHorizontalFlip.Location = new Point(102, 264);
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
            btnVerticleFlip.FlatStyle = FlatStyle.Flat;
            btnVerticleFlip.ForeColor = SystemColors.ControlLight;
            btnVerticleFlip.Location = new Point(187, 264);
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
            trbContrast.Location = new Point(214, 386);
            trbContrast.Maximum = 200;
            trbContrast.Name = "trbContrast";
            trbContrast.Size = new Size(133, 45);
            trbContrast.TabIndex = 14;
            trbContrast.Value = 100;
            trbContrast.Visible = false;
            trbContrast.Scroll += Slider_Scroll;
            // 
            // trbBrightness
            // 
            trbBrightness.Location = new Point(78, 386);
            trbBrightness.Maximum = 100;
            trbBrightness.Minimum = -100;
            trbBrightness.Name = "trbBrightness";
            trbBrightness.Size = new Size(133, 45);
            trbBrightness.TabIndex = 15;
            trbBrightness.Visible = false;
            trbBrightness.Scroll += Slider_Scroll;
            // 
            // btnBrightnessContrast
            // 
            btnBrightnessContrast.FlatAppearance.BorderSize = 0;
            btnBrightnessContrast.FlatStyle = FlatStyle.Flat;
            btnBrightnessContrast.Image = (Image)resources.GetObject("btnBrightnessContrast.Image");
            btnBrightnessContrast.Location = new Point(12, 386);
            btnBrightnessContrast.Name = "btnBrightnessContrast";
            btnBrightnessContrast.Size = new Size(60, 53);
            btnBrightnessContrast.TabIndex = 16;
            btnBrightnessContrast.UseVisualStyleBackColor = true;
            btnBrightnessContrast.Click += btnBrightnessContrast_Click;
            btnBrightnessContrast.MouseLeave += btnBrightnessContrast_MouseLeave;
            btnBrightnessContrast.MouseHover += btnBrightnessContrast_MouseHover;
            // 
            // lblContrast
            // 
            lblContrast.AutoSize = true;
            lblContrast.Location = new Point(257, 367);
            lblContrast.Name = "lblContrast";
            lblContrast.Size = new Size(52, 15);
            lblContrast.TabIndex = 17;
            lblContrast.Text = "Contrast";
            lblContrast.Visible = false;
            // 
            // lblBrightness
            // 
            lblBrightness.AutoSize = true;
            lblBrightness.Location = new Point(119, 416);
            lblBrightness.Name = "lblBrightness";
            lblBrightness.Size = new Size(62, 15);
            lblBrightness.TabIndex = 18;
            lblBrightness.Text = "Brightness";
            lblBrightness.Visible = false;
            // 
            // btnDefaultBNC
            // 
            btnDefaultBNC.FlatStyle = FlatStyle.Flat;
            btnDefaultBNC.ForeColor = SystemColors.ControlLight;
            btnDefaultBNC.Location = new Point(178, 437);
            btnDefaultBNC.Name = "btnDefaultBNC";
            btnDefaultBNC.Size = new Size(60, 24);
            btnDefaultBNC.TabIndex = 19;
            btnDefaultBNC.Text = "Default";
            btnDefaultBNC.UseVisualStyleBackColor = true;
            btnDefaultBNC.Visible = false;
            btnDefaultBNC.Click += btnDefaultBNC_Click;
            // 
            // btnReisize
            // 
            btnReisize.FlatAppearance.BorderSize = 0;
            btnReisize.FlatStyle = FlatStyle.Flat;
            btnReisize.Image = (Image)resources.GetObject("btnReisize.Image");
            btnReisize.Location = new Point(12, 455);
            btnReisize.Name = "btnReisize";
            btnReisize.Size = new Size(60, 53);
            btnReisize.TabIndex = 20;
            btnReisize.UseVisualStyleBackColor = true;
            btnReisize.Click += btnReisize_Click;
            btnReisize.MouseLeave += btnReisize_MouseLeave;
            btnReisize.MouseHover += btnReisize_MouseHover;
            // 
            // btnBlur
            // 
            btnBlur.FlatAppearance.BorderSize = 0;
            btnBlur.FlatStyle = FlatStyle.Flat;
            btnBlur.Image = (Image)resources.GetObject("btnBlur.Image");
            btnBlur.Location = new Point(12, 591);
            btnBlur.Name = "btnBlur";
            btnBlur.Size = new Size(60, 55);
            btnBlur.TabIndex = 21;
            btnBlur.UseVisualStyleBackColor = true;
            btnBlur.Click += btnBlur_Click;
            btnBlur.MouseLeave += btnBlur_MouseLeave;
            btnBlur.MouseHover += btnBlur_MouseHover;
            // 
            // txtbBlur
            // 
            txtbBlur.BackColor = Color.FromArgb(52, 52, 52);
            txtbBlur.BorderStyle = BorderStyle.FixedSingle;
            txtbBlur.ForeColor = SystemColors.ControlLight;
            txtbBlur.Location = new Point(89, 609);
            txtbBlur.Name = "txtbBlur";
            txtbBlur.Size = new Size(74, 23);
            txtbBlur.TabIndex = 22;
            txtbBlur.Text = "Blur: 1-20";
            txtbBlur.TextAlign = HorizontalAlignment.Center;
            txtbBlur.Visible = false;
            txtbBlur.TextChanged += txtbBlur_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "AquaBlue", "Coral", "DarkViolet", "Default" });
            comboBox1.Location = new Point(89, 678);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(129, 23);
            comboBox1.TabIndex = 23;
            comboBox1.Visible = false;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnFilter
            // 
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Image = (Image)resources.GetObject("btnFilter.Image");
            btnFilter.Location = new Point(12, 662);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(59, 53);
            btnFilter.TabIndex = 24;
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += filterBtn_Click;
            btnFilter.MouseLeave += btnFilter_MouseLeave;
            btnFilter.MouseHover += btnFilter_MouseHover;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DimGray;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(78, 271);
            label2.Name = "label2";
            label2.Size = new Size(197, 17);
            label2.TabIndex = 25;
            label2.Text = "(Flip) image to horizontal or vertical";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DimGray;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(23, 98);
            label3.Name = "label3";
            label3.Size = new Size(138, 17);
            label3.TabIndex = 26;
            label3.Text = "(Upload) image from PC";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DimGray;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(93, 96);
            label4.Name = "label4";
            label4.Size = new Size(109, 17);
            label4.TabIndex = 27;
            label4.Text = "(Save) image to PC";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DimGray;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(78, 336);
            label5.Name = "label5";
            label5.Size = new Size(162, 17);
            label5.TabIndex = 28;
            label5.Text = "(Rotate) image by 90 degrees";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DimGray;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Location = new Point(78, 405);
            label6.Name = "label6";
            label6.Size = new Size(158, 17);
            label6.TabIndex = 29;
            label6.Text = "(Brightness & Contrast) adjust\r\n";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DimGray;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Location = new Point(78, 474);
            label7.Name = "label7";
            label7.Size = new Size(174, 17);
            label7.TabIndex = 30;
            label7.Text = "(Resize) image to different sizes";
            label7.Visible = false;
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DimGray;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Location = new Point(78, 544);
            label8.Name = "label8";
            label8.Size = new Size(152, 17);
            label8.TabIndex = 31;
            label8.Text = "(Grey scale) convert image ";
            label8.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.DimGray;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Location = new Point(78, 611);
            label9.Name = "label9";
            label9.Size = new Size(74, 17);
            label9.TabIndex = 32;
            label9.Text = "(Blur) image";
            label9.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.DimGray;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Location = new Point(78, 681);
            label10.Name = "label10";
            label10.Size = new Size(102, 17);
            label10.TabIndex = 33;
            label10.Text = "(Filters) for image";
            label10.Visible = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(148, 44);
            button1.Name = "button1";
            button1.Size = new Size(54, 49);
            button1.TabIndex = 34;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseLeave += button1_MouseLeave_1;
            button1.MouseHover += button1_MouseHover_1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.DimGray;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Location = new Point(156, 96);
            label11.Name = "label11";
            label11.Size = new Size(176, 17);
            label11.TabIndex = 35;
            label11.Text = "(Default) - sets image to default";
            label11.Visible = false;
            // 
            // Main
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(52, 52, 52);
            ClientSize = new Size(1238, 639);
            Controls.Add(pictureBox1);
            Controls.Add(label11);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnFilter);
            Controls.Add(comboBox1);
            Controls.Add(btnUploadImage);
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
            Controls.Add(Header);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(800, 450);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Main_Load;
            Header.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)inputImage).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button btnFilter;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
        private Label label11;
        private PictureBox pictureBox1;
    }
}
