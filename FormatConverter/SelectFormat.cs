using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormatConverter.Class;


namespace FormatConverter
{
    public partial class SelectFormat: Form
    {
        private MainForm _mainForm;
        public SelectFormat(MainForm mainForm)
        {
            InitializeComponent();
            searchTBox.Text = placeholderText;
            _mainForm = mainForm;
        }

        string placeholderText = "Search...";

        private void searchTBox_Enter(object sender, EventArgs e)
        {
            if (searchTBox.Text == placeholderText)
            {
                searchTBox.Text = "";
            }
        }

        private void searchTBox_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(searchTBox.Text))
            {
                searchTBox.Text = placeholderText;
            }
        }

        private void btnCloseSF_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)//botão de imagem para abrir panel de formatos de imagem
        {
            vectorTablePanel.Visible = false;
            documentTablePanel.Visible = false;
            ebookTablePanel.Visible = false;
            imageTablePanel.Visible = true;

            imageTablePanel.Height = 451;
            imageTablePanel.Dock = DockStyle.None;
        }

        private void btnDocument_Click(object sender, EventArgs e)
        {
            vectorTablePanel.Visible = false;
            ebookTablePanel.Visible = false;
            imageTablePanel.Visible = false;
            documentTablePanel.Visible = true;

            documentTablePanel.Height = 120;
            documentTablePanel.Dock = DockStyle.None;
        }


        private void btnEbook_Click(object sender, EventArgs e)
        {
            vectorTablePanel.Visible = false;
            imageTablePanel.Visible = false;
            documentTablePanel.Visible = false;
            ebookTablePanel.Visible = true;
            ebookTablePanel.Height = 90;
            ebookTablePanel.Dock = DockStyle.None;
        }

        private void btnVector_Click(object sender, EventArgs e)
        {
            ebookTablePanel.Visible = false;
            imageTablePanel.Visible = false;
            documentTablePanel.Visible = false;
            vectorTablePanel.Visible = true;
            vectorTablePanel.Height = 90;
            vectorTablePanel.Dock = DockStyle.None;
        }
        private void vectorTablePanel_Click(object sender, EventArgs e)
        {

        }

        private void button99_Click(object sender, EventArgs e)
        {

        }
        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
       

        private void PNG_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "png";
            this.Hide();
        }


    }
}
