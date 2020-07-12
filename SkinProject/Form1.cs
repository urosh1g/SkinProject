using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkinProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Variables
        public static int imgnum = 0;
        public static List<MyBitmap> skin = new List<MyBitmap>();
        public static List<Pixel> pixelsToFix = new List<Pixel>();
        public static Dictionary<MyBitmap, List<Pixel>> imagesToFix = new Dictionary<MyBitmap, List<Pixel>>();
        #endregion

        #region Functions
        public static byte ExtractAlpha(int i, int j)
        {
            return skin[imgnum].bmp.GetPixel(j, i).A;
        }

        public static void CheckPixel(int i, int j, BodyPart bp)
        {
            byte alpha = ExtractAlpha(i, j);
            if (alpha < 255 && alpha > 0)
            {
                pixelsToFix.Add(new Pixel(i, j, skin[imgnum].bmp.GetPixel(j, i), bp));
            }
        }
        #endregion

        #region Events

        private void btnLoadSkin_Click(object sender, EventArgs e)
        {
            #region Skin loading
            openFileDialog1.Filter = "Images|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                {
                    Bitmap bmp = (Bitmap)Image.FromFile(openFileDialog1.FileNames[i]);
                    if (bmp.Width > 128 || bmp.Height > 128)
                    {
                        MessageBox.Show("All images must be 128x128 pixels!");
                        return;
                    }
                    skin.Add(new MyBitmap(bmp, openFileDialog1.FileNames[i]));
                }
            }
            else
            {
                MessageBox.Show(null, "No image selected!", "Error", MessageBoxButtons.OK);
                return;
            }
            #endregion

            this.Icon = Properties.Resources.brick_wall_pixel_icon_123659;
            btnTestPixels.Enabled = true;
        }

        private void btnTestPixels_Click(object sender, EventArgs e)
        {
            btnFixPixels.Enabled = true;


            // Test each image for translucent pixels in different parts of the scheme
            for (imgnum = 0; imgnum < openFileDialog1.FileNames.Length; imgnum++)
            {

                pixelsToFix = new List<Pixel>();

                #region PART 1 
                for (int i = 0; i <= 15; i++)
                {
                    for (int j = 0; j <= 127; j++)
                    {
                        #region TOP OF HEAD
                        if (j > 15 && j < 32)
                        {
                            CheckPixel(i, j, BodyPart.TopHead);
                        }
                        #endregion

                        #region BOTTOM HEAD
                        else if (j > 31 && j < 48)
                        {
                            CheckPixel(i, j, BodyPart.BottomHead);
                        }
                        #endregion

                        #region TOP HELMET
                        else if (j > 79 && j < 96)
                        {
                            CheckPixel(i, j, BodyPart.TopHelmet);
                        }
                        #endregion

                        #region BOTTOM HELMET
                        else if (j > 95 && j < 112)
                        {
                            CheckPixel(i, j, BodyPart.BottomHelmet);
                        }
                        #endregion
                        #region SHOULD BE TRANSPARENT
                        else
                        {
                            skin[imgnum].bmp.SetPixel(j, i, Color.Transparent);
                        }
                        #endregion
                    }
                }
                #endregion

                #region PART 2
                for (int i = 16; i <= 31; i++)
                {
                    for (int j = 0; j <= 127; j++)
                    {
                        #region RIGHT HEAD
                        if (j >= 0 && j < 16)
                        {
                            CheckPixel(i, j, BodyPart.RHead);
                        }
                        #endregion

                        #region FACE
                        else if (j > 15 && j < 32)
                        {
                            CheckPixel(i, j, BodyPart.Face);
                        }
                        #endregion

                        #region LEFT HEAD
                        else if (j > 31 && j < 48)
                        {
                            CheckPixel(i, j, BodyPart.LHead);
                        }
                        #endregion

                        #region BACK HEAD
                        else if (j > 47 && j < 64)
                        {
                            CheckPixel(i, j, BodyPart.BHead);
                        }
                        #endregion

                        #region RIGHT HELMET
                        else if (j > 63 && j < 80)
                        {
                            CheckPixel(i, j, BodyPart.RHelmet);
                        }
                        #endregion

                        #region FRONT HELMET
                        else if (j > 79 && j < 96)
                        {
                            CheckPixel(i, j, BodyPart.FHelmet);
                        }
                        #endregion

                        #region LEFT HELMET
                        else if (j > 95 && j < 112)
                            CheckPixel(i, j, BodyPart.LHelmet);
                        #endregion

                        #region BACK HELMET
                        else if (j > 111 && j < 128)
                            CheckPixel(i, j, BodyPart.BHelmet);
                        #endregion

                        #region SHOULD BE TRANSPARENT
                        else skin[imgnum].bmp.SetPixel(j, i, Color.Transparent);
                        #endregion
                    }
                }
                #endregion

                #region PART 3
                for (int i = 32; i <= 39; i++)
                {
                    for (int j = 0; j <= 127; j++)
                    {

                        #region TOP RIGHT LEG
                        if (j > 7 && j < 16)
                            CheckPixel(i, j, BodyPart.RLeg_Top);
                        #endregion

                        #region RIGHT LEG FOOT
                        else if (j > 15 && j < 24)
                            CheckPixel(i, j, BodyPart.RLeg_Foot);
                        #endregion

                        #region TOP FRONT TORSO
                        else if (j > 39 && j < 56)
                            CheckPixel(i, j, BodyPart.TopTorso);
                        #endregion

                        #region BOTTOM FRONT TORSO
                        else if (j > 55 && j < 72)
                            CheckPixel(i, j, BodyPart.BottomTorso);
                        #endregion

                        #region TOP RIGHT ARM
                        else if (j > 87 && j < 96)
                            CheckPixel(i, j, BodyPart.RArm_Top);
                        #endregion

                        #region HAND
                        else if (j > 95 && j < 104)
                            CheckPixel(i, j, BodyPart.RArm_Hand);
                        #endregion

                        #region SHOULD BE TRANSPARENT
                        else skin[imgnum].bmp.SetPixel(j, i, Color.Transparent);
                        #endregion
                    }
                }
                #endregion

                #region PART 4
                for (int i = 40; i <= 63; i++)
                {
                    for (int j = 0; j <= 127; j++)
                    {

                        #region RIGHT LEG OUT
                        if (j >= 0 && j < 8)
                            CheckPixel(i, j, BodyPart.RLeg_Out);
                        #endregion

                        #region RIGHT LEG FRONT
                        else if (j > 7 && j < 16)
                            CheckPixel(i, j, BodyPart.RLeg_Front);
                        #endregion

                        #region RIGHT LEG INSIDE
                        else if (j > 15 && j < 24)
                            CheckPixel(i, j, BodyPart.RLeg_In);
                        #endregion

                        #region RIGHT LEG BACK
                        else if (j > 23 && j < 32)
                            CheckPixel(i, j, BodyPart.RLeg_Back);
                        #endregion

                        #region TORSO RIGHT
                        else if (j > 31 && j < 40)
                            CheckPixel(i, j, BodyPart.RTorso);
                        #endregion

                        #region TORSO FRONT
                        else if (j > 39 && j < 56)
                            CheckPixel(i, j, BodyPart.Torso);
                        #endregion

                        #region TORSO LEFT
                        else if (j > 55 && j < 64)
                            CheckPixel(i, j, BodyPart.LTorso);
                        #endregion

                        #region TORSO BACK
                        else if (j > 63 && j < 80)
                            CheckPixel(i, j, BodyPart.BTorso);
                        #endregion

                        #region RIGHT ARM OUT
                        else if (j > 79 && j < 88)
                            CheckPixel(i, j, BodyPart.RArm_Out);
                        #endregion

                        #region RIGHT ARM FRONT
                        else if (j > 87 && j < 96)
                            CheckPixel(i, j, BodyPart.RArm_Front);
                        #endregion

                        #region RIGHT ARM INSIDE
                        else if (j > 95 && j < 104)
                            CheckPixel(i, j, BodyPart.RArm_In);

                        #endregion

                        #region RIGHT ARM BACK
                        else if (j > 103 && j < 112)
                            CheckPixel(i, j, BodyPart.RArm_Back);
                        #endregion

                        #region SHOULD BE TRANSPARENT
                        else skin[imgnum].bmp.SetPixel(j, i, Color.Transparent);
                        #endregion

                    }
                }
                #endregion

                #region PART 5
                for (int i = 64; i <= 71; i++)
                {
                    for (int j = 0; j <= 127; j++)
                    {

                        #region SECOND LAYER RIGHT LEG
                        if (j > 7 && j < 24)
                            CheckPixel(i, j, BodyPart.RLeg_SecondLayer);
                        #endregion

                        #region SECOND LAYER TORSO
                        else if (j > 39 && j < 72)
                            CheckPixel(i, j, BodyPart.Torso_SecondLayer);
                        #endregion

                        #region SECOND LAYER RIGHT ARM
                        else if (j > 87 && j < 104)
                            CheckPixel(i, j, BodyPart.RArm_SecondLayer);
                        #endregion

                        else skin[imgnum].bmp.SetPixel(j, i, Color.Transparent);

                    }
                }
                for (int i = 72; i <= 95; i++)
                {
                    for (int j = 0; j <= 127; j++)
                    {

                        #region SECOND LAYER RIGHT LEG
                        if (j >= 0 && j < 32)
                            CheckPixel(i, j, BodyPart.RLeg_SecondLayer);

                        #endregion

                        #region SECOND LAYER TORSO
                        else if (j > 31 && j < 80)
                            CheckPixel(i, j, BodyPart.Torso_SecondLayer);
                        #endregion

                        #region SECOND LAYER RIGHT ARM
                        else if (j > 79 && j < 112)
                            CheckPixel(i, j, BodyPart.RArm_SecondLayer);
                        #endregion
                        else skin[imgnum].bmp.SetPixel(j, i, Color.Transparent);
                    }
                }
                #endregion

                #region PART 6
                for (int i = 96; i <= 103; i++)
                {
                    for (int j = 0; j <= 127; j++)
                    {
                        #region SECOND LAYER LEFT LEG
                        if (j > 7 && j < 24)
                            CheckPixel(i, j, BodyPart.RLeg_SecondLayer);
                        #endregion

                        #region LEFT LEG
                        else if (j > 39 && j < 56)
                            CheckPixel(i, j, BodyPart.LLeg_SecondLayer);
                        #endregion

                        #region LEFT ARM
                        else if (j > 71 && j < 88)
                            CheckPixel(i, j, BodyPart.LArm);
                        #endregion

                        #region SECOLD LAYER LEFT ARM
                        else if (j > 103 && j < 120)
                            CheckPixel(i, j, BodyPart.LArm_SecondLayer);
                        #endregion

                        else skin[imgnum].bmp.SetPixel(j, i, Color.Transparent);

                    }
                }
                for (int i = 104; i <= 127; i++)
                {
                    for (int j = 0; j <= 127; j++)
                    {

                        #region SECOND LAYER LEFT LEG
                        if (j >= 0 && j < 32)
                            CheckPixel(i, j, BodyPart.LLeg_SecondLayer);
                        #endregion

                        #region LEFT LEG
                        else if (j > 31 && j < 65)
                            CheckPixel(i, j, BodyPart.LLeg);
                        #endregion

                        #region LEFT ARM
                        else if (j > 64 && j < 96)
                            CheckPixel(i, j, BodyPart.LArm);
                        #endregion

                        #region SECOND LAYER LEFT ARM
                        else if (j > 95 && j < 128)
                            CheckPixel(i, j, BodyPart.LArm_SecondLayer);
                        #endregion

                        else skin[imgnum].bmp.SetPixel(j, i, Color.Transparent);

                    }
                }
                #endregion

                if (pixelsToFix.Count != 0)
                {
                    imagesToFix.Add(skin[imgnum], pixelsToFix);
                }

            }
            if (imagesToFix.Keys.Count != 0)
            {
                FConnector f = new FConnector(); f.ShowDialog();
            }
            else MessageBox.Show("No skins need to be repaired!");
        }

        private void button1_Click(object sender, EventArgs e) // btnExit
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) // btnFixPixels
        {
            #region FIX PIXELS
            foreach (MyBitmap s in imagesToFix.Keys)
                foreach (Pixel p in imagesToFix[s])
                {
                    Color newColor = Color.FromArgb(255, p.color.R, p.color.G, p.color.B);
                    s.bmp.SetPixel(p.J, p.I, newColor);
                }
            #endregion

            #region SAVE IMAGE(S)
            if (DialogResult.Yes == MessageBox.Show("Save the new image(s)?", "SAVE", MessageBoxButtons.YesNo))
            {
                //Create a new directory for all edited images
                Directory.CreateDirectory(Path.GetDirectoryName(openFileDialog1.FileNames[0]) + "\\EDITED_IMAGES\\");
                string new_dir = Path.GetDirectoryName(openFileDialog1.FileNames[0]) + "\\EDITED_IMAGES\\";
                foreach (MyBitmap b in imagesToFix.Keys)
                {
                    int index = openFileDialog1.FileNames.ToList().IndexOf(b.path);
                    b.bmp.Save(new_dir + "\\" + b.name + "_EDITED.png", ImageFormat.Png);
                }
            }
            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnTestPixels.Enabled = false;
            btnFixPixels.Enabled = false;
        }
        #endregion
    }
}
