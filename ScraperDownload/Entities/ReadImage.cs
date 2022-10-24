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
        public string ReadImageFromUser(string imagePath, string fileName, bool backGroundColorDark)
        {
            try
            {
                using (var image = Pix.LoadFromFile(imagePath + "\\" + fileName))
                {
                    var bitImage = PixConverter.ToBitmap(image);
                    if(backGroundColorDark == true) InvertImage(bitImage);

                    var pixConveterd = PixConverter.ToPix(bitImage);

                    using (var page = _engine.Process(pixConveterd))
                    {
                        var text = page.GetText();
                        Directory.Delete(imagePath, true);

                        return text;
                    }
                }
            }
            catch (FileNotFoundException)
            {
                return "not found";
            }
        }

        private void InvertImage(Bitmap image)
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
        public List<object> FilterText(string text, string imageURL, string pokerRoom)
        {
            string result;
            string line;
            var matchesValueWithDollarSign = new Regex(@"(\$((\d*)[.,]*(\d*)[.,]*(\d*)))");
            var resultList = new List<object>();

            using(var sr = new StringReader(text))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    var valueDollarSign = matchesValueWithDollarSign.Match(line);
                    if (valueDollarSign.Success)
                    {
                        result = valueDollarSign.Groups[0].Value;
                        result = result.Replace("$", "");
                        result = result.Replace(",", "");
                        result = result.Replace(".", ",");
                        resultList.Add(result);
                    }
                }
            }
            resultList.Add(@$"=HIPERLINK(" +'"'+ imageURL +'"' + ";" + '"' + pokerRoom + '"' + ")");
            return resultList;
        }
    }
}

