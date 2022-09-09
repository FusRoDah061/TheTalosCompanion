namespace TheTalosCompanion
{
    partial class QrCodeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QrCodeForm));
            this.pbScreenshot = new System.Windows.Forms.PictureBox();
            this.txtDecodedText = new System.Windows.Forms.TextBox();
            this.tmrAutoClose = new System.Windows.Forms.Timer(this.components);
            this.pnlCloseTime = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbScreenshot)).BeginInit();
            this.SuspendLayout();
            // 
            // pbScreenshot
            // 
            this.pbScreenshot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbScreenshot.Location = new System.Drawing.Point(0, 0);
            this.pbScreenshot.Name = "pbScreenshot";
            this.pbScreenshot.Size = new System.Drawing.Size(482, 145);
            this.pbScreenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbScreenshot.TabIndex = 0;
            this.pbScreenshot.TabStop = false;
            this.pbScreenshot.MouseEnter += new System.EventHandler(this.pbScreenshot_MouseEnter);
            this.pbScreenshot.MouseLeave += new System.EventHandler(this.pbScreenshot_MouseLeave);
            // 
            // txtDecodedText
            // 
            this.txtDecodedText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDecodedText.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtDecodedText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDecodedText.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDecodedText.ForeColor = System.Drawing.Color.Black;
            this.txtDecodedText.Location = new System.Drawing.Point(6, 152);
            this.txtDecodedText.Margin = new System.Windows.Forms.Padding(10);
            this.txtDecodedText.Multiline = true;
            this.txtDecodedText.Name = "txtDecodedText";
            this.txtDecodedText.ReadOnly = true;
            this.txtDecodedText.Size = new System.Drawing.Size(470, 120);
            this.txtDecodedText.TabIndex = 1;
            this.txtDecodedText.MouseEnter += new System.EventHandler(this.txtDecodedText_MouseEnter);
            this.txtDecodedText.MouseLeave += new System.EventHandler(this.txtDecodedText_MouseLeave);
            // 
            // tmrAutoClose
            // 
            this.tmrAutoClose.Interval = 30;
            this.tmrAutoClose.Tick += new System.EventHandler(this.tmrAutoClose_Tick);
            // 
            // pnlCloseTime
            // 
            this.pnlCloseTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCloseTime.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pnlCloseTime.Location = new System.Drawing.Point(0, 277);
            this.pnlCloseTime.Name = "pnlCloseTime";
            this.pnlCloseTime.Size = new System.Drawing.Size(482, 5);
            this.pnlCloseTime.TabIndex = 2;
            this.pnlCloseTime.MouseEnter += new System.EventHandler(this.pnlCloseTime_MouseEnter);
            this.pnlCloseTime.MouseLeave += new System.EventHandler(this.pnlCloseTime_MouseLeave);
            // 
            // QrCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(482, 282);
            this.Controls.Add(this.pnlCloseTime);
            this.Controls.Add(this.txtDecodedText);
            this.Controls.Add(this.pbScreenshot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QrCodeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "QrCode decoding";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseEnter += new System.EventHandler(this.QrCodeForm_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.QrCodeForm_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pbScreenshot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbScreenshot;
        private TextBox txtDecodedText;
        private System.Windows.Forms.Timer tmrAutoClose;
        private Panel pnlCloseTime;
    }
}