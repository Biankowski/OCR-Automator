using Automator.Entities;
using ScraperDownload;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automator
{
    public partial class Connect : Form
    { 
        public Connect()
        {
            InitializeComponent();
            if (Properties.Settings.Default.ConfigurationFile != String.Empty)
            {
                txtB_ConfigurationFileName.Text = Properties.Settings.Default.ConfigurationFile;
            }
            if(Properties.Settings.Default.SpreadSheetId != String.Empty)
            {
                txtB_SpreadsheetId.Text = Properties.Settings.Default.SpreadSheetId;
            }
            if(Properties.Settings.Default.ConfigurationFile != string.Empty && Properties.Settings.Default.SpreadSheetId != string.Empty)
            {
                chkB_RememberConfigFile.Checked = Enabled;
            }
        }
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (SheetConnector.Connect(txtB_ConfigurationFileName.Text) == true)
            {
                SheetConnector.spreadsheetId = txtB_SpreadsheetId.Text;
                Frm_Downloader frm_Downloader = new Frm_Downloader();
                frm_Downloader.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Configuration File");
            }
        }
        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.ShowDialog();
                FileInfo fileInfo = new FileInfo(openFile.FileName);
                txtB_ConfigurationFileName.Text = fileInfo.Name;
            }
            catch (Exception)
            {
            }
            
        }
        private void chkB_RememberConfigFile_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB_RememberConfigFile.Checked == true)
            {
                Properties.Settings.Default.ConfigurationFile = txtB_ConfigurationFileName.Text;
                Properties.Settings.Default.SpreadSheetId = txtB_SpreadsheetId.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.ConfigurationFile = "";
                Properties.Settings.Default.SpreadSheetId = txtB_SpreadsheetId.Text;
                Properties.Settings.Default.Save();
            }
        }
    }
}
