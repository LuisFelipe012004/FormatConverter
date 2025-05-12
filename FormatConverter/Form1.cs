using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormatConverter.Class;
using ImageMagick;

namespace FormatConverter
{
    public partial class MainForm : Form
    {

        public string conversionType { get; set; } = null;
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/LuisFelipe012004");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                string fileExtension = System.IO.Path.GetExtension(filePath).ToLower();

                label2.Text = filePath;
                try
                {
                    string[] lines = System.IO.File.ReadAllLines(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error to read the file: {ex.Message}", "Error");
                }
            }
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            try
            {
                swap Swap = new swap();
                Converter converter = new Converter();

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = $"Save as (*.{conversionType};|*.{conversionType};";
                    saveFileDialog.DefaultExt = $"*.{conversionType}";

                    if (openFileDialog1.FileName != null && conversionType != null)
                    {
                        converter.Convert(conversionType, openFileDialog1, saveFileDialog);
                    }
                    else
                    {
                        MessageBox.Show("Please select a file and conversion type before proceeding.", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SelectFormat selectFormat = new SelectFormat(this);
            selectFormat.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void label1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = $"*.{conversionType}";
        }

        public void label2_TextChanged(object sender, EventArgs e)
        {            
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
