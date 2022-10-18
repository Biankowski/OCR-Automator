using AltoHttp;
using Automator.Entities;
using ScraperDownload.Entities;
using Tesseract;

namespace ScraperDownload
{
    public partial class Frm_Downloader : Form
    {
        public Frm_Downloader()
        {
            InitializeComponent();
        }

        HttpDownloader httpDownloader;
        private void btn_Download_Click(object sender, EventArgs e)
        {
            string imageUrl = txtB_Url.Text + ".png";
            string imagePath = Directory.GetCurrentDirectory() + "\\Images";

            if (!Directory.Exists(Path.Combine(imagePath)))
            {
                Directory.CreateDirectory(Path.Combine(imagePath));
            }
            httpDownloader = new HttpDownloader(imageUrl, $"{imagePath}\\{Path.GetFileName(txtB_FileName.Text + ".png")}");
            httpDownloader.Start();
            Thread.Sleep(2 * 1000);
            MessageBox.Show("Download Compleated!");
        }
        private void btn_GetInfo_Click(object sender, EventArgs e)
        {
            string tessDataPath = @"C:\Program Files\Tesseract-OCR\tessdata";
            string tessDataLanguage = "eng";
            string imagePath = Directory.GetCurrentDirectory() + "\\Images";

            ReadImage readImage = new ReadImage(new TesseractEngine(tessDataPath, tessDataLanguage, EngineMode.Default));
            string result = readImage.ReadImageFromUser(imagePath, "\\" + txtB_FileName.Text + ".png");
            var filteredText = readImage.FilterText(result);
            //SheetConnector.CreateEntry(filteredText);
            int index = SheetConnector.GetValuesFromSheet(DateOnly.FromDateTime(DatePicker.Value));
            SheetConnector.CreateEntry(filteredText, index);


            //MessageBox.Show(result);
            
           
        }
    }
}