using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using NLua;
using System.IO;

namespace LuaInterfaceTest
{
    
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*Lua a = new Lua();
            a.DoFile("1.lua");
            var c = a["myvar"];
            Trace.WriteLine(c);*/
            Lua state = new Lua();
            double val = 12.0;
            state["x"] = val;
            var res = state.DoString("return 10 + x*(5 + 2)")[0];
            state.DoString("y = 10 + x*(5 + 2)");
            var y = state["y"];
            Trace.WriteLine(y);
            state.DoString(@"function ScriptFunc() end");
            var scriptFunc = state["ScriptFunc"] as LuaFunction;
            var ress = scriptFunc.Call()[0];
            Trace.WriteLine(ress);
        }

        private void DoPrint()
        {

        }
    }
}
