using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormatConverter;
using FormatConverter.Class;
using ImageMagick;

namespace FormatConverter.Class
{
    class Converter
    {
        swap Swap = new swap();

        public void Convert(string conversionType, OpenFileDialog openFileDialog1, SaveFileDialog saveFileDialog)
        {
            switch (conversionType)
            {
                case "png":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Png
                        );
                    }
                    break;
                case "jpg":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Jpg
                        );
                    }
                    break;
                case "psd":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Psd
                        );
                    }
                    break;

                case "svg":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Svg
                        );
                    }
                    break;
                case "palm":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Palm
                        );
                    }
                    break;
                case "mtv":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Mtv
                        );
                    }
                    break;
                case "pam":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Pam
                        );
                    }
                    break;
                case "otb":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Otb
                        );
                    }
                    break;
                case "hrz":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Hrz
                        );
                    }
                    break;
                case "ipl":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Ipl
                        );
                    }
                    break;
                case "sun":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Sun
                        );
                    }
                    break;
                case "uyvy":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Uyvy
                        );
                    }
                    break;
                case "xv":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Xv
                        );
                    }
                    break;
                case "fts":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Fts
                        );
                    }
                    break;
                case "g4":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.G4
                        );
                    }
                    break;
                case "pct":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Pct
                        );
                    }
                    break;
                case "fax":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Fax
                        );
                    }
                    break;
                case "six":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Six
                        );
                    }
                    break;
                case "rgbo":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Rgbo
                        );
                    }
                    break;
                case "vips":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Vips
                        );
                    }
                    break;
                case "jps":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Jps
                        );
                    }
                    break;
                case "viff":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Viff
                        );
                    }
                    break;
                case "pfm":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Pfm
                        );
                    }
                    break;
                case "sgi":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Sgi
                        );
                    }
                    break;
                case "mng":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Mng
                        );
                    }
                    break;
                case "rgf":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Rgf
                        );
                    }
                    break;
                case "pict":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Pict
                        );
                    }
                    break;
                case "pgx":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Pgx
                        );
                    }
                    break;
                case "yuv":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Yuv
                        );
                    }
                    break;
                case "pal":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Pal
                        );
                    }
                    break;
                case "pcd":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Pcd
                        );
                    }
                    break;
                case "sixel'":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Sixel
                        );
                    }
                    break;
                case "ras":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Ras
                        );
                    }
                    break;
                case "g3":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.G3
                        );
                    }
                    break;
                case "jpe":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Jpe
                        );
                    }
                    break;
                case "picon":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Picon
                        );
                    }
                    break;
                case "pbm":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Pbm
                        );
                    }
                    break;
                case "pdb":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Pdb
                        );
                    }
                    break;
                case "jp2":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Jp2
                        );
                    }
                    break;
                case "pnm":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Pnm
                        );
                    }
                    break;
                case "map":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Map
                        );
                    }
                    break;
                case "heif":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Heif
                        );
                    }
                    break;
                case "xbm":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Xbm
                        );
                    }
                    break;
                case "rgba":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Rgba
                        );
                    }
                    break;
                case "wbmp":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Wbmp
                        );
                    }
                    break;
                case "pcx":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Pcx
                        );
                    }
                    break;
                case "ppm":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Ppm
                        );
                    }
                    break;
                case "avif":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Avif
                        );
                    }
                    break;
                case "bmp":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Bmp
                        );
                    }
                    break;
                case "pgm":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Pgm
                        );
                    }
                    break;
                case "tga":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Tga
                        );
                    }
                    break;
                case "dds":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Dds
                        );
                    }
                    break;
                case "exr":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Exr
                        );
                    }
                    break;
                case "tiff":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Tiff
                        );
                    }
                    break;
                case "xpm":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Xpm
                        );
                    }
                    break;
                case "gif":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Gif
                        );
                    }
                    break;
                case "webp":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.WebP
                        );
                    }
                    break;
                case "rgb":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Rgb
                        );
                    }
                    break;
                case "cur":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Cur
                        );
                    }
                    break;
                case "heic":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Heic
                        );
                    }
                    break;
                case "hdr":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Hdr
                        );
                    }
                    break;
                case "ico":
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Swap.ConvertFile(
                        inputPath: openFileDialog1.FileName,
                        outputPath: $"{saveFileDialog.FileName}",
                        outputFormat: MagickFormat.Ico
                        );
                    }
                    break;

                default:
                    MessageBox.Show("Format not supported.");
                    break;
            }
        }
        }
    }




    

