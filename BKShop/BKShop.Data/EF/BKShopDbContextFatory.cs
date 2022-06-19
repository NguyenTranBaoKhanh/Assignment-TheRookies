using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKShop.Data.EF
{
    public class BKShopDbContextFatory : IDesignTimeDbContextFactory<BKShopDbContext>
    {
        public BKShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("Default");

            var optionsBuilder = new DbContextOptionsBuilder<BKShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new BKShopDbContext(optionsBuilder.Options);
        }
    }
}
