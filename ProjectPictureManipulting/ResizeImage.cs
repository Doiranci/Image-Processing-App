using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPictureManipulting
{
    public partial class ResizeImage : Form
    {
        public ResizeImage()
        {
            InitializeComponent();
        }
        private void ResizeImage_Load(object sender, EventArgs e)
        {
           
        }
        private void btnSaveResize_Click(object sender, EventArgs e)
        {

        }

        private void btnDefaultResize_Click(object sender, EventArgs e)
        {

        }
        public void SetImage(Image image)
        {
            pictureBoxResize.Image = image;
        }

    }
}
