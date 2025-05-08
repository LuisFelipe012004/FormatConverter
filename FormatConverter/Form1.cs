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
                try
                {
                    string[] lines = System.IO.File.ReadAllLines(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao ler o arquivo: {ex.Message}", "Erro");
                }
            }
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
           try
            {
                swap Swap = new swap();               

                using (SaveFileDialog saveFileDialog = new SaveFileDialog()) {
                saveFileDialog.Filter = $"Salvar como (*.{conversionType};|*.{conversionType};";
                saveFileDialog.DefaultExt = $"*.{conversionType}";

                if(saveFileDialog.ShowDialog() == DialogResult.OK) { 
                Swap.ConvertFile(
                inputPath: openFileDialog1.FileName,
                outputPath: $"{saveFileDialog.FileName}",
                outputFormat: MagickFormat.Png                
                ); 
              }
                
             }
               
            }
            catch ( Exception ex ) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SelectFormat selectFormat = new SelectFormat(this);
            selectFormat.Show();
            
        }
    }
}
