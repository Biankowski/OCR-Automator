using System.Drawing;
using System.Text.RegularExpressions;
using Tesseract;


namespace ScraperDownload.Entities
{
    public class ReadImage
    {
        private readonly TesseractEngine _engine;
        public ReadImage(TesseractEngine engine)
        {
            _engine = engine;
        }
        public string ReadImageFromUser(string imagePath, string fileName)
        {
            string fullPath = imagePath + fileName;
           
            try
            {
                using (var image = Pix.LoadFromFile(fullPath))
                {
                    var bitImage = PixConverter.ToBitmap(image);
                    InvertImage(bitImage);
                    var pixConveterd = PixConverter.ToPix(bitImage);

                    using (var page = _engine.Process(pixConveterd))
                    {
                        var text = page.GetText();
                        Directory.Delete(Directory.GetCurrentDirectory() + "\\Images", true);

                        return text;
                    }
                }
            }
            catch (FileNotFoundException)
            {
                return "not found";
            }
            
        }
        public void InvertImage(Bitmap image)
        {
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color pixel = image.GetPixel(i, j);

                    int red = pixel.R;
                    int green = pixel.G;
                    int blue = pixel.B;

                    image.SetPixel(i, j, Color.FromArgb(255 - red, 255 - green, 255 - blue));            
                }
            }
        }
        public string FilterText(string text)
        {
            string result;
            string line;
            var matchesValue = new Regex(@"(\$((\d*)[.,]*(\d*)[.,]*(\d*)))");
            var resultList = new List<string>();

            using( var sr = new StringReader(text))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    var value = matchesValue.Match(line);   
                    if (value.Success)
                    {
                        result = value.Groups[0].Value;
                        return result;
                    }
                }
            }
            return "Fail";
        }
    }
}

