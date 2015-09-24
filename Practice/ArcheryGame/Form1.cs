﻿using System;
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
        private Bitmap mGress;
        private Sprite[] mDragon;
        private Sprite[] mSkeleton;
        private Sprite[] mZombie;
        private Sprite[] mArcher;
        private Sprite[] mArrow;
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
            mGress = mGame.LoadBitmap("grass.bmp");
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
            //make zombie sprite
            mArcher = new Sprite[1];
            Bitmap archerBmp = mGame.LoadBitmap("archer_attack.png");
            Sprite archerleft = new Sprite(mGame.Device);
            Sprite archerright = new Sprite(mGame.Device);
            for (int i = 2; i < 7; i += 4)//行
            {
                Bitmap[] temp = new Bitmap[8];
                for (int j = 0; j < 9; j++)//列
                {
                    temp[j] = mGame.CutBitmap(ref archerBmp, j * 96, i * 96, 96, 96);
                }
                if (i == 2)
                {
                    archerright.Bitmaps = temp;
                }
                else if (i == 6)
                {
                    archerleft.Bitmaps = temp;
                }
            }
            mArcher[0] = archerleft;
            mArcher[0].play();
        }
    }
}
