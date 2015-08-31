using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileMergeAndCut
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDlog;
        private FileStream openFileStream;

        private FolderBrowserDialog saveFolderDlog;
        public Form1()
        {
            InitializeComponent();
            unitCombo.SelectedIndex = 2;
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            if (openFileDlog == null)
            {
                openFileDlog = new OpenFileDialog();
                openFileDlog.RestoreDirectory = true;
            }

            if(openFileDlog.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(openFileDlog.FileName);
                openFileTB.Text = fileInfo.FullName;

                openFileStream = fileInfo.Open(FileMode.Open, FileAccess.Read);

            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (saveFolderDlog == null)
            {
                saveFolderDlog = new FolderBrowserDialog();
            }
            if(saveFolderDlog.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo dirctInfo = new DirectoryInfo(saveFolderDlog.SelectedPath);
                saveDirctTB.Text = dirctInfo.FullName;
            }
        }
    }
}
