using AltoHttp;
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

        }

        private void btn_GetInfo_Click(object sender, EventArgs e)
        {
            string tessDataPath = @"C:\Users\rodri\tesseract\tessdata";
            string tessDataLanguage = "eng";
            string imagePath = Directory.GetCurrentDirectory() + "\\Images";

            ReadImage readImage = new ReadImage(new TesseractEngine(tessDataPath, tessDataLanguage, EngineMode.Default));
            string result = readImage.ReadImageFromUser(imagePath, "\\" + txtB_FileName.Text + ".png");
            var filteredText = readImage.FilterText(result);
            MessageBox.Show(filteredText, txtB_Url.Text);
            
        }
    }
}