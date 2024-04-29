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
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            lblHeight = new Label();
            Width = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnSaveResize = new Button();
            btnDefaultResize = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(pictureBoxResize);
            panel1.Location = new Point(15, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 302);
            panel1.TabIndex = 0;
            // 
            // pictureBoxResize
            // 
            pictureBoxResize.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxResize.Location = new Point(5, 6);
            pictureBoxResize.Name = "pictureBoxResize";
            pictureBoxResize.Size = new Size(355, 291);
            pictureBoxResize.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxResize.TabIndex = 0;
            pictureBoxResize.TabStop = false;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(20, 324);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(355, 45);
            trackBar1.TabIndex = 1;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(401, 18);
            trackBar2.Name = "trackBar2";
            trackBar2.Orientation = Orientation.Vertical;
            trackBar2.Size = new Size(45, 291);
            trackBar2.TabIndex = 2;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(452, 145);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(43, 15);
            lblHeight.TabIndex = 3;
            lblHeight.Text = "Height";
            // 
            // Width
            // 
            Width.AutoSize = true;
            Width.Location = new Point(171, 372);
            Width.Name = "Width";
            Width.Size = new Size(39, 15);
            Width.TabIndex = 4;
            Width.Text = "Width";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 390);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(75, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(436, 163);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(75, 23);
            textBox2.TabIndex = 6;
            // 
            // btnSaveResize
            // 
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
            btnDefaultResize.Location = new Point(696, 402);
            btnDefaultResize.Name = "btnDefaultResize";
            btnDefaultResize.Size = new Size(92, 36);
            btnDefaultResize.TabIndex = 8;
            btnDefaultResize.Text = "Default";
            btnDefaultResize.UseVisualStyleBackColor = true;
            btnDefaultResize.Click += btnDefaultResize_Click;
            // 
            // ResizeImage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDefaultResize);
            Controls.Add(btnSaveResize);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Width);
            Controls.Add(lblHeight);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(panel1);
            Name = "ResizeImage";
            Text = "Resize Image";
            Load += ResizeImage_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxResize).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxResize;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private Label lblHeight;
        private Label Width;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnSaveResize;
        private Button btnDefaultResize;
    }
}