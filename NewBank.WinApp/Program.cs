using System.Globalization;
using NewBank.Dominio.Resources;

namespace NewBank.WinApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            // Obter a cultura do sistema
            CultureInfo systemCulture = CultureInfo.CurrentUICulture;

            // Definir a cultura atual do thread para a cultura do sistema
            Thread.CurrentThread.CurrentUICulture = systemCulture;
            Thread.CurrentThread.CurrentCulture = systemCulture;

            
            ApplicationConfiguration.Initialize();
            Application.Run(new TelaPrincipalForm());
        }
    }
}