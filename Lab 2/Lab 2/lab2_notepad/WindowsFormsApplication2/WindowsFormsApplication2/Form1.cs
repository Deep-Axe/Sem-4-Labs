using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to save your changes before starting a new file?",
           "Save Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                saveToolStripMenuItem_Click(sender, e); 
            }
            else if (res == DialogResult.No)
            {
                richTextBox1.Clear(); 
            }            
            else if (res == DialogResult.Cancel)
            {
                return;
            }
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open";
            dlg.ShowDialog();
            string fName = dlg.FileName;
            StreamReader sr = new StreamReader(fName);
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Text Document(*.txt) | *.txt | All Files(*.*) | *.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fName = saveFileDialog1.FileName;

                    if (string.IsNullOrEmpty(fName))
                    {
                        MessageBox.Show("No file name provided. Please select a valid location to save the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; 
                    }

                    using (StreamWriter sw = new StreamWriter(fName))
                    {
                        sw.Write(richTextBox1.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Save operation was canceled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = richTextBox1.SelectionFont;
            fd.Color = richTextBox1.SelectionColor;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fd.Font;
                richTextBox1.SelectionColor = fd.Color;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();

            richTextBox1.ForeColor = dlg.Color;  
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {         
            MessageBox.Show("Hi, This is Deepam. I'm a 2nd year at MIT", "About Me", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Are you sure you want to delete all content and exit?",
           "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
           
            if (res == DialogResult.OK)
            {                
                richTextBox1.Clear();                
                MessageBox.Show("The content has been deleted successfully.");                
                Application.Exit();
            }
            else if (res == DialogResult.Cancel)
            {
                this.Close();
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog dlg = new PrintDialog();
            dlg.ShowDialog(); 
        }
    }
}
