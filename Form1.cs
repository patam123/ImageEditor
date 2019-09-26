using ImageEditorLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ImageModifierForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public ImageEditor imageEditor = new ImageEditor();
        public FileManager fileManager = new FileManager();
        private void NegativeBtn_Click(object sender, EventArgs e)
        {
            pictureBoxEnd.Image = imageEditor.TransformToNegative((Bitmap)pictureBoxOrg.Image);
            pictureBoxEnd.Name = fileManager.GetNewFilePath(openFileDialog.FileName, "negative");
        }

        private void GreyScaleBtn_Click(object sender, EventArgs e)
        {
            pictureBoxEnd.Image = imageEditor.TransformToGreyScale((Bitmap)pictureBoxOrg.Image);
            pictureBoxEnd.Name = fileManager.GetNewFilePath(openFileDialog.FileName, "greyscale");
        }

        private void BlurBtn_Click(object sender, EventArgs e)
        {
            pictureBoxEnd.Image = imageEditor.TransformToBlurred((Bitmap)pictureBoxOrg.Image);
            pictureBoxEnd.Name = fileManager.GetNewFilePath(openFileDialog.FileName, "blurred");
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "JFIF Image|*.jfif|JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog.FileName;
                var image = new Bitmap(filePath);
                pictureBoxOrg.Image = image;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = pictureBoxEnd.Name;
            string extension = Path.GetExtension(openFileDialog.FileName);
            string filter = extension + "|*" + extension;
            saveFileDialog.Filter = filter;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxEnd.Image.Save(saveFileDialog.FileName);
            }
        }
    }
}
