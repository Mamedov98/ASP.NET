using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetHomework2.Service
{
    internal class DbConfigService
    {
        private readonly ConfigurationBuilder _configBuilder;
        private readonly string _tableName;
        public DbConfigService(string TableName)

        {
            _tableName = TableName;
            _configBuilder = new ConfigurationBuilder();
            _configBuilder.AddJsonFile("appsettings.json");

        }

        public string? GetConnectionString()
        {
            IConfiguration config= _configBuilder.Build();

            return config.GetConnectionString(_tableName);
        }

    }
}
