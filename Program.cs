using WGU.C969.SoftwareII.Tools;

namespace WGU.C969.SoftwareII
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
            DBConnection.StartConnection();
            Application.Run(new LoginForm());
            DBConnection.CloseConnection();
        }
    }
}