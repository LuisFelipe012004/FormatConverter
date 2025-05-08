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
                // Verifica se o arquivo de entrada existe
                if (!File.Exists(inputPath))
                    throw new FileNotFoundException("Arquivo de entrada não encontrado!", inputPath);

                // Garante que o diretório de saída existe
                Directory.CreateDirectory(Path.GetDirectoryName(outputPath));

                // Configurações de conversão (opcional)
                var settings = new MagickReadSettings
                {
                    Density = new Density(300, 300),  // DPI para PDF/SVG
                    BackgroundColor = MagickColors.White  // Fundo para formatos com transparência
                };

                // Carrega o arquivo (suporta 100+ formatos)
                using (var image = new MagickImage(inputPath, settings))
                {
                    // Aplica otimizações (opcional)
                    image.Quality = 90;  // Qualidade para JPEG/WebP
                    image.Format = outputFormat;

                    // Salva o arquivo convertido
                    image.Write(outputPath);
                }
                
                
                

                MessageBox.Show($"✅ Conversão concluída: {Path.GetFileName(inputPath)} -> {outputPath}");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Erro ao converter {inputPath}: {ex.Message}");
                return false;
            }
        }
    }
}

