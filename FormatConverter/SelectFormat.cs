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
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e) //jpg button
        {
            _mainForm.conversionType = "jpg";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e) //psd button
        {
            _mainForm.conversionType = "psd";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e) //svg button
        {
            _mainForm.conversionType = "svg";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void PALM_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "palm";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void MTV_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "mtv";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void PAM_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "pam";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void OTB_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "otb";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void HRZ_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "hrz";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void IPL_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "ipl";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void SUN_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "sun";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void UYVY_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "uyvy";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void XV_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "xv";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void FTS_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "fts";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void G4_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "g4";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void PCT_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "pct";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void FAX_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "fax";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void SIX_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "six";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void RGBO_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "rgbo";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void VIPS_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "vips";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void JPS_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "jps";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void VIFF_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "viff";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void PFM_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "pfm";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void SGI_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "sgi";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void MNG_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "mng";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void RGF_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "rgf";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void PICT_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "pict";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void PGX_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "pgx";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void YUV_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "yuv";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void PAL_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "pal";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void PCD_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "pcd";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void SIXEL_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "sixel";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void RAS_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "ras";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void G3_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "g3";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void JPE_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "jpe";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void PICON_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "picon";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void PBM_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "pbm";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void PDB_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "pdb";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void JP2_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "jp2";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void PNM_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "pnm";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void MAP_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "map";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void HEIF_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "heif";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void XBM_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "xbm";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void RGBA_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "rgba";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void WBMP_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "wbmp";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void PCX_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "pcx";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void PPM_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "ppm";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void AVIFF_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "aviff";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void BPM_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "bpm";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void PGM_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "pgm";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void TGA_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "tga";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void DDS_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "dds";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void EXR_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "exr";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void TIFF_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "tiff";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void XPM_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "xpm";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void GIF_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "gif";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void WEBP_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "webp";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void RGB_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "rgb";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void CUR_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "cur";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void HEIC_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "heic";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void HDR_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "hdr";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void ICO_Click(object sender, EventArgs e)
        {
            _mainForm.conversionType = "ico";
            _mainForm.label1_TextChanged(sender, e);
            this.Hide();
        }

        private void imageTablePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
