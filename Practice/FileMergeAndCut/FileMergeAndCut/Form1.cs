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
using System.Diagnostics;

namespace FileMergeAndCut
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDlog;
        private FileInfo openFileInfo;
        private FileStream openFileStream;

        private FolderBrowserDialog saveFolderDlog;
        private FolderBrowserDialog selectFolderDlog;

        private int mergeFileMaxNum;
        private Dictionary<int, FileInfo> selectFileDics;
        private string selectFileName;
        private string selectFileExtension;
        public Form1()
        {
            InitializeComponent();
            mergeFileMaxNum = 0;
            unitCombo.SelectedIndex = 2;
            selectFileDics = new Dictionary<int, FileInfo>();
            selectFileName = "";
            selectFileExtension = "";
            mergePanel.Visible = false;
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
                MessageBox.Show("File not be selected！");
                return;
            }
            if(string.IsNullOrEmpty(saveDirctTB.Text) == true)
            {
                MessageBox.Show("Dirctory not be selected!");
                return;
            }

            int value;
            if(!int.TryParse(valueTB.Text, out value))
            {
                MessageBox.Show("The value is not numeric type!");
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

        private void valueTB_TextChanged(object sender, EventArgs e)
        {
            TextBox temp = (TextBox)sender;

            try
            {
                int value = Convert.ToInt32(temp.Text);
                temp.Text = value.ToString();
            }catch
            {
                temp.Text = "1";
                MessageBox.Show("please insert numeric type!");
            }
            
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            if (selectFolderDlog == null)
            {
                selectFolderDlog = new FolderBrowserDialog();
            }

            mergeFileList.Items.Clear();
            selectFileDics.Clear();
            mergeFileMaxNum = 0;
            selectFileName = "";
            selectFileExtension = "";

            if(selectFolderDlog.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo dirctInfo = new DirectoryInfo(selectFolderDlog.SelectedPath);
                selectTB.Text = dirctInfo.FullName;
                FileInfo[] files = dirctInfo.GetFiles();

                foreach(FileInfo item in files)
                {
                    if(item.Extension.Contains(".part".ToString()))
                    {
                        if (string.IsNullOrEmpty(selectFileName) || string.IsNullOrEmpty(selectFileExtension))
                        {
                            string real = item.Name.Substring(0, item.Name.IndexOf(".part"));
                            selectFileExtension = real.Substring(real.LastIndexOf("."));
                            selectFileName = real.Substring(0, real.IndexOf("."));
                        }

                        string temp = item.Extension.Substring(item.Extension.LastIndexOf(".part")+5);
                        int partNum;
                        if(int.TryParse(temp, out partNum))
                        {
                            mergeFileList.Items.Add(item);
                            selectFileDics[partNum] = item;
                            if (partNum > mergeFileMaxNum)
                            {
                                mergeFileMaxNum = partNum;
                            }
                        }
                    }
                }
                mergePB.Maximum = mergeFileList.Items.Count;
            }
        }

        private void mergeBtn_Click(object sender, EventArgs e)
        {
            if (mergeFileList.Items.Count <= 1)
            {
                MessageBox.Show("The File is not enough!");
                return;
            }
            this.Enabled = false;

            FileStream fw = new FileStream(selectTB.Text+@"\"+selectFileName+selectFileExtension,FileMode.Create);
            int readCount = 0;
            byte[] bytes = new byte[1024*1024*3];
            for (int i = 1; i <= mergeFileMaxNum; i++)
			{
                if(selectFileDics.ContainsKey(i))
                {
                    FileInfo info = selectFileDics[i];
                    using(FileStream fr = info.OpenRead())
                    {
                        while ((readCount = fr.Read(bytes, 0, bytes.Length)) > 0)
                        {
                            fw.Write(bytes, 0, readCount);
                        }
                        mergePB.Value++;
                    }
                }
                else
                {
                    MessageBox.Show("The File lost part" + i.ToString()+"!");
                }
			}
            fw.Close();
            this.Enabled = true;
        }

        private void openFileTB_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(openFileTB.Text))
            {
                Process.Start(Path.GetDirectoryName(openFileTB.Text));
            }
        }

        private void saveDirctTB_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(saveDirctTB.Text))
            {
                Process.Start(saveDirctTB.Text);
            }
        }

        private void selectTB_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectTB.Text))
            {
                Process.Start(selectTB.Text);
            }
        }

        private void cutRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton temp = (RadioButton)sender;
            if (temp.Checked)
            {
                cutPanel.Visible = true;
                mergePanel.Visible = false;
            }
        }

        private void mergeRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton temp = (RadioButton)sender;
            if (temp.Checked)
            {
                cutPanel.Visible = false;
                mergePanel.Visible = true;
            }
        }
    }
}
