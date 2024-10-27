using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda_verdeviva.Model.Common
{
    public static class Network
    {
        public static readonly string BaseUrl = "http://18.188.227.244:8080/verdeviva";
        public static readonly HttpClient HttpClient = new HttpClient();

        public static async Task<Image> LoadWebpImageFromUrl(string url, PictureBox pictureBox)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Obtendo o stream da imagem
                    using (Stream stream = await client.GetStreamAsync(url))
                    {
                        // Carregando a imagem WEBP
                        using (SKBitmap skBitmap = SKBitmap.Decode(stream))
                        {
                            if (skBitmap != null)
                            {
                                // Converter SKBitmap para Bitmap do Windows Forms
                                using (var ms = new MemoryStream())
                                {
                                    skBitmap.Encode(ms, SKEncodedImageFormat.Png, 100);
                                    ms.Seek(0, SeekOrigin.Begin); // Reposiciona o ponteiro no início do stream

                                    // Carregar a imagem no PictureBox
                                    var image = Image.FromStream(ms);
                                    pictureBox.Image = image;

                                    // Definir o modo de tamanho para evitar corte da imagem
                                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Ou StretchImage, conforme a necessidade

                                    return image; // Retorna a imagem, se necessário
                                }
                            }
                            else
                            {
                                Console.WriteLine("Erro: Imagem não pôde ser carregada como WEBP.");
                                return null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar a imagem: {ex.Message}");
                return null;
            }
        }
    }
}
