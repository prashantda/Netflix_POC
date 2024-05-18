using Microsoft.Extensions.Configuration;



namespace Bfl.Netflix.Core.Helpers
{
    public  class ConfigurationManager
    {
        public static IConfiguration AppSetting { get; }
        public static string CurrentPath { get; }
        static ConfigurationManager()
        {
            string path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @""));
            AppSetting = new ConfigurationBuilder().SetBasePath(path).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).Build();
            CurrentPath= path;
        }
    }
}

