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
        private FileInfo openFileInfo;
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
                openFileInfo = new FileInfo(openFileDlog.FileName);
                openFileTB.Text = openFileInfo.FullName;

                openFileStream = openFileInfo.Open(FileMode.Open, FileAccess.Read);

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

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (openFileStream == null)
            {
                MessageBox.Show("File not selected！");
                return;
            }
            if(string.IsNullOrEmpty(saveDirctTB.Text) == true)
            {
                MessageBox.Show("Dirctory not selected!");
                return;
            }
            openFileStream.Position = 0;
            filePB.Value = 0;
            this.Enabled = false;
            if (countRadio.Checked == true)
            {
                int count = Convert.ToInt32(valueTB.Text);
                filePB.Maximum = count;
                int perSize = (int)Math.Ceiling((double)openFileStream.Length / count);
                writeFile(perSize);
            }
            else if (sizeRadio.Checked == true)
            {
                int size = Convert.ToInt32(valueTB.Text)*(int)Math.Pow((double)1024, unitCombo.SelectedIndex);
                int count = (int)Math.Ceiling((double)openFileStream.Length / size);
                filePB.Maximum = count;
                writeFile(size);
            }
            this.Enabled = true;
        }

        private void writeFile(int size)
        {
            byte[] bytes = new byte[size];
            int readCount;
            int i = 0;
            while ((readCount = openFileStream.Read(bytes, 0, bytes.Length)) > 0)
            {
                i++;
                using (FileStream fw = new FileStream(saveDirctTB.Text + @"\" + openFileInfo.Name + ".part" + i.ToString(), FileMode.Create))
                {
                    fw.Write(bytes, 0, readCount);
                    filePB.Value++;
                }
            }
        }

        private void countRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton temp = (RadioButton)sender;
            if(temp.Checked)
            {
                unitCombo.Visible = false;
            }
        }

        private void sizeRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton temp = (RadioButton)sender;
            if (temp.Checked)
            {
                unitCombo.Visible = true;
            }
        }
    }
}
