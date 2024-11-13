using fazenda_verdeviva.Forms;
using fazenda_verdeviva.UserControls;
using System.Text;

namespace fazenda_verdeviva
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            System.Globalization.CultureInfo cultura = new System.Globalization.CultureInfo("pt-BR");
            System.Threading.Thread.CurrentThread.CurrentCulture = cultura;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultura;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(MainForm.GetInstance());
        }
    }
}