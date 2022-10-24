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

        private const string POKERSTARS_SCREENSHOT_BANKROLL_SHEET_RANGE = "C";
        private const string POKERSTARS_LATEST_BANKROLL_SHEET_RANGE = "B";
        private const string POKERSTARS_SCREENSHOT_URL_SHEET_RANGE = "D";
        private const string BODOG_SCREENSHOT_BANKROLL_SHEET_RANGE = "F";
        private const string BODOG_LATEST_BANKROLL_SHEET_RANGE = "E";
        private const string BODOG_SCREENSHOT_URL_SHEET_RANGE = "G";
        private const string GRAPH_SCREENSHOT_URL_SHEET_RANGE = "H";

        HttpDownloader httpDownloader;
        private void btn_PokerStarsDownload_Click(object sender, EventArgs e)
        {
            //Try catch not working(19/10/2022)
            try
            {
                string pokerStarsScreenShot = txtB_PokerStarsScreenShot.Text + ".png";
                string imagePath = Directory.GetCurrentDirectory() + "\\PokerstarsScreenShot";

                if (!Directory.Exists(Path.Combine(imagePath)))
                {
                    Directory.CreateDirectory(Path.Combine(imagePath));
                }
                httpDownloader = new HttpDownloader(pokerStarsScreenShot, $"{imagePath}\\{Path.GetFileName("pokerstars" + ".png")}");
                httpDownloader.Start();
                Thread.Sleep(2 * 1000);
                MessageBox.Show("Got PokerStars Info!");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error.");
            }

        }
        private void btn_BodogDownload_Click(object sender, EventArgs e)
        {

            string bodogScreenShot = txtB_BodogScreenShot.Text + ".png";
            string imagePath = Directory.GetCurrentDirectory() + "\\BodogScreenShot";

            if (!Directory.Exists(Path.Combine(imagePath)))
            {
                Directory.CreateDirectory(Path.Combine(imagePath));
            }
            httpDownloader = new HttpDownloader(bodogScreenShot, $"{imagePath}\\{Path.GetFileName("bodog" + ".png")}");
            httpDownloader.Start();
            Thread.Sleep(2 * 1000);
            MessageBox.Show("Got Bodog Info!");
        }
        private void btn_DownloadGraphInfo_Click(object sender, EventArgs e)
        {
            string graphScreenShot = txtB_Graph.Text + ".png";
            string graphPath = Directory.GetCurrentDirectory() + "\\GraphScreenShot";

            if (!Directory.Exists(Path.Combine(graphPath)))
            {
                Directory.CreateDirectory(Path.Combine(graphPath));
            }
            httpDownloader = new HttpDownloader(graphScreenShot, $"{graphPath}\\{Path.GetFileName("bodog" + ".png")}");
            httpDownloader.Start();
            Thread.Sleep(2 * 1000);
            MessageBox.Show("Got Graph Info!");
        }
        private void btn_GetInfo_Click(object sender, EventArgs e)
        {
            string pokerStarsResult;
            string bodogResult;
            string tessDataPath = @"C:\Program Files\Tesseract-OCR\tessdata";
            string tessDataLanguage = "eng";
            int index = SheetConnector.GetValuesFromSheet(DateOnly.FromDateTime(DatePicker.Value));
            ReadImage readImage = new ReadImage(new TesseractEngine(tessDataPath, tessDataLanguage, EngineMode.Default));


            if (Directory.Exists(Path.Combine(Directory.GetCurrentDirectory() + "\\PokerstarsScreenShot")))
            {
                var latestValue = SheetConnector.GetLatestValuesFromSheet(DateOnly.FromDateTime(DatePicker.Value), POKERSTARS_SCREENSHOT_BANKROLL_SHEET_RANGE);
                string pokerStarsImagePath = Directory.GetCurrentDirectory() + "\\PokerstarsScreenShot";
                
                if (rB_PokerStarsScreenshotBGColorDark.Checked == true)
                {
                    pokerStarsResult = readImage.ReadImageFromUser(pokerStarsImagePath, "pokerstars" + ".png", true);
                }
                else
                {
                    pokerStarsResult = readImage.ReadImageFromUser(pokerStarsImagePath, "pokerstars" + ".png", false);
                }
                var pokerstarsFiltetedText = readImage.FilterText(pokerStarsResult, txtB_PokerStarsScreenShot.Text, "Stars Cashier");
                SheetConnector.CreateEntry(pokerstarsFiltetedText, index, POKERSTARS_SCREENSHOT_BANKROLL_SHEET_RANGE,
                    POKERSTARS_SCREENSHOT_URL_SHEET_RANGE, latestValue, POKERSTARS_LATEST_BANKROLL_SHEET_RANGE);


            }
            if (Directory.Exists(Path.Combine(Directory.GetCurrentDirectory() + "\\BodogScreenShot")))
            {
                var latestValue = SheetConnector.GetLatestValuesFromSheet(DateOnly.FromDateTime(DatePicker.Value), BODOG_SCREENSHOT_BANKROLL_SHEET_RANGE);
                string bodogImagePath = Directory.GetCurrentDirectory() + "\\BodogScreenShot";
                if (rB_BodogScreenShotBGColorDark.Checked == true)
                {
                    bodogResult = readImage.ReadImageFromUser(bodogImagePath, "bodog" + ".png", true);
                }
                else
                {
                    bodogResult = readImage.ReadImageFromUser(bodogImagePath, "bodog" + ".png", false);
                }
                var bodogFiltetedText = readImage.FilterText(bodogResult, txtB_BodogScreenShot.Text, "Bodog Cashier");
                SheetConnector.CreateEntry(bodogFiltetedText, index, BODOG_SCREENSHOT_BANKROLL_SHEET_RANGE,
                    BODOG_SCREENSHOT_URL_SHEET_RANGE, latestValue, BODOG_LATEST_BANKROLL_SHEET_RANGE);
            }

            if (Directory.Exists(Path.Combine(Directory.GetCurrentDirectory() + "\\GraphScreenShot")))
            {
                var latestValue = SheetConnector.GetLatestValuesFromSheet(DateOnly.FromDateTime(DatePicker.Value), GRAPH_SCREENSHOT_URL_SHEET_RANGE);
                string graphImagePath = Directory.GetCurrentDirectory() + "\\GraphScreenShot";

                var graphFIlteredText = readImage.GetGraphInfo(txtB_Graph.Text);
                SheetConnector.CreateEntry(graphFIlteredText, GRAPH_SCREENSHOT_URL_SHEET_RANGE, index);
            }
        }
    }
}