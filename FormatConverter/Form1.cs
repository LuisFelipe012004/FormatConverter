using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormatConverter
{
    public partial class MainForm: Form
    {
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

        private void button1_Click(object sender, EventArgs e)//botão de carregar o arquivo que vai ser formatado
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

        }
        private void button2_Click(object sender, EventArgs e)//botão de selecionar o formato
        {
            SelectFormat selectFormat = new SelectFormat();
            selectFormat.Show();
            
        }
    }
}
