namespace SkinProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLoadSkin = new System.Windows.Forms.Button();
            this.btnTestPixels = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFixPixels = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadSkin
            // 
            this.btnLoadSkin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLoadSkin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLoadSkin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadSkin.Location = new System.Drawing.Point(12, 13);
            this.btnLoadSkin.Name = "btnLoadSkin";
            this.btnLoadSkin.Size = new System.Drawing.Size(60, 60);
            this.btnLoadSkin.TabIndex = 0;
            this.btnLoadSkin.TabStop = false;
            this.btnLoadSkin.Text = "Load Skin";
            this.btnLoadSkin.UseVisualStyleBackColor = false;
            this.btnLoadSkin.Click += new System.EventHandler(this.btnLoadSkin_Click);
            // 
            // btnTestPixels
            // 
            this.btnTestPixels.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTestPixels.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTestPixels.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTestPixels.Location = new System.Drawing.Point(12, 79);
            this.btnTestPixels.Name = "btnTestPixels";
            this.btnTestPixels.Size = new System.Drawing.Size(60, 60);
            this.btnTestPixels.TabIndex = 1;
            this.btnTestPixels.TabStop = false;
            this.btnTestPixels.Text = "Test Pixels";
            this.btnTestPixels.UseVisualStyleBackColor = false;
            this.btnTestPixels.Click += new System.EventHandler(this.btnTestPixels_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(131, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(12, 211);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 60);
            this.btnExit.TabIndex = 3;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // btnFixPixels
            // 
            this.btnFixPixels.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFixPixels.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFixPixels.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFixPixels.Location = new System.Drawing.Point(12, 145);
            this.btnFixPixels.Name = "btnFixPixels";
            this.btnFixPixels.Size = new System.Drawing.Size(60, 60);
            this.btnFixPixels.TabIndex = 4;
            this.btnFixPixels.TabStop = false;
            this.btnFixPixels.Text = "Fix Pixels";
            this.btnFixPixels.UseVisualStyleBackColor = false;
            this.btnFixPixels.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 305);
            this.Controls.Add(this.btnFixPixels);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTestPixels);
            this.Controls.Add(this.btnLoadSkin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PixChecker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadSkin;
        private System.Windows.Forms.Button btnTestPixels;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnFixPixels;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

