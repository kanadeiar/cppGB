using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog()==DialogResult.OK)
                pictureBoxImg.Image=new Bitmap(openFileDialog.FileName);
        }

        private void checkBoxWindow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWindow.Checked)
                pictureBoxImg.SizeMode=PictureBoxSizeMode.Zoom;
            else
                pictureBoxImg.SizeMode=PictureBoxSizeMode.Normal;
        }
    }
}
