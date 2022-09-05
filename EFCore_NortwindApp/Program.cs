using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using EFCore_NortwindDb;
using System;
using System.IO;

namespace EFCore_NortwindApp
{
    class Program
    {
        private static IConfigurationRoot Configuration; //unutk baca file json

        private static DbContextOptionsBuilder <NorthwindContext> optionsBuilder; //untuk koneksi ke sql server

        static void Main(string[] args) //pintu masuk ke aplikasi program
        {
            BuildConfiguration();
            Console.WriteLine($"ConnectionString : {Configuration.GetConnectionString("NorthwindDS")}");
            BuildOptions(); //harus di panggil dulu baru bisa ke panggil listcustomers nya
            ListCostumer();
        }
        static void BuildConfiguration()    //configurasi kefile json yang telah di buat
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json",optional:true,reloadOnChange:true);
            Configuration = builder.Build();
        }
        static void BuildOptions()
        {
            optionsBuilder = new DbContextOptionsBuilder<NorthwindContext>();
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("NorthwindDS"));
        }
        static void ListCostumer()
        {
            using(var db = new NorthwindContext(optionsBuilder.Options))
            {
                var customers = db.Customers.OrderByDescending(x => x.CompanyName).Take(10).ToList();
                int no = 1;
                foreach (var item in customers)
                {
                    Console.WriteLine($"{no}. {item.CompanyName} | {item.ContactName}");
                    no++;
                }
            }
        }
    }
}