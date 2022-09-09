namespace TheTalosCompanion
{
    public partial class QrCodeForm : Form
    {
        public QrCodeForm()
        {
            InitializeComponent();

            var screenBounds = Screen.FromControl(this).Bounds;
            this.Location = new Point(
                screenBounds.Width - this.Width - 10,
                screenBounds.Height - this.Height - 10
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DecodeNewImage();
        }

        public void DecodeNewImage()
        {
            try
            {
                var screenshot = Clipboard.GetImage();

                if (screenshot != null)
                {
                    pbScreenshot.Image = screenshot;

                    txtDecodedText.Text = MLA.DecodeQrcode(new Bitmap(pbScreenshot.Image));
                }
            }
            catch
            {
                txtDecodedText.Text = "";
            }

            pnlCloseTime.Width = this.Width;
            tmrAutoClose.Start();
        }

        private void tmrAutoClose_Tick(object sender, EventArgs e)
        {
            pnlCloseTime.Width -= (int) Math.Floor(this.Width * 0.003);
            if (pnlCloseTime.Width <= 0) Close();
        }

        private void QrCodeForm_MouseEnter(object sender, EventArgs e)
        {
            tmrAutoClose.Stop();
        }

        private void QrCodeForm_MouseLeave(object sender, EventArgs e)
        {
            tmrAutoClose.Start();
        }

        private void txtDecodedText_MouseEnter(object sender, EventArgs e)
        {
            tmrAutoClose.Stop();
        }

        private void txtDecodedText_MouseLeave(object sender, EventArgs e)
        {
            tmrAutoClose.Start();
        }

        private void pbScreenshot_MouseEnter(object sender, EventArgs e)
        {
            tmrAutoClose.Stop();
        }

        private void pbScreenshot_MouseLeave(object sender, EventArgs e)
        {
            tmrAutoClose.Start();
        }

        private void pnlCloseTime_MouseEnter(object sender, EventArgs e)
        {
            tmrAutoClose.Stop();
        }

        private void pnlCloseTime_MouseLeave(object sender, EventArgs e)
        {
            tmrAutoClose.Start();
        }
    }
}