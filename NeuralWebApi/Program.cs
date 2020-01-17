using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using NeuralWebApi.Singleton;

namespace NeuralWebApi
{
    public class Program
    {
        public static void Main(string[] args) {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => {
                    webBuilder.UseStartup<Startup>()
                        .UseKestrel(o => o.Limits.KeepAliveTimeout = TimeSpan.FromMinutes(10));
                });
    }
}
