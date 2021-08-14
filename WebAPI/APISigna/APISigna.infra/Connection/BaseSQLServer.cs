using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace APISigna.infra.Connection
{
    public class BaseSQLServer : DbContext
    {
        private string ConnectionString { get; set; }

        public BaseSQLServer(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                                   .AddJsonFile("appsettings.json")
                                                   .Build();

            var connectionString = new SqlConnectionStringBuilder(config.GetConnectionString(ConnectionString))
            {
                Pooling = true,
                MinPoolSize = 3,
                MaxPoolSize = 6,
            }.ConnectionString;

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
