using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bfl.Netflix_Tv.Core.Helpers
{
    public class ConfigurationManager
    {
        public static IConfiguration AppSetting { get; }
        public static string CurrentPath { get; }
        static ConfigurationManager()
        {
            string path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @""));
            AppSetting = new ConfigurationBuilder().SetBasePath(path).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).Build();
            CurrentPath = path;
        }
    }
}
