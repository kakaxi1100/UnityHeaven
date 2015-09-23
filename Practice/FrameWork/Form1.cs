using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPG;

namespace Framework
{
    public partial class Form1 : Form
    {
        Game game;
        Bitmap grass;
        Sprite[] dragon;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
          
        }

        private void Init()
        {
            dragon = new Sprite[4];
            game = new Game(this.pictureBox1.Size.Width, this.pictureBox1.Size.Height);
            grass = game.LoadBitmap("grass.bmp");
            Bitmap dragonBmp = game.LoadBitmap("dragon.png");

            #region test bitmap
            /* Bitmap temp = new Bitmap(256, 256);
             Graphics g = Graphics.FromImage(temp);
             g.DrawImage(dragonBmp,0,0,new Rectangle(256,256,256,256),GraphicsUnit.Pixel);
             game.DrawBitmap(ref temp);
             */
            #endregion
            Sprite dragonup = new Sprite(game.Device);
            Sprite dragondown = new Sprite(game.Device);
            Sprite dragonleft = new Sprite(game.Device);
            Sprite dragonright = new Sprite(game.Device);

            for (int i = 0; i < 8; i += 2)
            {
                Bitmap[] temp = new Bitmap[8];
                for (int j = 0; j < 8; j++)
                {
                    temp[j] = game.CutBitmap(ref dragonBmp, j, i, 256, 256);
                }
                if (i == 0)
                {
                    dragonup.Bitmaps = temp;
                }
                else if (i == 2)
                {
                    dragonright.Bitmaps = temp;
                }
                else if (i == 4)
                {
                    dragondown.Bitmaps = temp;
                }
                else if (i == 6)
                {
                    dragonleft.Bitmaps = temp;
                }
            }

            dragon[0] = dragonup;
            dragon[1] = dragonleft;
            dragon[2] = dragondown;
            dragon[3] = dragonright;

            game.DrawBitmap(ref grass);
            #region dragon test
            /*dragon[0].X = 50;
            dragon[0].Y = 50;
            dragon[0].play();
            dragon[0].update();*/
            #endregion
            pictureBox1.Image = game.BMP;
        }

        private void Main()
        {

        }
    }
}
