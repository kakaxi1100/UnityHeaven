using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //1、反序输出字符串
            //string s = Console.ReadLine();
            //for (int i = s.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(s[i]);
            //}
            //Console.ReadKey();

            //2、接收一句话，将其中的单词反序输出
            //string s = Console.ReadLine();
            //string[] ss = s.Split(new char[] { ' ' });
            //foreach (string w in ss)
            //{
            //    for (int i = w.Length - 1; i >= 0; i--)
            //    {
            //        Console.Write(w[i]);
            //    }
            //    Console.Write(" ");
            //}
            //Console.ReadKey();

            //3、”2015年08月05日”从日期字符串中把年月日分别取出来，打印到控制台
            //string s = "2015年08月05日";
            //string[] ss = s.Split(new char[] { '年', '月', '日' }, StringSplitOptions.RemoveEmptyEntries);
            //foreach (var w in ss)
            //{
            //    Console.WriteLine(w);
            //}
            //Console.ReadKey();

            //4、把csv文件中的联系人姓名和电话显示出来。简单模拟csv文件，csv文件就是使用,分割数据的文本,输出：
            //姓名：张三  电话：15001111113
            //string[] ss = File.ReadAllLines("aa.csv", Encoding.Default);
            //foreach (var item in ss)
            //{
            //    string[] temp = item.Split(',');
            //    Console.WriteLine("name：{0}, phone：{1}", temp[0], temp[1]);
            //}
            //Console.ReadKey();

            //5、123-456---7---89-----123----2把类似的字符串中重复符号”-”去掉，
            //既得到123-456-7-89-123-2.
            //string s = "123-456---7---89-----123----2";
            //string[] ss = s.Split(new char[]{'-'}, StringSplitOptions.RemoveEmptyEntries);
            //string temp = String.Join("-", ss);
            //Console.WriteLine(temp);
            //Console.ReadKey();

            //6、从文件路径中提取出文件名(包含后缀) 。
            //比如从c:\a\b.txt中提取出b.txt这个文件名出来。
            //string fileName = @"c:\aa\b\1.txt";
            //string s = Path.GetFileName(fileName);
            //Console.WriteLine(s);
            //Console.ReadKey();

            //7、“192.168.10.5[port=21,type=ftp]”，
            //这个字符串表示IP地址为192.168.10.5的服务器的21端口提供的是ftp服务，
            //其中如果“,type=ftp”部分被省略，则默认为http服务。请用程序解析此字符串，
            //然后打印出“IP地址为***的服务器的***端口提供的服务为***” line.Contains(“type=”)。
            //192.168.10.5[port=21]
            //string s1 = "192.168.10.5[port=21,type=ftp]";
            //string[] s1s = s1.Split(new char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
            //string[] ports = s1s[1].Split(',')[0].Split('=');
            //string serv;
            //if(s1.Contains("ftp"))
            //{
            //    serv = "ftp";
            //}else{
            //    serv = "http";
            //}
            //Console.WriteLine("IP地址为 {0} 的服务器的 {1} 端口提供的服务为 {2}", s1s[0], ports[1], serv);
            //Console.ReadKey();
        }
    }
}
