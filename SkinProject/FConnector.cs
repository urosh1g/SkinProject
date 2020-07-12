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
    public partial class FConnector : Form
    {
        public FConnector()
        {
            InitializeComponent();
        }

        public static bool result = false;

        private void FConnector_Load(object sender, EventArgs e)
        {
            label1.Text = string.Format("{0} skins need repairing!", Form1.imagesToFix.Keys.Count);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FSkins f = new FSkins(); f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
