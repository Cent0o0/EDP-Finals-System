using Barangay_E_Service_System;
using Barangay_E_Service_System.DATA;
using Barangay_E_Service_System.DATA.Barangay_E_Service_System.DATA;
namespace Barangay_E_Service_System
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

            UserSession.ClearSession();

            Application.Run(new MainForm());
        }
    }
}