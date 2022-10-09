namespace Automator
{
    partial class Connect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Connect = new System.Windows.Forms.Button();
            this.txtB_ConfigurationFileName = new System.Windows.Forms.TextBox();
            this.lbl_ConfigurationFile = new System.Windows.Forms.Label();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.chkB_RememberConfigFile = new System.Windows.Forms.CheckBox();
            this.lbl_SpreadsheetId = new System.Windows.Forms.Label();
            this.txtB_SpreadsheetId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Connect
            // 
            this.btn_Connect.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Connect.Location = new System.Drawing.Point(213, 119);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(126, 56);
            this.btn_Connect.TabIndex = 0;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = false;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // txtB_ConfigurationFileName
            // 
            this.txtB_ConfigurationFileName.Location = new System.Drawing.Point(167, 79);
            this.txtB_ConfigurationFileName.Name = "txtB_ConfigurationFileName";
            this.txtB_ConfigurationFileName.Size = new System.Drawing.Size(244, 23);
            this.txtB_ConfigurationFileName.TabIndex = 1;
            // 
            // lbl_ConfigurationFile
            // 
            this.lbl_ConfigurationFile.AutoSize = true;
            this.lbl_ConfigurationFile.Location = new System.Drawing.Point(13, 82);
            this.lbl_ConfigurationFile.Name = "lbl_ConfigurationFile";
            this.lbl_ConfigurationFile.Size = new System.Drawing.Size(148, 15);
            this.lbl_ConfigurationFile.TabIndex = 2;
            this.lbl_ConfigurationFile.Text = "Choose Configuration File:";
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Location = new System.Drawing.Point(417, 79);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(28, 26);
            this.btn_OpenFile.TabIndex = 3;
            this.btn_OpenFile.Text = "...";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // chkB_RememberConfigFile
            // 
            this.chkB_RememberConfigFile.AutoSize = true;
            this.chkB_RememberConfigFile.Location = new System.Drawing.Point(13, 139);
            this.chkB_RememberConfigFile.Name = "chkB_RememberConfigFile";
            this.chkB_RememberConfigFile.Size = new System.Drawing.Size(182, 19);
            this.chkB_RememberConfigFile.TabIndex = 4;
            this.chkB_RememberConfigFile.Text = "Remember Configuration File";
            this.chkB_RememberConfigFile.UseVisualStyleBackColor = true;
            this.chkB_RememberConfigFile.CheckedChanged += new System.EventHandler(this.chkB_RememberConfigFile_CheckedChanged);
            // 
            // lbl_SpreadsheetId
            // 
            this.lbl_SpreadsheetId.AutoSize = true;
            this.lbl_SpreadsheetId.Location = new System.Drawing.Point(77, 51);
            this.lbl_SpreadsheetId.Name = "lbl_SpreadsheetId";
            this.lbl_SpreadsheetId.Size = new System.Drawing.Size(87, 15);
            this.lbl_SpreadsheetId.TabIndex = 5;
            this.lbl_SpreadsheetId.Text = "Spreadsheet Id:";
            // 
            // txtB_SpreadsheetId
            // 
            this.txtB_SpreadsheetId.Location = new System.Drawing.Point(167, 43);
            this.txtB_SpreadsheetId.Name = "txtB_SpreadsheetId";
            this.txtB_SpreadsheetId.Size = new System.Drawing.Size(244, 23);
            this.txtB_SpreadsheetId.TabIndex = 6;
            // 
            // Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 229);
            this.Controls.Add(this.txtB_SpreadsheetId);
            this.Controls.Add(this.lbl_SpreadsheetId);
            this.Controls.Add(this.chkB_RememberConfigFile);
            this.Controls.Add(this.btn_OpenFile);
            this.Controls.Add(this.lbl_ConfigurationFile);
            this.Controls.Add(this.txtB_ConfigurationFileName);
            this.Controls.Add(this.btn_Connect);
            this.Name = "Connect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Connect;
        private TextBox txtB_ConfigurationFileName;
        private Label lbl_SheetId;
        private Button btn_OpenFile;
        private Label lbl_ConfigurationFile;
        private CheckBox chkB_RememberConfigFile;
        private Label lbl_SpreadsheetId;
        private TextBox txtB_SpreadsheetId;
    }
}