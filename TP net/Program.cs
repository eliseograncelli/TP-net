using TP_net;

namespace Presentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new frmCliente());
=======
            Application.Run(new frmInicioSesion());
>>>>>>> e71980d82a7f8a63a0abfdc44239699255324571
        }
    }
}