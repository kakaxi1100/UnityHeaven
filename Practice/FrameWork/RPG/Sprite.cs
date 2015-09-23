using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Sprite
    {
        private Graphics mGraphics;
        private int mCurrentFrame;
        private int mTotalFrames;
        private Bitmap[] mBitmaps;
        private PointF mPos;
        private bool isRunning;
        public Sprite(Graphics graphics, Bitmap[] bitmaps = null)
        {
            mPos = new PointF(0, 0);
            mBitmaps = bitmaps;
            mGraphics = graphics;
            mCurrentFrame = 0;
            if (mBitmaps != null)
            {
                mTotalFrames = mBitmaps.Length;
            }
        }

        public Bitmap[] Bitmaps
        {
            get
            {
                return mBitmaps;
            }
            set
            {
                mBitmaps = value;
                mTotalFrames = mBitmaps.Length;
            }
        }

        public PointF Pos
        {
            get
            {
                return mPos;
            }
            set
            {
                mPos = value;
            }
        }

        public float Y
        {
            get 
            {
                return mPos.Y;
            }
            set
            {
                mPos.Y = value;
            }
        }

        public float X
        {
            get
            {
                return mPos.X;
            }
            set
            {
                mPos.X = value;
            }
        }

        public void Dispose()
        {
            for (int i = 0; i < mBitmaps.Length; i++)
            {
                mBitmaps[i].Dispose();
            }
        }

        public void play()
        {
            isRunning = true;
        }

        public void stop()
        {
            isRunning = false;
        }

        public void update()
        {
            if (!isRunning)
            {
                return;
            }

            Bitmap bitmap = mBitmaps[mCurrentFrame++];
            mGraphics.DrawImage(bitmap, mPos);

            if (mCurrentFrame == mTotalFrames - 1)
            {
                mCurrentFrame = 0;
            }
        }
    }
}
