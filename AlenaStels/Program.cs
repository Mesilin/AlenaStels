using AlenaStels.Data;
using Microsoft.EntityFrameworkCore;

namespace AlenaStels
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

            using (var ctx = new DataContext())
            {
                ctx.Database.MigrateAsync().Wait();
            }
            Application.Run(new MainForm());
        }
    }
}