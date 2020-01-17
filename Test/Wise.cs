using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using System.Text;
using Test.Models;

namespace Test
{
    public class Wise : WiseContext
    {
        public bool ConsoleLog;

        public Wise(bool consoleLog) : base() {
            this.ConsoleLog = consoleLog;
        }
        private ILoggerFactory GetLoggerFactory() {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging(builder =>
                   builder.AddConsole()
                          .AddFilter(DbLoggerCategory.Database.Command.Name,
                                     LogLevel.Information));
            return serviceCollection.BuildServiceProvider()
                    .GetService<ILoggerFactory>();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (ConsoleLog) {
                optionsBuilder.UseLoggerFactory(GetLoggerFactory())
                    .EnableSensitiveDataLogging().UseSqlServer(@"Server=atumai.database.windows.net; Database = Wise; Persist Security Info = False; Encrypt = True; TrustServerCertificate = False; User ID = atum; Password = TdwyNPTTZbLoy4Crf22t; ");
            } else {
                optionsBuilder.UseSqlServer(@"Server=atumai.database.windows.net; Database = Wise; Persist Security Info = False; Encrypt = True; TrustServerCertificate = False; User ID = atum; Password = TdwyNPTTZbLoy4Crf22t; ");

            }
        }
    }
}
