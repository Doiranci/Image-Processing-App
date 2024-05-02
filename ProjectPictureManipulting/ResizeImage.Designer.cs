
namespace ProjectPictureManipulting
{
    partial class ResizeImage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBoxResize = new PictureBox();
            lblHeight = new Label();
            lblWidth = new Label();
            txtbWidth = new TextBox();
            txtbHeight = new TextBox();
            btnSaveResize = new Button();
            btnDefaultResize = new Button();
            panel2 = new Panel();
            label4 = new Label();
            lblInstagramPost = new Label();
            panel3 = new Panel();
            label5 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel5 = new Panel();
            label7 = new Label();
            label6 = new Label();
            panel6 = new Panel();
            label9 = new Label();
            label8 = new Label();
            panel7 = new Panel();
            label11 = new Label();
            label10 = new Label();
            panel8 = new Panel();
            label13 = new Label();
            label12 = new Label();
            panel9 = new Panel();
            label15 = new Label();
            label14 = new Label();
            panel10 = new Panel();
            label17 = new Label();
            label16 = new Label();
            btnPreviewImage = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResize).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(pictureBoxResize);
            panel1.Location = new Point(7, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 383);
            panel1.TabIndex = 0;
            // 
            // pictureBoxResize
            // 
            pictureBoxResize.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxResize.Location = new Point(22, 23);
            pictureBoxResize.Name = "pictureBoxResize";
            pictureBoxResize.Size = new Size(414, 337);
            pictureBoxResize.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxResize.TabIndex = 0;
            pictureBoxResize.TabStop = false;
            // 
            // lblHeight
            // 
            lblHeight.Anchor = AnchorStyles.Right;
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(487, 165);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(43, 15);
            lblHeight.TabIndex = 3;
            lblHeight.Text = "Height";
            // 
            // lblWidth
            // 
            lblWidth.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(214, 400);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(39, 15);
            lblWidth.TabIndex = 4;
            lblWidth.Text = "Width";
            // 
            // txtbWidth
            // 
            txtbWidth.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtbWidth.Location = new Point(197, 418);
            txtbWidth.Name = "txtbWidth";
            txtbWidth.Size = new Size(75, 23);
            txtbWidth.TabIndex = 5;
            // 
            // txtbHeight
            // 
            txtbHeight.Anchor = AnchorStyles.Right;
            txtbHeight.Location = new Point(473, 183);
            txtbHeight.Name = "txtbHeight";
            txtbHeight.Size = new Size(75, 23);
            txtbHeight.TabIndex = 6;
            // 
            // btnSaveResize
            // 
            btnSaveResize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveResize.Cursor = Cursors.Hand;
            btnSaveResize.Location = new Point(749, 606);
            btnSaveResize.Name = "btnSaveResize";
            btnSaveResize.Size = new Size(92, 36);
            btnSaveResize.TabIndex = 7;
            btnSaveResize.Text = "Save";
            btnSaveResize.UseVisualStyleBackColor = true;
            btnSaveResize.Click += btnSaveResize_Click;
            // 
            // btnDefaultResize
            // 
            btnDefaultResize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDefaultResize.Cursor = Cursors.Hand;
            btnDefaultResize.Location = new Point(7, 409);
            btnDefaultResize.Name = "btnDefaultResize";
            btnDefaultResize.Size = new Size(92, 30);
            btnDefaultResize.TabIndex = 8;
            btnDefaultResize.Text = "Default";
            btnDefaultResize.UseVisualStyleBackColor = true;
            btnDefaultResize.Click += btnDefaultResize_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lblInstagramPost);
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(573, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(91, 88);
            panel2.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 52);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 1;
            label4.Text = "1080 x 1080 px";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInstagramPost
            // 
            lblInstagramPost.AutoSize = true;
            lblInstagramPost.BackColor = SystemColors.AppWorkspace;
            lblInstagramPost.Location = new Point(17, 9);
            lblInstagramPost.Name = "lblInstagramPost";
            lblInstagramPost.Size = new Size(63, 30);
            lblInstagramPost.TabIndex = 0;
            lblInstagramPost.Text = "Instagram \r\nPost";
            lblInstagramPost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.AppWorkspace;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label1);
            panel3.Cursor = Cursors.Hand;
            panel3.Location = new Point(695, 136);
            panel3.Name = "panel3";
            panel3.Size = new Size(146, 88);
            panel3.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 52);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 1;
            label5.Text = "1920 x 1080 px";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 17);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Full HD";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.AppWorkspace;
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Cursor = Cursors.Hand;
            panel4.Location = new Point(573, 136);
            panel4.Name = "panel4";
            panel4.Size = new Size(91, 150);
            panel4.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 94);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 1;
            label3.Text = "1080 x 1920 px";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.AppWorkspace;
            label2.Location = new Point(17, 29);
            label2.Name = "label2";
            label2.Size = new Size(60, 30);
            label2.TabIndex = 0;
            label2.Text = "Instagram\r\nStory";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.AppWorkspace;
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Cursor = Cursors.Hand;
            panel5.Location = new Point(695, 253);
            panel5.Name = "panel5";
            panel5.Size = new Size(147, 88);
            panel5.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 53);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 1;
            label7.Text = "2560 x 1440 px";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 18);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 0;
            label6.Text = "QHD / 2K";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.AppWorkspace;
            panel6.Controls.Add(label9);
            panel6.Controls.Add(label8);
            panel6.Cursor = Cursors.Hand;
            panel6.Location = new Point(695, 371);
            panel6.Name = "panel6";
            panel6.Size = new Size(147, 88);
            panel6.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(34, 53);
            label9.Name = "label9";
            label9.Size = new Size(83, 15);
            label9.TabIndex = 1;
            label9.Text = "3840 x 2160 px";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 15);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 0;
            label8.Text = "Ultra HD / 4K";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.AppWorkspace;
            panel7.Controls.Add(label11);
            panel7.Controls.Add(label10);
            panel7.Cursor = Cursors.Hand;
            panel7.Location = new Point(695, 487);
            panel7.Name = "panel7";
            panel7.Size = new Size(147, 88);
            panel7.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(34, 54);
            label11.Name = "label11";
            label11.Size = new Size(83, 15);
            label11.TabIndex = 1;
            label11.Text = "7680 × 4320 px";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(44, 19);
            label10.Name = "label10";
            label10.Size = new Size(56, 15);
            label10.TabIndex = 0;
            label10.Text = "UHD / 8K";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.AppWorkspace;
            panel8.Controls.Add(label13);
            panel8.Controls.Add(label12);
            panel8.Cursor = Cursors.Hand;
            panel8.Location = new Point(695, 21);
            panel8.Name = "panel8";
            panel8.Size = new Size(146, 88);
            panel8.TabIndex = 18;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(34, 52);
            label13.Name = "label13";
            label13.Size = new Size(77, 15);
            label13.TabIndex = 1;
            label13.Text = "1280 x 720 px";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(60, 17);
            label12.Name = "label12";
            label12.Size = new Size(24, 15);
            label12.TabIndex = 0;
            label12.Text = "HD";
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.AppWorkspace;
            panel9.Controls.Add(label15);
            panel9.Controls.Add(label14);
            panel9.Cursor = Cursors.Hand;
            panel9.Location = new Point(547, 316);
            panel9.Name = "panel9";
            panel9.Size = new Size(117, 85);
            panel9.TabIndex = 19;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Cursor = Cursors.Hand;
            label15.Location = new Point(22, 55);
            label15.Name = "label15";
            label15.Size = new Size(77, 15);
            label15.TabIndex = 1;
            label15.Text = "1200 x 675 px";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Cursor = Cursors.Hand;
            label14.Location = new Point(37, 11);
            label14.Name = "label14";
            label14.Size = new Size(42, 30);
            label14.TabIndex = 0;
            label14.Text = "Twitter\r\n  Post";
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.AppWorkspace;
            panel10.Controls.Add(label17);
            panel10.Controls.Add(label16);
            panel10.Cursor = Cursors.Hand;
            panel10.Location = new Point(547, 427);
            panel10.Name = "panel10";
            panel10.Size = new Size(117, 82);
            panel10.TabIndex = 20;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(20, 57);
            label17.Name = "label17";
            label17.Size = new Size(77, 15);
            label17.TabIndex = 1;
            label17.Text = "1280 x 720 px";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(25, 13);
            label16.Name = "label16";
            label16.Size = new Size(64, 30);
            label16.TabIndex = 0;
            label16.Text = "  YouTube\r\nThumbnail\r\n";
            // 
            // btnPreviewImage
            // 
            btnPreviewImage.Cursor = Cursors.Hand;
            btnPreviewImage.Location = new Point(351, 411);
            btnPreviewImage.Name = "btnPreviewImage";
            btnPreviewImage.Size = new Size(116, 30);
            btnPreviewImage.TabIndex = 22;
            btnPreviewImage.Text = "Preview Image";
            btnPreviewImage.UseVisualStyleBackColor = true;
            btnPreviewImage.Click += btnPreviewImage_Click;
            // 
            // ResizeImage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 654);
            Controls.Add(btnPreviewImage);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnDefaultResize);
            Controls.Add(btnSaveResize);
            Controls.Add(txtbHeight);
            Controls.Add(txtbWidth);
            Controls.Add(lblWidth);
            Controls.Add(lblHeight);
            Controls.Add(panel1);
            Name = "ResizeImage";
            Text = "Resize Image";
            Load += ResizeImage_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxResize).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Panel panel1;
        private PictureBox pictureBoxResize;
        private TrackBar trbWidth;
        private TrackBar trbHeight;
        private Label lblHeight;
        private Label lblWidth;
        private TextBox txtbWidth;
        private TextBox txtbHeight;
        private Button btnSaveResize;
        private Button btnDefaultResize;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label1;
        private Label label2;
        private Label lblInstagramPost;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label6;
        private Label label7;
        private Panel panel6;
        private Panel panel7;
        private Label label9;
        private Label label8;
        private Label label11;
        private Label label10;
        private Panel panel8;
        private Label label13;
        private Label label12;
        private Panel panel9;
        private Label label15;
        private Label label14;
        private Panel panel10;
        private Label label17;
        private Label label16;
        private Button btnPreviewImage;
    }
}