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
using System.Diagnostics;

namespace Framework
{
    public partial class Form1 : Form
    {
        private Game mGame;
        private Bitmap mGrass;
        private Sprite[] mDragon;
        private int mCurrentTime;
        private int mStartTime;
        private bool mGameOver;
        private int mDirection;
        private Point mSpeed;
        private PointF mPos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            mGameOver = false;
            mCurrentTime = 0;
            mStartTime = -100;
            mDirection = 0;
            mPos = new PointF(0, 0);
            mSpeed = new Point(0, 0);
            mDragon = new Sprite[4];
            mGame = new Game(this.pictureBox1.Size.Width, this.pictureBox1.Size.Height);
            mGrass = mGame.LoadBitmap("grass.bmp");
            Bitmap dragonBmp = mGame.LoadBitmap("dragon.png");

            #region test bitmap
            /* Bitmap temp = new Bitmap(256, 256);
             Graphics g = Graphics.FromImage(temp);
             g.DrawImage(dragonBmp,0,0,new Rectangle(256,256,256,256),GraphicsUnit.Pixel);
             game.DrawBitmap(ref temp);
             */
            #endregion
            Sprite dragonup = new Sprite(mGame.Device);
            Sprite dragondown = new Sprite(mGame.Device);
            Sprite dragonleft = new Sprite(mGame.Device);
            Sprite dragonright = new Sprite(mGame.Device);

            for (int i = 0; i < 8; i += 2)
            {
                Bitmap[] temp = new Bitmap[8];
                for (int j = 0; j < 8; j++)
                {
                    temp[j] = mGame.CutBitmap(ref dragonBmp, j*256, i*256, 256, 256);
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

            mDragon[0] = dragonup;
            mDragon[0].play();
            mDragon[1] = dragonleft;
            mDragon[1].play();
            mDragon[2] = dragondown;
            mDragon[2].play();
            mDragon[3] = dragonright;
            mDragon[3].play();
            #region dragon test
            /*dragon[0].X = 50;
            dragon[0].Y = 50;
            dragon[0].play();
            dragon[0].update();*/
            #endregion
        }

        private void Main()
        {
            while (!mGameOver)
            {
                Application.DoEvents();
                mCurrentTime = Environment.TickCount;
                if (mCurrentTime > mStartTime + 32)
                {
                    mGame.Clear();
                    pictureBox1.Image = mGame.BMP;
                    mStartTime = mCurrentTime;
                    mGame.DrawBitmap(ref mGrass);
                    mPos.X += mSpeed.X;
                    mPos.Y += mSpeed.Y;

                    mDragon[mDirection].X = mPos.X;
                    mDragon[mDirection].Y = mPos.Y;
                    mDragon[mDirection].update();
                }
            }
            GameEnd();
            Application.Exit();
        }

        private void GameEnd()
        {
            mGameOver = true;
            mGrass.Dispose();
            mGame.BMP.Dispose();
            for (int i = 0; i < mDragon.Length; i++)
            {
                mDragon[i].Dispose();
            }
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            Main();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            mGameOver = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    mGameOver = true;
                    break;
                case Keys.W:
                    mDirection = 0;
                    mSpeed.X = 0;
                    mSpeed.Y = -3;
                    break;
                case Keys.S:
                    mDirection = 2;
                    mSpeed.X = 0;
                    mSpeed.Y = 3;
                    break;
                case Keys.A:
                    mDirection = 1;
                    mSpeed.X = -3;
                    mSpeed.Y = 0;
                    break;
                case Keys.D:
                    mDirection = 3;
                    mSpeed.X = 3;
                    mSpeed.Y = 0;
                    break;
                default:
                    break;
            }
        }
    }
}
