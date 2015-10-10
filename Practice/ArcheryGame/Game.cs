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
        private Bitmap mBmp;
        private Graphics mDevice;
        private Font mFont;
        public Game(int w, int h)
        {
            Trace.WriteLine("Game init");
            mBmp = new Bitmap(w, h);
            mDevice = Graphics.FromImage(mBmp);
            SetFont("Arial", 18, FontStyle.Regular);
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
           //Pen p = new Pen(Color.Black);
           //g.FillRectangle(p.Brush, new Rectangle(0, 0, temp.Width, temp.Height));
            g.DrawImage(source, 0, 0, new Rectangle(x, y, w, h), GraphicsUnit.Pixel);
            return temp;
        }

        public Bitmap CutBitmap(string fileName, int x, int y, int w, int h)
        {
            Bitmap source = LoadBitmap(fileName);
            return CutBitmap(ref source, x, y, w, h);
        }

        public void DrawBitmap(ref Bitmap bmp, int x, int y , int w, int h)
        {
            mDevice.DrawImageUnscaled(bmp, x, y, w, h);
        }
        public void DrawBitmap(ref Bitmap bmp)
        {
            mDevice.DrawImageUnscaled(bmp, 0, 0);
        }

        public void SetFont(string name, int size, FontStyle style)
        {
            mFont = new Font(name, size, style, GraphicsUnit.Pixel);
        }

        public void Print(float x, float y, string text, Brush color)
        {
            mDevice.DrawString(text, mFont, color, x, y);
        }

        public void Print(string text)
        {
            Print(0, 0, text, Brushes.White);
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
