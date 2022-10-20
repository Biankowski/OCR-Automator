namespace ScraperDownload
{
    partial class Frm_Downloader
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Downloader));
            this.txtB_PokerStarsScreenShot = new System.Windows.Forms.TextBox();
            this.lbl_StarsScreenShot = new System.Windows.Forms.Label();
            this.btn_PokerStarsDownload = new System.Windows.Forms.Button();
            this.btn_GetInfo = new System.Windows.Forms.Button();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.lbl_BodogScreenShot = new System.Windows.Forms.Label();
            this.txtB_BodogScreenShot = new System.Windows.Forms.TextBox();
            this.btn_BodogDownload = new System.Windows.Forms.Button();
            this.rB_PokerStarsScreenshotBGColorDark = new System.Windows.Forms.RadioButton();
            this.rB_PokerStarsScreenShotBGColorWhite = new System.Windows.Forms.RadioButton();
            this.rB_BodogScreenShotBGColorDark = new System.Windows.Forms.RadioButton();
            this.rB_BodogScreenshotBGColorWhite = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtB_PokerStarsScreenShot
            // 
            this.txtB_PokerStarsScreenShot.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtB_PokerStarsScreenShot.Location = new System.Drawing.Point(347, 61);
            this.txtB_PokerStarsScreenShot.Name = "txtB_PokerStarsScreenShot";
            this.txtB_PokerStarsScreenShot.Size = new System.Drawing.Size(361, 23);
            this.txtB_PokerStarsScreenShot.TabIndex = 0;
            // 
            // lbl_StarsScreenShot
            // 
            this.lbl_StarsScreenShot.AutoSize = true;
            this.lbl_StarsScreenShot.Location = new System.Drawing.Point(214, 64);
            this.lbl_StarsScreenShot.Name = "lbl_StarsScreenShot";
            this.lbl_StarsScreenShot.Size = new System.Drawing.Size(127, 15);
            this.lbl_StarsScreenShot.TabIndex = 1;
            this.lbl_StarsScreenShot.Text = "PokerStars ScreenShot:";
            // 
            // btn_PokerStarsDownload
            // 
            this.btn_PokerStarsDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PokerStarsDownload.Location = new System.Drawing.Point(714, 61);
            this.btn_PokerStarsDownload.Name = "btn_PokerStarsDownload";
            this.btn_PokerStarsDownload.Size = new System.Drawing.Size(90, 24);
            this.btn_PokerStarsDownload.TabIndex = 2;
            this.btn_PokerStarsDownload.Text = "Get Info";
            this.btn_PokerStarsDownload.UseVisualStyleBackColor = true;
            this.btn_PokerStarsDownload.Click += new System.EventHandler(this.btn_PokerStarsDownload_Click);
            // 
            // btn_GetInfo
            // 
            this.btn_GetInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GetInfo.Location = new System.Drawing.Point(474, 193);
            this.btn_GetInfo.Name = "btn_GetInfo";
            this.btn_GetInfo.Size = new System.Drawing.Size(87, 37);
            this.btn_GetInfo.TabIndex = 5;
            this.btn_GetInfo.Text = "Get Info";
            this.btn_GetInfo.UseVisualStyleBackColor = true;
            this.btn_GetInfo.Click += new System.EventHandler(this.btn_GetInfo_Click);
            // 
            // DatePicker
            // 
            this.DatePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DatePicker.CustomFormat = "dd/MM/yyyy";
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(457, 12);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(104, 23);
            this.DatePicker.TabIndex = 6;
            // 
            // lbl_BodogScreenShot
            // 
            this.lbl_BodogScreenShot.AutoSize = true;
            this.lbl_BodogScreenShot.Location = new System.Drawing.Point(238, 126);
            this.lbl_BodogScreenShot.Name = "lbl_BodogScreenShot";
            this.lbl_BodogScreenShot.Size = new System.Drawing.Size(103, 15);
            this.lbl_BodogScreenShot.TabIndex = 7;
            this.lbl_BodogScreenShot.Text = "Bodog SceenShot:";
            // 
            // txtB_BodogScreenShot
            // 
            this.txtB_BodogScreenShot.Location = new System.Drawing.Point(347, 123);
            this.txtB_BodogScreenShot.Name = "txtB_BodogScreenShot";
            this.txtB_BodogScreenShot.Size = new System.Drawing.Size(361, 23);
            this.txtB_BodogScreenShot.TabIndex = 8;
            // 
            // btn_BodogDownload
            // 
            this.btn_BodogDownload.Location = new System.Drawing.Point(714, 122);
            this.btn_BodogDownload.Name = "btn_BodogDownload";
            this.btn_BodogDownload.Size = new System.Drawing.Size(90, 23);
            this.btn_BodogDownload.TabIndex = 9;
            this.btn_BodogDownload.Text = "Get Info";
            this.btn_BodogDownload.UseVisualStyleBackColor = true;
            this.btn_BodogDownload.Click += new System.EventHandler(this.btn_BodogDownload_Click);
            // 
            // rB_PokerStarsScreenshotBGColorDark
            // 
            this.rB_PokerStarsScreenshotBGColorDark.AutoSize = true;
            this.rB_PokerStarsScreenshotBGColorDark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rB_PokerStarsScreenshotBGColorDark.Location = new System.Drawing.Point(0, 5);
            this.rB_PokerStarsScreenshotBGColorDark.Name = "rB_PokerStarsScreenshotBGColorDark";
            this.rB_PokerStarsScreenshotBGColorDark.Size = new System.Drawing.Size(49, 19);
            this.rB_PokerStarsScreenshotBGColorDark.TabIndex = 10;
            this.rB_PokerStarsScreenshotBGColorDark.TabStop = true;
            this.rB_PokerStarsScreenshotBGColorDark.Text = "Dark";
            this.rB_PokerStarsScreenshotBGColorDark.UseVisualStyleBackColor = true;
            // 
            // rB_PokerStarsScreenShotBGColorWhite
            // 
            this.rB_PokerStarsScreenShotBGColorWhite.AutoSize = true;
            this.rB_PokerStarsScreenShotBGColorWhite.Location = new System.Drawing.Point(55, 5);
            this.rB_PokerStarsScreenShotBGColorWhite.Name = "rB_PokerStarsScreenShotBGColorWhite";
            this.rB_PokerStarsScreenShotBGColorWhite.Size = new System.Drawing.Size(56, 19);
            this.rB_PokerStarsScreenShotBGColorWhite.TabIndex = 11;
            this.rB_PokerStarsScreenShotBGColorWhite.TabStop = true;
            this.rB_PokerStarsScreenShotBGColorWhite.Text = "White";
            this.rB_PokerStarsScreenShotBGColorWhite.UseVisualStyleBackColor = true;
            // 
            // rB_BodogScreenShotBGColorDark
            // 
            this.rB_BodogScreenShotBGColorDark.AutoSize = true;
            this.rB_BodogScreenShotBGColorDark.Location = new System.Drawing.Point(0, 1);
            this.rB_BodogScreenShotBGColorDark.Name = "rB_BodogScreenShotBGColorDark";
            this.rB_BodogScreenShotBGColorDark.Size = new System.Drawing.Size(49, 19);
            this.rB_BodogScreenShotBGColorDark.TabIndex = 12;
            this.rB_BodogScreenShotBGColorDark.TabStop = true;
            this.rB_BodogScreenShotBGColorDark.Text = "Dark";
            this.rB_BodogScreenShotBGColorDark.UseVisualStyleBackColor = true;
            // 
            // rB_BodogScreenshotBGColorWhite
            // 
            this.rB_BodogScreenshotBGColorWhite.AutoSize = true;
            this.rB_BodogScreenshotBGColorWhite.Location = new System.Drawing.Point(55, 1);
            this.rB_BodogScreenshotBGColorWhite.Name = "rB_BodogScreenshotBGColorWhite";
            this.rB_BodogScreenshotBGColorWhite.Size = new System.Drawing.Size(56, 19);
            this.rB_BodogScreenshotBGColorWhite.TabIndex = 13;
            this.rB_BodogScreenshotBGColorWhite.TabStop = true;
            this.rB_BodogScreenshotBGColorWhite.Text = "White";
            this.rB_BodogScreenshotBGColorWhite.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rB_PokerStarsScreenShotBGColorWhite);
            this.panel1.Controls.Add(this.rB_PokerStarsScreenshotBGColorDark);
            this.panel1.Location = new System.Drawing.Point(347, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 32);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rB_BodogScreenShotBGColorDark);
            this.panel2.Controls.Add(this.rB_BodogScreenshotBGColorWhite);
            this.panel2.Location = new System.Drawing.Point(347, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 23);
            this.panel2.TabIndex = 15;
            // 
            // Frm_Downloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 378);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_BodogDownload);
            this.Controls.Add(this.txtB_BodogScreenShot);
            this.Controls.Add(this.lbl_BodogScreenShot);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.btn_GetInfo);
            this.Controls.Add(this.btn_PokerStarsDownload);
            this.Controls.Add(this.lbl_StarsScreenShot);
            this.Controls.Add(this.txtB_PokerStarsScreenShot);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Downloader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Downloader";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtB_PokerStarsScreenShot;
        private Label lbl_StarsScreenShot;
        private Button btn_PokerStarsDownload;
        private Button btn_GetInfo;
        private DateTimePicker DatePicker;
        private Label lbl_BodogScreenShot;
        private TextBox txtB_BodogScreenShot;
        private Button btn_BodogDownload;
        private RadioButton rB_PokerStarsScreenshotBGColorDark;
        private RadioButton rB_PokerStarsScreenShotBGColorWhite;
        private RadioButton rB_BodogScreenShotBGColorDark;
        private RadioButton rB_BodogScreenshotBGColorWhite;
        private Panel panel1;
        private Panel panel2;
    }
}