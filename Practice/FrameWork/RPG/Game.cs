using System;
using System.Collections.Generic;
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
        public Game()
        {

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
            g.DrawImage(source, x, y, w, h);
            return temp;
        }
        public Bitmap CutBitmap(string fileName, int x, int y, int w, int h)
        {
            Bitmap source = LoadBitmap(fileName);
            Bitmap temp = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(temp);
            g.DrawImage(source, x, y, w, h);
            return temp;
        }

        public void DrawBitmap(ref Bitmap bmp, int x, int y , int w, int h)
        {
            mDevice.DrawImageUnscaled(bmp, x, y, w, h);
        }
        ~Game()
        {

        }
    }
}
