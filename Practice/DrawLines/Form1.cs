using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLines
{
    public partial class Form1 : Form
    {
        Bitmap surface;
        Graphics device;
        Random rand;
        Timer timer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            surface = new Bitmap(this.Size.Width, this.Size.Height);
            pb.Image = surface;
            device = Graphics.FromImage(surface);
            rand = new Random();

            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
            timer.Start();

            //drawString();
            drawBitmap();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //drawLine();
            //drawRect();
        }


        public void drawBitmap()
        {
            Bitmap bmp = new Bitmap("planet.bmp");
            device.DrawImage(bmp, 0, 0);
            device.DrawImage(bmp, 400, 10, 64, 64);
        }
        public void drawString()
        {
            string[] text = { "据《福布斯》网络版报道","野村证券和加拿大皇家银行发表投资报告称",
                             "市场低估了iPhone 6s销售的潜在影响。",
                             "依赖于中国因素",
                             "2016年iPhone 6s销量将达到2.5亿部",
                             "高于2.33亿部的平均预期。",
                             "野村证券分析师杰弗里·克沃尔(Jeffrey Kvaal)表示",
                             "市场对iPhone销量的预期过于保守。",
                             "鉴于首发市场包括中国",
                             "苹果认为销售第一个周末iPhone 6s销量将超过2014年的1000万部并未‘揭示真相’。",
                             "“6s中国在首发市场行列，事实远不止苹果官方认为第一个周末6s销量超过2014年1000万台。”克沃尔表示",
                             "鉴于2015年第二季度，中国iPhone销量在全球市场的占比由2014年第三季度的15 % 上升至27 %",
                             "因此，上周末iPhone 6s销量应当比苹果官方认为的更高。”",
                             "另外，克沃尔分析认为，如今iPhone 6的普及率还是相当低。",
                             "目前，iPhone 6降价有助于苹果蚕食Android平板手机的市场份额。" };

            Font[] fonts = { new Font("Wingdings",rand.Next(12, 30), FontStyle.Regular,GraphicsUnit.Pixel),
                             new Font("BrushScriptStd",rand.Next(12, 30), FontStyle.Regular,GraphicsUnit.Pixel),
                             new Font("Latha",rand.Next(12, 30), FontStyle.Regular,GraphicsUnit.Pixel),
                             new Font("楷体",rand.Next(12, 30), FontStyle.Regular,GraphicsUnit.Pixel),
                             new Font("RosewoodStd-Regular",rand.Next(12, 30), FontStyle.Regular,GraphicsUnit.Pixel)};
            for (int i = 0; i < text.Length; i++)
            {
                device.DrawString(text[i], fonts[rand.Next(0, 4)], Brushes.Red, 10, 10 + i * 32);
            }
            pb.Image = surface;
        }

        public void drawRect()
        {
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            Color c = Color.FromArgb(A, R, G, B);
            int w = rand.Next(2, 8);
            Pen pen = new Pen(c, w);

            int wr = rand.Next(20, 80);
            int hr = rand.Next(20, 80);
            int xr = rand.Next(0, this.Size.Width - wr);
            int yr = rand.Next(0, this.Size.Height - hr);

            Rectangle r = new Rectangle(xr, yr, wr, hr);
            device.DrawRectangle(pen, r);

            pb.Image = surface;
        }

        public void drawLine()
        {
            //make a random color
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            Color c = Color.FromArgb(A, R, G, B);
            int w = rand.Next(2, 8);
            Pen pen = new Pen(c, w);

            int x1 = rand.Next(1, this.Size.Width);
            int y1 = rand.Next(1, this.Size.Height);

            int x2 = rand.Next(1, this.Size.Width);
            int y2 = rand.Next(1, this.Size.Height);

            device.DrawLine(pen, x1, y1, x2, y2);
            pb.Image = surface;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            device.Dispose();
            surface.Dispose();
            timer.Dispose();
        }
    }
}
