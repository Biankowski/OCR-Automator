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
            this.txtB_Url = new System.Windows.Forms.TextBox();
            this.lbl_UrlLabel = new System.Windows.Forms.Label();
            this.btn_Download = new System.Windows.Forms.Button();
            this.lbl_FileName = new System.Windows.Forms.Label();
            this.txtB_FileName = new System.Windows.Forms.TextBox();
            this.btn_GetInfo = new System.Windows.Forms.Button();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtB_Url
            // 
            this.txtB_Url.Location = new System.Drawing.Point(79, 32);
            this.txtB_Url.Name = "txtB_Url";
            this.txtB_Url.Size = new System.Drawing.Size(361, 23);
            this.txtB_Url.TabIndex = 0;
            // 
            // lbl_UrlLabel
            // 
            this.lbl_UrlLabel.AutoSize = true;
            this.lbl_UrlLabel.Location = new System.Drawing.Point(50, 35);
            this.lbl_UrlLabel.Name = "lbl_UrlLabel";
            this.lbl_UrlLabel.Size = new System.Drawing.Size(25, 15);
            this.lbl_UrlLabel.TabIndex = 1;
            this.lbl_UrlLabel.Text = "Url:";
            // 
            // btn_Download
            // 
            this.btn_Download.Location = new System.Drawing.Point(175, 91);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(87, 39);
            this.btn_Download.TabIndex = 2;
            this.btn_Download.Text = "Download";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // lbl_FileName
            // 
            this.lbl_FileName.AutoSize = true;
            this.lbl_FileName.Location = new System.Drawing.Point(12, 69);
            this.lbl_FileName.Name = "lbl_FileName";
            this.lbl_FileName.Size = new System.Drawing.Size(63, 15);
            this.lbl_FileName.TabIndex = 3;
            this.lbl_FileName.Text = "File Name:";
            // 
            // txtB_FileName
            // 
            this.txtB_FileName.Location = new System.Drawing.Point(79, 62);
            this.txtB_FileName.Name = "txtB_FileName";
            this.txtB_FileName.Size = new System.Drawing.Size(361, 23);
            this.txtB_FileName.TabIndex = 4;
            // 
            // btn_GetInfo
            // 
            this.btn_GetInfo.Location = new System.Drawing.Point(175, 136);
            this.btn_GetInfo.Name = "btn_GetInfo";
            this.btn_GetInfo.Size = new System.Drawing.Size(87, 37);
            this.btn_GetInfo.TabIndex = 5;
            this.btn_GetInfo.Text = "Get Info";
            this.btn_GetInfo.UseVisualStyleBackColor = true;
            this.btn_GetInfo.Click += new System.EventHandler(this.btn_GetInfo_Click);
            // 
            // DatePicker
            // 
            this.DatePicker.CustomFormat = "dd/MM/yyyy";
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(79, 3);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(104, 23);
            this.DatePicker.TabIndex = 6;
            // 
            // Frm_Downloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 284);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.btn_GetInfo);
            this.Controls.Add(this.txtB_FileName);
            this.Controls.Add(this.lbl_FileName);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.lbl_UrlLabel);
            this.Controls.Add(this.txtB_Url);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Downloader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtB_Url;
        private Label lbl_UrlLabel;
        private Button btn_Download;
        private Label lbl_FileName;
        private TextBox txtB_FileName;
        private Button btn_GetInfo;
        private DateTimePicker DatePicker;
    }
}