using System;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace quanlythongtinkhachhang
{
    internal static class Program
    {
        [STAThread] // Ensure the application runs in a single-threaded apartment state
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormQLKH());
        }
    }
}