using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abharanam_App
{
    public partial class frmImagePopup : Form
    {
        private List<string> imagePaths;
        private int currentIndex = 0;

        public frmImagePopup()
        {
            InitializeComponent();
        }

        public frmImagePopup(List<string> paths, int initialIndex)
        {
            InitializeComponent();
            imagePaths = paths;
            currentIndex = initialIndex;
            DisplayImage();
        }

        private void DisplayImage()
        {
            if (currentIndex >= 0 && currentIndex < imagePaths.Count)
            {
                pictureBoxPopup.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxPopup.Image = Image.FromFile(imagePaths[currentIndex]);
            }
        }




        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentIndex = Math.Max(0, currentIndex - 1);
            DisplayImage();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentIndex = Math.Min(imagePaths.Count - 1, currentIndex + 1);
            DisplayImage();
        }

        public int CurrentIndex { get; set; }

    }


}
