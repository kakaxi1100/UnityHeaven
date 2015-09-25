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

namespace ArcheryGame
{
    public partial class Form1 : Form
    {
        private Game mGame;
        private Bitmap mGrass;
        private Sprite[] mDragon;
        private Sprite[] mSkeleton;
        private Sprite[] mZombie;
        private Sprite[] mArcher;
        private Bitmap mArrow;
        private Sprite[] mSpider;
        private bool mGameOver;
        private int mCurrentTime;
        private int mStartTime;

        public Form1()
        {
            InitializeComponent();
        }

        private void Init()
        {
            mGameOver = false;
            mCurrentTime = 0;
            mStartTime = -100;
            mGame = new Game(this.pictureBox1.Size.Width, this.pictureBox1.Size.Height);
            #region grass
            mGrass = mGame.LoadBitmap("grass.bmp");
            #endregion
            #region dragon
            //make dragon sprite
            mDragon = new Sprite[2];
            Bitmap dragonBmp = mGame.LoadBitmap("dragonflying.png");
            Sprite dragonleft = new Sprite(mGame.Device);
            Sprite dragonright = new Sprite(mGame.Device);
            for (int i = 2; i < 7; i += 4)
            {
                Bitmap[] temp = new Bitmap[8];
                for (int j = 0; j < 8; j++)
                {
                    temp[j] = mGame.CutBitmap(ref dragonBmp, j * 128, i * 128, 128, 128);
                }
                if (i == 2)
                {
                    dragonright.Bitmaps = temp;
                }else if (i == 6)
                {
                    dragonleft.Bitmaps = temp;
                }
            }
            mDragon[0] = dragonleft;
            mDragon[0].play();
            mDragon[1] = dragonright;
            mDragon[1].play();
            #endregion
            #region spider
            //make spider sprite
            mSpider = new Sprite[2];
            Bitmap spiderBmp = mGame.LoadBitmap("redspiderwalking.png");
            Sprite spiderleft = new Sprite(mGame.Device);
            Sprite spiderright = new Sprite(mGame.Device);
            for (int i = 2; i < 7; i += 4)
            {
                Bitmap[] temp = new Bitmap[8];
                for (int j = 0; j < 8; j++)
                {
                    temp[j] = mGame.CutBitmap(ref spiderBmp, j * 96, i * 96, 96, 96);
                }
                if (i == 2)
                {
                    spiderright.Bitmaps = temp;
                }
                else if (i == 6)
                {
                    spiderleft.Bitmaps = temp;
                }
            }
            mSpider[0] = spiderleft;
            mSpider[0].play();
            mSpider[1] = spiderright;
            mSpider[1].play();
            #endregion
            #region skeleton
            //make skeleton sprite
            mSkeleton = new Sprite[2];
            Bitmap skeletonBmp = mGame.LoadBitmap("skeleton_walk.png");
            Sprite skeletonleft = new Sprite(mGame.Device);
            Sprite skeletonright = new Sprite(mGame.Device);
            for (int i = 2; i < 7; i += 4)//行
            {
                Bitmap[] temp = new Bitmap[9];
                for (int j = 0; j < 9; j++)//列
                {
                    temp[j] = mGame.CutBitmap(ref skeletonBmp, j * 96, i * 96, 96, 96);
                }
                if (i == 2)
                {
                    skeletonright.Bitmaps = temp;
                }
                else if (i == 6)
                {
                    skeletonleft.Bitmaps = temp;
                }
            }
            mSkeleton[0] = skeletonleft;
            mSkeleton[0].play();
            mSkeleton[1] = skeletonright;
            mSkeleton[1].play();
            #endregion
            #region zombie
            //make zombie sprite
            mZombie = new Sprite[2];
            Bitmap zombieBmp = mGame.LoadBitmap("zombie walk.png");
            Sprite zombieleft = new Sprite(mGame.Device);
            Sprite zombieright = new Sprite(mGame.Device);
            for (int i = 2; i < 7; i += 4)//行
            {
                Bitmap[] temp = new Bitmap[8];
                for (int j = 0; j < 8; j++)//列
                {
                    temp[j] = mGame.CutBitmap(ref zombieBmp, j * 96, i * 96, 96, 96);
                }
                if (i == 2)
                {
                    zombieright.Bitmaps = temp;
                }
                else if (i == 6)
                {
                    zombieleft.Bitmaps = temp;
                }
            }
            mZombie[0] = zombieleft;
            mZombie[0].play();
            mZombie[1] = zombieright;
            mZombie[1].play();
            #endregion
            #region archer
            //make archer sprite
            mArcher = new Sprite[1];
            Bitmap archerBmp = mGame.LoadBitmap("archer_attack.png");
            Sprite archer = new Sprite(mGame.Device);
            Bitmap[] archerTemp = new Bitmap[10];
            for (int j = 0; j < 10; j++)//列
            {
                archerTemp[j] = mGame.CutBitmap(ref archerBmp, j * 96, 0, 96, 96);
            }
            archer.Bitmaps = archerTemp;
            mArcher[0] = archer;
            mArcher[0].play();
            #endregion
            #region arrow
            //make arrow bitmap
            mArrow = mGame.CutBitmap("arrow.png", 0, 0, 32, 32);
            #endregion
        }

        private void Main()
        {
            while (!mGameOver)
            {
                Application.DoEvents(); mCurrentTime = Environment.TickCount;
                if (mCurrentTime > mStartTime + 32)
                {
                    //
                    mGame.Clear();
                    pictureBox1.Image = mGame.BMP;
                    mStartTime = mCurrentTime;
                    //draw grass
                    mGame.DrawBitmap(ref mGrass);

                    mDragon[0].update();
                    //mZombie[0].update();
                }
            }
            GameEnd();
            // form 退出
            Application.Exit();
        }

        private void GameEnd()
        {
            mGameOver = true;
            /*mGrass.Dispose();
            mGame.BMP.Dispose();
            for (int i = 0; i < mDragon.Length; i++)
            {
                mDragon[i].Dispose();
            }*/
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Init();
            Main();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            mGameOver = true;
        }
    }
}
