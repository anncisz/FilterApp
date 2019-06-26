using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAMProject
{
    public partial class Form1 : Form
    {
        Bitmap temp;
        Bitmap contrastTemp;
        bool isFilter, isContrast;
        Bitmap brightnessTemp;

        public Form1()
        {
            InitializeComponent();
            if(imgBox.Image == null)
            {
                //block if noimage
                delImg.Enabled = false;
                saveImg.Enabled = false;
                delfilterBtn.Enabled = false;
                sepiaBtn.Enabled = false;
                bwBtn.Enabled = false;
                negBtn.Enabled = false;
                grnscrBtn.Enabled = false;
                trcThreshold.Enabled = false;
                trcBrightness.Enabled = false;
            }
        }

        private void addImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog add = new OpenFileDialog();
            add.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *png)|*.jpg; *.jpeg; *.gif; *.bmp; *png";
            if (add.ShowDialog() == DialogResult.OK)
            { 
                this.imgBox.SizeMode = PictureBoxSizeMode.Zoom;
                imgBox.Image = new Bitmap(add.FileName);             
            }

            //unblock if image
            delImg.Enabled = true;
            saveImg.Enabled = true;
            delfilterBtn.Enabled = true;
            sepiaBtn.Enabled = true;
            bwBtn.Enabled = true;
            negBtn.Enabled = true;
            grnscrBtn.Enabled = true;
            trcThreshold.Enabled = true;
            trcBrightness.Enabled = true;

            isFilter = false;
            isContrast = false;

            temp = new Bitmap(imgBox.Image);
            contrastTemp = null;
            brightnessTemp = null;
        }

        private void delImg_Click(object sender, EventArgs e)
        {
            if (imgBox.Image != null)
            {
                imgBox.Image = null;
                temp = null;

                //block again
                delImg.Enabled = false;
                saveImg.Enabled = false;
                delfilterBtn.Enabled = false;
                sepiaBtn.Enabled = false;
                bwBtn.Enabled = false;
                negBtn.Enabled = false;
                grnscrBtn.Enabled = false;
                trcThreshold.Enabled = false;
                trcBrightness.Enabled = false;

            }
        }

        private void sepiaBtn_Click(object sender, EventArgs e)
        {

            Bitmap bmp = new Bitmap(imgBox.Image);
            Color p;
            int width = bmp.Width;
            int height = bmp.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    p = bmp.GetPixel(x, y);

                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //temp value
                    int tr = (int)(0.393 * r + 0.769 * g + 0.189 * b);
                    int tg = (int)(0.349 * r + 0.686 * g + 0.168 * b);
                    int tb = (int)(0.272 * r + 0.534 * g + 0.131 * b);

                    //new value
                    if (tr > 255)
                    {
                        r = 255;
                    }
                    else
                    {
                        r = tr;
                    }

                    if (tg > 255)
                    {
                        g = 255;
                    }
                    else
                    {
                        g = tg;
                    }

                    if (tb > 255)
                    {
                        b = 255;
                    }
                    else
                    {
                        b = tb;
                    }

                    bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            imgBox.Image = bmp;
            isFilter = true;
            contrastTemp = new Bitmap(imgBox.Image);
        }

        private void saveImg_Click(object sender, EventArgs e)
        {
            ApplyFilter(false);
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "JPG(*.JPG)|*.jpg|JPEG(*.JPEG)|*.jpeg|GIF(*.GIF)|*.gif|BMP(*.BMP)|*.bmp|PNG(*.PNG)|*.png";
            if (save.ShowDialog() == DialogResult.OK)
            {
                imgBox.Image.Save(save.FileName);
            }
        }

        private void bwBtn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(imgBox.Image);
            Color p;
            int width = bmp.Width;
            int height = bmp.Height;
            int rgb;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    p = bmp.GetPixel(x, y);
                    rgb = (int)Math.Round(.299 * p.R + .587 * p.G + .114 * p.B);
                    bmp.SetPixel(x, y, Color.FromArgb(rgb, rgb, rgb));
                }
            }
            imgBox.Image = bmp;
            isFilter = true;
            contrastTemp = new Bitmap(imgBox.Image);
        }

        private void negBtn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(imgBox.Image);
            Color p;
            int width = bmp.Width;
            int height = bmp.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    p = bmp.GetPixel(x, y);

                    //set argb value p
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //neg
                    r = 255 - r;
                    g = 255 - g;
                    b = 255 - b;

                    bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            imgBox.Image = bmp;
            isFilter = true;
            contrastTemp = new Bitmap(imgBox.Image);

        }

        private void delfilterBtn_Click(object sender, EventArgs e)
        {
            imgBox.Image = temp;
            isFilter = false;
            isContrast = false;
            trcThreshold.Value = 0;
            lblContrastValue.Text = trcThreshold.Value.ToString();
            ApplyFilter(true);
            trcBrightness.Value = 0;
            lblBrightnessValue.Text = trcBrightness.Value.ToString();
        }

        private void grnscrBtn_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(imgBox.Image);

            // Creating Key Pixel
            int key_R = 0;
            int key_G = 128;
            int key_B = 0;

            Color Key = new Color();
            Key = Color.FromArgb(key_R, key_G, key_B);

            double KCb = -(0.168736 * Key.R) - (0.331264 * Key.G) + (0.5 * Key.B);
            double KCr = 0.5 * Key.R - 0.418688 * Key.G - 0.081312 * Key.B;

            int height = bmp.Height;
            int width = bmp.Width;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color c = bmp.GetPixel(x, y);

                    double Pb = -0.168736 * c.R - 0.331264 * c.G + 0.5 * c.B;
                    double Pr = 0.5 * c.R - 0.418688 * c.G - 0.081312 * c.B;

                    // distance n function point
                    double dist = Math.Sqrt((KCb - Pb) * (KCb - Pb) + (KCr - Pr) * (KCr - Pr));
                    double point = 1;

                    // Range
                    int a1 = 40;
                    int a2 = 60;

                    if (dist <= a1)
                    {
                        point = 0;
                    }
                    else if (dist >= a2)
                    {
                        point = 1;
                    }
                    else if (dist > a1 && dist < a2)
                    {
                        point = (dist - a1) / (a2 - a1);
                    }

                    double q = 1 - point;

                    double PwR = Math.Min(Math.Max(c.R - q * Key.R, 0) + q * Color.White.R, 255);
                    double PwG = Math.Min(Math.Max(c.G - q * Key.G, 0) + q * Color.White.G, 255);
                    double PwB = Math.Min(Math.Max(c.B - q * Key.B, 0) + q * Color.White.B, 255);

                    Color FColor = new Color();
                    FColor = Color.FromArgb((int)PwR, (int)PwG, (int)PwB);

                    bmp.SetPixel(x, y, FColor);
                }
            }
            imgBox.Image = bmp;
            isFilter = true;
            contrastTemp = new Bitmap(imgBox.Image);
        }

        private void TrcThreshold_ValueChanged(object sender, EventArgs e)
        {
            lblContrastValue.Text = trcThreshold.Value.ToString();

            ApplyFilter(true);
        }

        private void ApplyFilter(bool preview)
        {
            Bitmap bmp = new Bitmap(imgBox.Image);
            Bitmap previewBitmap = bmp;

            if (bmp == null)
            {
                return;
            }

            if (preview == true)
            {
                if (isFilter == true)
                {
                    previewBitmap = contrastTemp;
                    imgBox.Image = previewBitmap.Contrast(trcThreshold.Value);
                    isContrast = true;
                    brightnessTemp = new Bitmap(imgBox.Image);
                }
                else
                {
                    previewBitmap = temp;
                    imgBox.Image = previewBitmap.Contrast(trcThreshold.Value);
                    isContrast = true;
                    brightnessTemp = new Bitmap(imgBox.Image);
                }
            }
            else
            {
                imgBox.Image = bmp.Contrast(trcThreshold.Value);
            }

        }

        private void trcBrightness_valueCHanged(object sender, EventArgs e)
        {
            lblBrightnessValue.Text = trcBrightness.Value.ToString();

            AdjustBrightness(new Bitmap(imgBox.Image), trcBrightness.Value);
        }

        public void AdjustBrightness(Bitmap image, int value)
        {
            Bitmap previewBitmap = image;
            if (isFilter == true)
            {
                previewBitmap = contrastTemp;
            }
            if(isContrast == true)
            {
                previewBitmap = brightnessTemp;
            } else 
            {
                previewBitmap = temp;
            }
                //System.Drawing.Bitmap TempBitmap = image;
            float FinalValue = (float)value / 255.0f;
            System.Drawing.Bitmap NewBitmap = new System.Drawing.Bitmap(previewBitmap.Width, previewBitmap.Height);
            System.Drawing.Graphics NewGraphics = System.Drawing.Graphics.FromImage(NewBitmap);
            float[][] FloatColorMatrix ={
                    new float[] {1, 0, 0, 0, 0},
                    new float[] {0, 1, 0, 0, 0},
                    new float[] {0, 0, 1, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {FinalValue, FinalValue, FinalValue, 1, 1}
                };

            System.Drawing.Imaging.ColorMatrix NewColorMatrix = new System.Drawing.Imaging.ColorMatrix(FloatColorMatrix);
            System.Drawing.Imaging.ImageAttributes Attributes = new System.Drawing.Imaging.ImageAttributes();
            Attributes.SetColorMatrix(NewColorMatrix);
            NewGraphics.DrawImage(previewBitmap, new System.Drawing.Rectangle(0, 0, previewBitmap.Width, previewBitmap.Height), 0, 0, previewBitmap.Width, previewBitmap.Height, System.Drawing.GraphicsUnit.Pixel, Attributes);
            Attributes.Dispose();
            NewGraphics.Dispose();
            imgBox.Image = NewBitmap;
        }
    }
}
