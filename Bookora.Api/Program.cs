//==================================================
// Copyright (c) Bookora Project
// Powered by The Standard by Hassan Habib
// Manage Your Library Smarter
//==================================================
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Bookora.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
