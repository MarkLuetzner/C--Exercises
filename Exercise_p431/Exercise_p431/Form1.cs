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

namespace Exercise_p431
{
    public partial class Form1 : Form
    {
        Excuse currentExcuse = new Excuse();
        private string foldername;
        private bool formChanged;

        public Form1()
        {
            InitializeComponent();
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = "";
               DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                foldername = folderBrowserDialog1.SelectedPath;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(description.Text) && !string.IsNullOrWhiteSpace(results.Text))
            {

                DialogResult result = saveFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    saveFileDialog1.InitialDirectory = foldername;
                    currentExcuse.LastUsed = lastUsed.Value;
                    currentExcuse.Description = description.Text;
                    currentExcuse.Results = results.Text;
                    currentExcuse.Save(saveFileDialog1.FileName);
                    UpdateForm(false);
                }
                else
                {
                    MessageBox.Show("Please specify an excuse and a result");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentExcuse = new Excuse(openFileDialog1.FileName);
                currentExcuse.OpenFile(openFileDialog1.FileName);
                UpdateForm(false);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(foldername);
            Random random = new Random();
            string randomLoadName = files[random.Next(0, files.Length)].ToString();
            currentExcuse.OpenFile(randomLoadName);
            UpdateForm(false);
        }

        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                this.description.Text = currentExcuse.Description;
                this.results.Text = currentExcuse.Results;
                this.lastUsed.Value = currentExcuse.LastUsed;
                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                    fileDate.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                this.Text = "Excuse Manager";
            }
            else
                this.Text = "Excuse Manager*";
            this.formChanged = changed;
        }
         
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
