using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageMagick;

namespace FormatConverter.Class
{
   public class swap
    {
        public bool ConvertFile(string inputPath, string outputPath, MagickFormat outputFormat)
        {
            try
            {
                //Verify if the input file exists
                if (!File.Exists(inputPath))
                    throw new FileNotFoundException("Input file not founded!", inputPath);

                // Get the output directory
                Directory.CreateDirectory(Path.GetDirectoryName(outputPath));

                // Read settings for the input file
                var settings = new MagickReadSettings
                {
                    Density = new Density(300, 300),  // DPI to PDF/SVG
                    BackgroundColor = MagickColors.White  // Background color for PDF/SVG
                };

                // Load the input file with settings
                using (var image = new MagickImage(inputPath, settings))
                {
                    // Apply transformations if needed
                    image.Quality = 90;  // Qualidade para JPEG/WebP
                    image.Format = outputFormat;

                    // Save the output file
                    image.Write(outputPath);
                }
                
                
                

                MessageBox.Show($"✅ File converted successfully \n {Path.GetFileName(inputPath)} -> {outputPath}");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error converting {inputPath}: {ex.Message}");
                return false;
            }
        }
    }
}

