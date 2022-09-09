namespace TheTalosCompanion
{
    public partial class HexDecodeForm : Form
    {
        public HexDecodeForm()
        {
            InitializeComponent();

            var screenBounds = Screen.FromControl(this).Bounds;
            this.Location = new Point(
                screenBounds.Width - this.Width - 10,
                screenBounds.Height - this.Height - 10
            );

            txtHexInput.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtHexInput_TextChanged(object sender, EventArgs e)
        {
            lblDecodedText.Text = MLA.DecodeHex(txtHexInput.Text);
        }
    }
}
