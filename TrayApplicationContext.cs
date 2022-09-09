using TheTalosCompanion.Properties;

namespace TheTalosCompanion
{
    internal class TrayApplicationContext : ApplicationContext
    {
        private NotifyIcon _trayIcon;
        private GlobalKeyboardHook _globalKeyboardHook; 

        private QrCodeForm? _qrCodeForm = null;
        private HexDecodeForm? _hexDecodeForm = null;

        public TrayApplicationContext()
        {
            _trayIcon = new NotifyIcon()
            {
                Icon = Resources.AppIcon,
                ContextMenuStrip = _buildContextMenuStrip(),
                Visible = true
            };

            _globalKeyboardHook = new GlobalKeyboardHook(new Keys[] { Keys.PrintScreen, Keys.Insert });
            _globalKeyboardHook.KeyboardPressed += OnKeyPressed;

        }

        public ContextMenuStrip _buildContextMenuStrip()
        {
            ContextMenuStrip menuStrip = new ContextMenuStrip();

            ToolStripMenuItem exitItem = new ToolStripMenuItem("Exit", null, Exit);

            menuStrip.Items.Add(exitItem); 

            return menuStrip;
        }

        private void Exit(object? sender, EventArgs e)
        {
            _trayIcon.Visible = false;
            Application.Exit();
        }

        private void OnKeyPressed(object? sender, GlobalKeyboardHookEventArgs e)
        {
            if (e.KeyboardState == GlobalKeyboardHook.KeyboardState.KeyUp)
            {
                switch (e.KeyboardData.Key)
                {
                    case Keys.PrintScreen:
                        _handleQrCode();
                        e.Handled = true;
                        break;

                    case Keys.Insert:
                        _handleHexDecode();
                        e.Handled = true;
                        break;
                }
            }
        }

        private void _handleQrCode()
        {
            if (_qrCodeForm == null || _qrCodeForm.IsDisposed) _qrCodeForm = new QrCodeForm();
            if (!_qrCodeForm.Visible) 
                _qrCodeForm.Show();
            else
                _qrCodeForm.DecodeNewImage();
        }

        private void _handleHexDecode()
        {
            if (_hexDecodeForm == null || _hexDecodeForm.IsDisposed) _hexDecodeForm = new HexDecodeForm();
            if (!_hexDecodeForm.Visible) _hexDecodeForm.Show();
        }
    }
}
