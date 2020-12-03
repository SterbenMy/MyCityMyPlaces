using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;
namespace MyCityMyPlaces.Models
{
    public class AppDb
    {
        public string GetConnectionString()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            return builder.Build().GetSection("ConnectionStrings").GetSection("Con1").Value;
        }
    }

}