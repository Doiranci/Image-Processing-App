﻿namespace ProjectPictureManipulting
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Header = new Panel();
            panel1 = new Panel();
            btnClose = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            btnUploadImage = new Button();
            btnSaveImage = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            btnGreyScale = new Button();
            saveFileDialog1 = new SaveFileDialog();
            panel2 = new Panel();
            Header.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
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
            btnUploadImage.Location = new Point(310, 43);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(139, 32);
            btnUploadImage.TabIndex = 3;
            btnUploadImage.Text = "Upload Image";
            btnUploadImage.UseVisualStyleBackColor = true;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // btnSaveImage
            // 
            btnSaveImage.Location = new Point(455, 45);
            btnSaveImage.Name = "btnSaveImage";
            btnSaveImage.Size = new Size(63, 29);
            btnSaveImage.TabIndex = 4;
            btnSaveImage.Text = "Save";
            btnSaveImage.UseVisualStyleBackColor = true;
            btnSaveImage.Click += btnSaveImage_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(13, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(412, 275);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(9, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 23);
            textBox1.TabIndex = 6;
            textBox1.Text = " ";
            textBox1.Visible = false;
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
            btnGreyScale.Location = new Point(524, 43);
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
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(12, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(437, 299);
            panel2.TabIndex = 9;
            panel2.Paint += panel2_Paint;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(btnGreyScale);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(btnSaveImage);
            Controls.Add(btnUploadImage);
            Controls.Add(Header);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Header.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
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
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label1;
        private Button btnGreyScale;
        private SaveFileDialog saveFileDialog1;
        private Panel panel2;
    }
}
