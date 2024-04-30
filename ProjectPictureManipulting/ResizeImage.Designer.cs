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
            trbWidth = new TrackBar();
            trbHeight = new TrackBar();
            lblHeight = new Label();
            Width = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnSaveResize = new Button();
            btnDefaultResize = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbHeight).BeginInit();
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
            panel1.Size = new Size(675, 346);
            panel1.TabIndex = 0;
            // 
            // pictureBoxResize
            // 
            pictureBoxResize.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxResize.Location = new Point(124, 63);
            pictureBoxResize.Name = "pictureBoxResize";
            pictureBoxResize.Size = new Size(420, 217);
            pictureBoxResize.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxResize.TabIndex = 0;
            pictureBoxResize.TabStop = false;
            // 
            // trbWidth
            // 
            trbWidth.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            trbWidth.Location = new Point(12, 357);
            trbWidth.Maximum = 200;
            trbWidth.Minimum = 1;
            trbWidth.Name = "trbWidth";
            trbWidth.Size = new Size(355, 45);
            trbWidth.TabIndex = 1;
            trbWidth.Value = 100;
            trbWidth.Scroll += trbWidth_Scroll;
            // 
            // trbHeight
            // 
            trbHeight.Anchor = AnchorStyles.Right;
            trbHeight.Location = new Point(684, 12);
            trbHeight.Maximum = 200;
            trbHeight.Minimum = 1;
            trbHeight.Name = "trbHeight";
            trbHeight.Orientation = Orientation.Vertical;
            trbHeight.Size = new Size(45, 291);
            trbHeight.TabIndex = 2;
            trbHeight.Value = 100;
            trbHeight.Scroll += trbHeight_Scroll;
            // 
            // lblHeight
            // 
            lblHeight.Anchor = AnchorStyles.Right;
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(735, 139);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(43, 15);
            lblHeight.TabIndex = 3;
            lblHeight.Text = "Height";
            // 
            // Width
            // 
            Width.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Width.AutoSize = true;
            Width.Location = new Point(163, 405);
            Width.Name = "Width";
            Width.Size = new Size(39, 15);
            Width.TabIndex = 4;
            Width.Text = "Width";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox1.Location = new Point(146, 423);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(75, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Right;
            textBox2.Location = new Point(719, 157);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(75, 23);
            textBox2.TabIndex = 6;
            // 
            // btnSaveResize
            // 
            btnSaveResize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveResize.Location = new Point(598, 402);
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
            btnDefaultResize.Location = new Point(696, 402);
            btnDefaultResize.Name = "btnDefaultResize";
            btnDefaultResize.Size = new Size(92, 36);
            btnDefaultResize.TabIndex = 8;
            btnDefaultResize.Text = "Default";
            btnDefaultResize.UseVisualStyleBackColor = true;
            btnDefaultResize.Click += btnDefaultResize_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(624, 387);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 9;
            label1.Text = "label1";
            // 
            // ResizeImage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnDefaultResize);
            Controls.Add(btnSaveResize);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Width);
            Controls.Add(lblHeight);
            Controls.Add(trbHeight);
            Controls.Add(trbWidth);
            Controls.Add(panel1);
            Name = "ResizeImage";
            Text = "Resize Image";
            Load += ResizeImage_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxResize).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbHeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxResize;
        private TrackBar trbWidth;
        private TrackBar trbHeight;
        private Label lblHeight;
        private Label Width;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnSaveResize;
        private Button btnDefaultResize;
        private Label label1;
    }
}