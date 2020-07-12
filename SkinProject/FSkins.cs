using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkinProject
{
    public partial class FSkins : Form
    {
        public FSkins()
        {
            InitializeComponent();
        }

        public static List<MyBitmap> skins = new List<MyBitmap>();
        public static int counter = 0;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FSkins_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            foreach (MyBitmap mBmp in Form1.imagesToFix.Keys)
                skins.Add(mBmp);
            pictureBox1.Image = skins[0].bmp;
            label1.Text = skins[0].name;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (++counter > skins.Count - 1)
                counter = 0;
            pictureBox1.Image = skins[counter].bmp;
            label1.Text = skins[counter].name;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (--counter < 0)
                counter = skins.Count - 1;
            pictureBox1.Image = skins[counter].bmp;
            label1.Text = skins[counter].name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
