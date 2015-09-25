using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Game
    {
        Bitmap mBmp;
        Graphics mDevice;
        public Game(int w, int h)
        {
            Trace.WriteLine("Game init");
            mBmp = new Bitmap(w, h);
            mDevice = Graphics.FromImage(mBmp);
        }

        public Bitmap BMP
        {
            get
            {
                return mBmp;
            }
        }

        public Graphics Device
        {
            get
            {
                return mDevice;
            }
        }

        public Bitmap LoadBitmap(string fileName)
        {
            Bitmap bmp = null;
            try
            {
                bmp = new Bitmap(fileName);
            }
            catch (Exception)
            {
                
                throw;
            }
            return bmp;
        }

        public Bitmap CutBitmap(ref Bitmap source, int x, int y, int w, int h)
        {
            Bitmap temp = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(temp);
            
            g.DrawImage(source, 0, 0, new Rectangle(0, 0 ,w, h), GraphicsUnit.Pixel);
            return temp;
        }
        public Bitmap CutBitmap(string fileName, int x, int y, int w, int h)
        {
            Bitmap source = LoadBitmap(fileName);
            return CutBitmap(ref source,x,y, w, h);
        }

        public void DrawBitmap(ref Bitmap bmp, int x, int y , int w, int h)
        {
            mDevice.DrawImageUnscaled(bmp, x, y, w, h);
        }
        public void DrawBitmap(ref Bitmap bmp)
        {
            mDevice.DrawImageUnscaled(bmp, 0, 0);
        }

        public void Clear()
        {
            mDevice.Clear(Color.White);
        }
        ~Game()
        {
            mBmp.Dispose();
        }
    }
}
