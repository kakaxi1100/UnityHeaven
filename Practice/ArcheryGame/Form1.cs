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

namespace ArcheryGame
{
    public partial class Form1 : Form
    {
        private Game mGame;
        private Bitmap mGrass;
        private Sprite[] mDragon;
        private Sprite[] mSkeleton;
        private Sprite[] mZombie;
        private Sprite[] mSpider;
        private Sprite[] mArcher;
        private Sprite mArrow;
        private bool mGameOver;
        private int mCurrentTime;
        private int mStartTime;

        private float mDragonX;
        private float mDragonY;
        private int mDragonDir;
        private float mDragonSpeed;

        private float mSkeletonX;
        private float mSkeletonY;
        private int mSkeletonDir;
        private float mSkeletonSpeed;

        private float mZombieX;
        private float mZombieY;
        private int mZombieDir;
        private float mZombieSpeed;

        private float mSpiderX;
        private float mSpiderY;
        private int mSpiderDir;
        private float mSpiderSpeed;

        private float mArrowX;
        private float mArrowY;
        private float mArrowSpeed;
        private bool mArrowAlive;

        private int mScore;
        public Form1()
        {
            InitializeComponent();
        }

        private void Init()
        {
            InitDragon();
            InitSkeleton();
            InitZombie();
            InitSpider();
            initArrow();

            mScore = 0;
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
            Bitmap dragonBmp = mGame.LoadBitmap("dragonflying.png");//图片的分辨率是200，宽度是 1024， 而画布（设备）的分辨率是 96 ， 所以它在画布上的大小是 （1024/200）*96 = 492
            //如果要保持 1024 像素宽度，则图片的分辨率要降为 96 
            dragonBmp.SetResolution(96, 96);
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
            spiderBmp.SetResolution(96, 96);
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
            skeletonBmp.SetResolution(96, 96);
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
            zombieBmp.SetResolution(96, 96);
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
            archerBmp.SetResolution(96, 96);
            Sprite archer = new Sprite(mGame.Device);
            Bitmap[] archerTemp = new Bitmap[10];
            for (int j = 0; j < 10; j++)//列
            {
                archerTemp[j] = mGame.CutBitmap(ref archerBmp, j * 96, 0, 96, 96);
            }
            archer.Bitmaps = archerTemp;
            mArcher[0] = archer;
            mArcher[0].stop();
            mArcher[0].X = 252;
            mArcher[0].Y = 450;
            #endregion
            #region arrow
            //make arrow bitmap
            //mArrow = mGame.CutBitmap("arrow.png", 0, 0, 32, 32);
            Bitmap arrowBmp = mGame.LoadBitmap("arrow.png");
            arrowBmp.SetResolution(96, 96);
            Bitmap[] bmp = new Bitmap[1];
            bmp[0] = mGame.CutBitmap(ref arrowBmp, 0, 0, 32, 32);
            mArrow = new Sprite(mGame.Device, bmp);
            mArrow.X = mArrowX;
            mArrow.Y = mArrowY;
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
                    //draw monsters
                    MoveDragon();
                    MoveSkeleton();
                    MoveSpider();
                    MoveZombie();
                    //draw archer
                    if (mArcher[0].CurrentFrame == mArcher[0].TotalFrames - 1)
                    {
                        mArcher[0].gotoAndStop(0);
                    }
                    mArcher[0].update();
                    //draw arrow
                    MoveArrow();
                    //draw score
                    updateScore();
                }
            }
            GameEnd();
            // form 退出
            Application.Exit();
        }

        private void initArrow()
        {
            mArrowX = 284;
            mArrowY = 450;
            mArrowSpeed = 10;
            mArrowAlive = false;
        }
        private void MoveArrow()
        {
            if (mArrowAlive == true)
            {
                mArrowY -= mArrowSpeed;
                mArrow.Y = mArrowY;
                mArrow.X = mArrowX;
                mArrow.update();
                if (mArrowY < -32)
                {
                    mArrowAlive = false;
                }
            }
        }


        private void InitSpider()
        {
            mSpiderX = 600;
            mSpiderY = 150;
            mSpiderDir = 0;
            mSpiderSpeed = 3;
        }
        private void MoveSpider()
        {
            if (mSpiderDir == 1)//向右
            {
                if (mSpiderX < this.pictureBox1.Width)
                {
                    mSpiderX += mSpiderSpeed;
                    mSpider[1].X = mSpiderX;
                    mSpider[1].Y = mSpiderY;
                    mSpider[1].update();
                    if (mSpider[1].IsColliding(ref mArrow) && mArrowAlive)
                    {
                        mScore += 3;
                        InitSpider();
                        initArrow();
                        mArrow.Y = mArrowY;
                        mArrow.X = mArrowX;
                    }
                }
                else
                {
                    mSpiderDir = 0;
                }
            }
            else if (mSpiderDir == 0)//向左
            {
                if (mSpiderX > -100)
                {
                    mSpiderX -= mSpiderSpeed;
                    mSpider[0].X = mSpiderX;
                    mSpider[0].Y = mSpiderY;
                    mSpider[0].update();
                    if (mSpider[0].IsColliding(ref mArrow) && mArrowAlive)
                    {
                        mScore += 3;
                        InitSpider();
                        initArrow();
                        mArrow.Y = mArrowY;
                        mArrow.X = mArrowX;
                    }
                }
                else
                {
                    mSpiderDir = 1;
                }
            }
        }

        private void InitZombie()
        {
            mZombieX = -96;
            mZombieY = 200;
            mZombieDir = 1;
            mZombieSpeed = 1;
        }
        private void MoveZombie()
        {
            if (mZombieDir == 1)//向右
            {
                if (mZombieX < this.pictureBox1.Width)
                {
                    mZombieX += mZombieSpeed;
                    mZombie[1].X = mZombieX;
                    mZombie[1].Y = mZombieY;
                    mZombie[1].update();
                    if (mZombie[1].IsColliding(ref mArrow) && mArrowAlive)
                    {
                        mScore += 1;
                        InitZombie();
                        initArrow();
                        mArrow.Y = mArrowY;
                        mArrow.X = mArrowX;
                    }
                }
                else
                {
                    mZombieDir = 0;
                }
            }
            else if (mZombieDir == 0)//向左
            {
                if (mZombieX > -100)
                {
                    mZombieX -= mZombieSpeed;
                    mZombie[0].X = mZombieX;
                    mZombie[0].Y = mZombieY;
                    mZombie[0].update();
                    if (mZombie[0].IsColliding(ref mArrow) && mArrowAlive)
                    {
                        mScore += 1;
                        InitZombie();
                        initArrow();
                        mArrow.Y = mArrowY;
                        mArrow.X = mArrowX;
                    }
                }
                else
                {
                    mZombieDir = 1;
                }

            }
        }

        private void InitSkeleton()
        {
            mSkeletonX = 600;
            mSkeletonY = 100;
            mSkeletonDir = 0;
            mSkeletonSpeed = 2;
        }
        private void MoveSkeleton()
        {
            if (mSkeletonDir == 1)//向右
            {
                if (mSkeletonX < this.pictureBox1.Width)
                {
                    mSkeletonX += mSkeletonSpeed;
                    mSkeleton[1].X = mSkeletonX;
                    mSkeleton[1].Y = mSkeletonY;
                    mSkeleton[1].update();
                    if (mSkeleton[1].IsColliding(ref mArrow) && mArrowAlive)
                    {
                        mScore += 2;
                        InitSkeleton();
                        initArrow();
                        mArrow.Y = mArrowY;
                        mArrow.X = mArrowX;
                    }
                }
                else
                {
                    mSkeletonDir = 0;
                }
            }
            else if (mSkeletonDir == 0)//向左
            {
                if (mSkeletonX > -100)
                {
                    mSkeletonX -= mSkeletonSpeed;
                    mSkeleton[0].X = mSkeletonX;
                    mSkeleton[0].Y = mSkeletonY;
                    mSkeleton[0].update();
                    if (mSkeleton[0].IsColliding(ref mArrow) && mArrowAlive)
                    {
                        mScore += 2;
                        InitSkeleton();
                        initArrow();
                        mArrow.Y = mArrowY;
                        mArrow.X = mArrowX;
                    }
                }
                else
                {
                    mSkeletonDir = 1;
                }

            }
        }

        private void InitDragon()
        {
            mDragonX = -100;
            mDragonY = 0;
            mDragonDir = 1;
            mDragonSpeed = 5;
        }
        private void MoveDragon()
        {
            if (mDragonDir == 1)//向右
            {
                if (mDragonX < this.pictureBox1.Width)
                {
                    mDragonX += mDragonSpeed;
                    mDragon[1].X = mDragonX;
                    mDragon[1].Y = mDragonY;
                    mDragon[1].update();
                    if (mDragon[1].IsColliding(ref mArrow) && mArrowAlive)
                    {
                        mScore += 5;
                        InitDragon();
                        initArrow();
                        mArrow.Y = mArrowY;
                        mArrow.X = mArrowX;
                    }
                }
                else
                {
                    mDragonDir = 0;
                }
            }
            else if(mDragonDir == 0)//向左
            {
                if (mDragonX > -100)
                {
                    mDragonX -= mDragonSpeed;
                    mDragon[0].X = mDragonX;
                    mDragon[0].Y = mDragonY;
                    mDragon[0].update();
                    if (mDragon[0].IsColliding(ref mArrow) && mArrowAlive)
                    {
                        mScore += 5;
                        InitDragon();
                        initArrow();
                        mArrow.Y = mArrowY;
                        mArrow.X = mArrowX;
                    }
                }
                else
                {
                    mDragonDir = 1;
                }
                
            }
        }

        private void updateScore()
        {
            mGame.Print("SCORE " + mScore.ToString());
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    mGameOver = true;
                    break;
                case Keys.Space:
                    if (mArrowAlive == false)
                    {
                        initArrow();
                        mArrowAlive = true;
                        mArcher[0].gotoAndPlay(0);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
