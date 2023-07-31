using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodFiestaAPI.Persistence
{
    static class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "C:/Users/mucah/OneDrive/Masaüstü/FoodFiesta/FoodFiestaAPI/Presentation/FoodFiestaAPI.API"));
                configurationManager.AddJsonFile("appsettings.json");
                string myConnectionString = configurationManager.GetConnectionString("SQLServer")!;
                return myConnectionString!;
            }
        }
    }
}
