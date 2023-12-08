using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class DisplayImage : Form
    {
        ResultofSearch originalForm;
        public DisplayImage(SearchResult form)
        {
            originalForm = form;
            InitializeComponent();
        }
        public void DisplayImage(string file, string name)
        {
            Bitmap myImg = (Bitmap)Bitmap.FromFile(file);
            label2.Text = name;
            label2.Refresh();
            int hor = myImg.Height;
            int width = myImg.Width;
            Size newS = new Size(width, hor);
            pictureBox1.Size = newS;
            pictureBox1.Image = myImg;
        }
    
        private void DisplayImage_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

    }
}
