using System.Runtime.InteropServices;

namespace TheTalosCompanion
{
    internal static class Program
    {        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TrayApplicationContext());
        }
    }
}