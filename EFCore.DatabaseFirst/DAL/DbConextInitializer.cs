using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.DatabaseFirst.DAL
{
    public class DbConextInitializer
    {
        public static IConfigurationRoot Configuration; //Config Json Okuma 

        public static DbContextOptionsBuilder<AppDbContext> OptionsBuilder; //Sql verilerini okuma

        public static void Build()
        {
            var bulder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("AppSettings.json", optional: true, reloadOnChange: true);
            Configuration = bulder.Build();
            OptionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            OptionsBuilder.UseSqlServer(Configuration.GetConnectionString("SqlCon"));
        }
       

    }
}
