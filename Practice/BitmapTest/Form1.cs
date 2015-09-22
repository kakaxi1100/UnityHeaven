using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmapTest
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics device;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            bmp.Dispose();
            device.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap("skellyarcher.png");
            device = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pictureBox1.Image = bmp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bmp.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox1.Image = bmp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Image = bmp;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox1.Image = bmp;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipXY);
            pictureBox1.Image = bmp;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    Color old = bmp.GetPixel(i, j);
                    Color dest = Color.FromArgb(0, old.G, 0);
                    bmp.SetPixel(i, j, dest);
                }
            }
            pictureBox1.Image = bmp;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 255);
            Color black = Color.FromArgb(0, 0, 0);
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    if (bmp.GetPixel(i,j) == white)
                    {
                        bmp.SetPixel(i, j, black);
                    }
                }
            }
            pictureBox1.Image = bmp;
        }
    }
}
