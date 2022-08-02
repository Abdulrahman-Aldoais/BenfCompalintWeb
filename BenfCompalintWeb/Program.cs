using BenfCompalintWeb.Areas.AdminService.Service;
using BenfCompalintWeb.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BenfCompalintWeb
{
    public class Program
    {
        //public static void Main(string[] args)
        //{
        //    CreateHostBuilder(args).Build().Run();
        //}

        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            // Run Migration >> Update-Database
            using (var scope = host.Services.CreateScope())
            {
                var provider = scope.ServiceProvider;

                //var dbContext = provider.GetRequiredService<AppCompalintsContextDB>();

                //dbContext.Database.Migrate();




                var userService = provider.GetRequiredService<IUserService>();
                await userService.InitializeAsync();



                //Seed.

            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
