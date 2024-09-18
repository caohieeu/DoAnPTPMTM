using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace ProjectPTUDTM
{
	internal static class Program
	{
        public static IConfiguration _Configuration { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
		static void Main()
		{
            string s = Directory.GetCurrentDirectory();
            DirectoryInfo directory = Directory.GetParent(s).Parent?.Parent;
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var builder = new ConfigurationBuilder()
    .SetBasePath(directory.FullName)
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            _Configuration = builder.Build();

            Application.Run(new MainForm());
		}
	}
}