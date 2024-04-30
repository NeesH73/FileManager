using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace FileManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        private void UpdateListBoxLeft()
        {
            listBoxLeft.Items.Clear();

            
            string[] entries = Directory.GetFileSystemEntries(textBoxLeft.Text);

            foreach (string entry in entries)
            {
                listBoxLeft.Items.Add(Path.GetFileName(entry));
            }
        }
        private void UpdateListBoxRight()
        {
            listBoxRight.Items.Clear();


            string[] entries = Directory.GetFileSystemEntries(textBoxRight.Text);

            foreach (string entry in entries)
            {
                listBoxRight.Items.Add(Path.GetFileName(entry));
            }
        }
        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            colorDialog1.Color = Color.RoyalBlue;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
                
            }
        }

        private void размерШрифтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Font = fontDialog1.Font;              
            }
        }

        private void btnsearchleft_Click(object sender, EventArgs e)
        {
            listBoxLeft.Items.Clear(); 
                     
            DirectoryInfo dir = new DirectoryInfo(textBoxLeft.Text);

            DirectoryInfo[] dirs=dir.GetDirectories();

            foreach (DirectoryInfo crrDir in dirs) 
            {
                listBoxLeft.Items.Add(crrDir);
                
            }

            FileInfo[] files=dir.GetFiles();

            foreach (FileInfo file in files)
            {
                listBoxLeft.Items.Add(file);               
            }
        }

        private void btnsearchright_Click(object sender, EventArgs e)
        {
            listBoxRight.Items.Clear();

            DirectoryInfo dir1 = new DirectoryInfo(textBoxRight.Text);

            DirectoryInfo[] dirs1 = dir1.GetDirectories();

            foreach (DirectoryInfo crrDir1 in dirs1)
            {
                listBoxRight.Items.Add(crrDir1);

            }

            FileInfo[] files1 = dir1.GetFiles();

            foreach (FileInfo file1 in files1)
            {
                listBoxRight.Items.Add(file1);
            }
        }

        private void listBoxLeft_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Path.GetExtension(Path.Combine(textBoxLeft.Text, listBoxLeft.SelectedItem.ToString()))=="")
            {
                textBoxLeft.Text = Path.Combine(textBoxLeft.Text, listBoxLeft.SelectedItem.ToString());
                listBoxLeft.Items.Clear();

                DirectoryInfo dir = new DirectoryInfo(textBoxLeft.Text);

                DirectoryInfo[] dirs = dir.GetDirectories();

                foreach (DirectoryInfo crrDir in dirs)
                {
                    listBoxLeft.Items.Add(crrDir);

                }

                FileInfo[] files = dir.GetFiles();

                foreach (FileInfo file in files)
                {
                    listBoxLeft.Items.Add(file);
                }
            }
            else
            {
                Process.Start(Path.Combine(textBoxLeft.Text, listBoxLeft.SelectedItem.ToString()));
            }
            
        }

        private void listBoxRight_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Path.GetExtension(Path.Combine(textBoxRight.Text, listBoxRight.SelectedItem.ToString()))=="")
            {
                textBoxRight.Text = Path.Combine(textBoxRight.Text, listBoxRight.SelectedItem.ToString());
                listBoxRight.Items.Clear();

                DirectoryInfo dir1 = new DirectoryInfo(textBoxRight.Text);

                DirectoryInfo[] dirs1 = dir1.GetDirectories();

                foreach (DirectoryInfo crrDir1 in dirs1)
                {
                    listBoxRight.Items.Add(crrDir1);

                }

                FileInfo[] files1 = dir1.GetFiles();

                foreach (FileInfo file1 in files1)
                {
                    listBoxRight.Items.Add(file1);
                }
            }
            else
            {
                Process.Start(Path.Combine(textBoxRight.Text, listBoxRight.SelectedItem.ToString()));
            }
            
        }

        private void btnbackleft_Click(object sender, EventArgs e)
        {
            if (textBoxLeft.Text[textBoxLeft.Text.Length-1]=='\\')
            {
                textBoxLeft.Text=textBoxLeft.Text.Remove(textBoxLeft.Text.Length-1,1);

                while (textBoxLeft.Text[textBoxLeft.Text.Length-1] != '\\')
                {
                    textBoxLeft.Text = textBoxLeft.Text.Remove(textBoxLeft.Text.Length - 1, 1);
                }
            }
            else if(textBoxLeft.Text[textBoxLeft.Text.Length - 1] != '\\')
            {
                while (textBoxLeft.Text[textBoxLeft.TextLength - 1] != '\\')
                {
                    textBoxLeft.Text = textBoxLeft.Text.Remove(textBoxLeft.Text.Length - 1, 1);
                }
            }
            listBoxLeft.Items.Clear();

            DirectoryInfo dir = new DirectoryInfo(textBoxLeft.Text);

            DirectoryInfo[] dirs = dir.GetDirectories();

            foreach (DirectoryInfo crrDir in dirs)
            {
                listBoxLeft.Items.Add(crrDir);

            }

            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                listBoxLeft.Items.Add(file);
            }
        }

        private void btnbackright_Click(object sender, EventArgs e)
        {
            if (textBoxRight.Text[textBoxRight.Text.Length - 1] == '\\')
            {
                textBoxRight.Text = textBoxRight.Text.Remove(textBoxRight.Text.Length - 1, 1);

                while (textBoxRight.Text[textBoxRight.TextLength - 1] != '\\')
                {
                    textBoxRight.Text = textBoxRight.Text.Remove(textBoxRight.Text.Length - 1, 1);
                }
            }
            else if (textBoxRight.Text[textBoxRight.Text.Length - 1] != '\\')
            {
                while (textBoxRight.Text[textBoxRight.Text.Length - 1] != '\\')
                {
                    textBoxRight.Text = textBoxRight.Text.Remove(textBoxRight.Text.Length - 1, 1);
                }
            }
            listBoxRight.Items.Clear();

            DirectoryInfo dir1 = new DirectoryInfo(textBoxRight.Text);

            DirectoryInfo[] dirs1 = dir1.GetDirectories();

            foreach (DirectoryInfo crrDir1 in dirs1)
            {
                listBoxRight.Items.Add(crrDir1);

            }

            FileInfo[] files1 = dir1.GetFiles();

            foreach (FileInfo file1 in files1)
            {
                listBoxRight.Items.Add(file1);
            }
        }

        private void listBoxLeft_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
        }

        private void listBoxRight_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip2.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(listBoxLeft.SelectedItem.ToString());           
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(listBoxRight.SelectedItem.ToString());
        }

        private void создатьПапкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newFolderName = "Новая папка";
            string fullPath = Path.Combine(textBoxLeft.Text, newFolderName);
            Directory.CreateDirectory(fullPath);
            UpdateListBoxLeft();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string newFolderName = "Новая папка"; 
            string fullPath = Path.Combine(textBoxRight.Text, newFolderName);
            Directory.CreateDirectory(fullPath);           
            UpdateListBoxRight();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string newFileName = "Новый файл.txt";
            string fullPath = Path.Combine(textBoxRight.Text, newFileName);
            File.Create(fullPath).Dispose();
            UpdateListBoxRight();
        }

        private void создатьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newFileName = "Новый файл.txt";
            string fullPath = Path.Combine(textBoxLeft.Text, newFileName);          
            File.Create(fullPath).Dispose();           
            UpdateListBoxLeft();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxLeft.SelectedItem != null)
            {
                string selectedItem = listBoxLeft.SelectedItem.ToString();
                string fullPath = Path.Combine(textBoxLeft.Text, selectedItem);

                if (Directory.Exists(fullPath))
                {
                    
                    Directory.Delete(fullPath, true);
                }
                else if (File.Exists(fullPath))
                {
                    
                    File.Delete(fullPath);
                }

                
                UpdateListBoxLeft();
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (listBoxRight.SelectedItem != null)
            {
                string selectedItem = listBoxRight.SelectedItem.ToString();
                string fullPath = Path.Combine(textBoxRight.Text, selectedItem);

                if (Directory.Exists(fullPath))
                {                    
                    Directory.Delete(fullPath, true);
                }
                else if (File.Exists(fullPath))
                {                  
                    File.Delete(fullPath);
                }              
                UpdateListBoxRight();
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var selectedItem = listBoxRight.SelectedItem as string;
            if (selectedItem != null)
            {
                string oldFullPath = Path.Combine(textBoxRight.Text, selectedItem);
                string newName = Interaction.InputBox("Введите новое имя для " + selectedItem, "Переименование", "", -1, -1);

                if (File.Exists(oldFullPath))
                {
                    string newFullPath = Path.Combine(textBoxRight.Text, newName);
                    File.Move(oldFullPath, newFullPath);
                }
                else if (Directory.Exists(oldFullPath))
                {
                    string newFullPath = Path.Combine(Path.GetDirectoryName(oldFullPath), newName);
                    Directory.Move(oldFullPath, newFullPath);
                }                
                UpdateListBoxRight();
            }
        }

        private void переименоватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedItem = listBoxLeft.SelectedItem as string;
            if (selectedItem != null)
            {
                string oldFullPath = Path.Combine(textBoxLeft.Text, selectedItem);
                string newName = Interaction.InputBox("Введите новое имя для " + selectedItem, "Переименование", "", -1, -1);

                if (File.Exists(oldFullPath))
                {
                    string newFullPath = Path.Combine(textBoxLeft.Text, newName);
                    File.Move(oldFullPath, newFullPath);
                }
                else if (Directory.Exists(oldFullPath))
                {
                    string newFullPath = Path.Combine(Path.GetDirectoryName(oldFullPath), newName);
                    Directory.Move(oldFullPath, newFullPath);
                }               
                UpdateListBoxLeft();
            }
        }

       
    }
}
