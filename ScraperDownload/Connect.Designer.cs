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
            this.lbl_SheetId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Connect
            // 
            this.btn_Connect.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Connect.Location = new System.Drawing.Point(231, 78);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(126, 56);
            this.btn_Connect.TabIndex = 0;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = false;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // txtB_ConfigurationFileName
            // 
            this.txtB_ConfigurationFileName.Location = new System.Drawing.Point(181, 49);
            this.txtB_ConfigurationFileName.Name = "txtB_ConfigurationFileName";
            this.txtB_ConfigurationFileName.Size = new System.Drawing.Size(244, 23);
            this.txtB_ConfigurationFileName.TabIndex = 1;
            // 
            // lbl_SheetId
            // 
            this.lbl_SheetId.AutoSize = true;
            this.lbl_SheetId.Location = new System.Drawing.Point(35, 52);
            this.lbl_SheetId.Name = "lbl_SheetId";
            this.lbl_SheetId.Size = new System.Drawing.Size(140, 15);
            this.lbl_SheetId.TabIndex = 2;
            this.lbl_SheetId.Text = "Configuration File Name:";
            // 
            // Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 235);
            this.Controls.Add(this.lbl_SheetId);
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
    }
}