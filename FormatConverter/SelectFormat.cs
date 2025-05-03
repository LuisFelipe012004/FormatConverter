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

namespace FormatConverter
{
    public partial class SelectFormat: Form
    {
        public SelectFormat()
        {
            InitializeComponent();
            searchTBox.Text = placeholderText;
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

        private void button1_Click(object sender, EventArgs e)
        {          
            imageTablePanel.Visible = true;
        }
    }
}
