
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Project
{
    public partial class Form1 : Form
    {
        string queryFileName;
        SearchResults resultForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            openFileDialog1.Filter = "JPEG Files|*.jpg";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            {
                
                queryFileName = openFileDialog1.FileName;
                Bitmap myImg = (Bitmap)Bitmap.FromFile(queryFileName);
                
                int hor = myImg.Height;
                int width = myImg.Width;
                Size newS = new Size(width, hor);
                queryPicture.Size = newS;
                
                Point newP = new Point(queryPicture.Location.X + width + 15, button1.Location.Y);
                
                queryPicture.Image = myImg;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            if (queryPicture.Image != null)
            {
                FileInfo newFile = new FileInfo(queryFileName);
                string path = newFile.DirectoryName;
                resultForm = new ResultofSearch(this);
                resultForm.doSearch(queryFileName, path, true, false, false);
                resultForm.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (queryPicture.Image != null)
            {
                FileInfo newFile = new FileInfo(queryFileName);
                string path = newFile.DirectoryName;
                resultForm = new ResultofSearch(this);
                resultForm.doSearch(queryFileName, path, false, true, false);
                resultForm.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (queryPicture.Image != null)
            {
                FileInfo newFile = new FileInfo(queryFileName);
                string path = newFile.DirectoryName;
                resultForm = new ResultofSearch(this);
                resultForm.doSearch(queryFileName, path, false, false, true);
                resultForm.Show();
                this.Hide();
            }
        }
    }




}


