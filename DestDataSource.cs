using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkypeHistoryExporter
{
 

    [Serializable()]
    public class DestDataSource
    {
        string connectionString;
        string dataSourceName;

        public string ConnectionString { get; set; }
        public object DataSourceName { get; set; }

        public DestDataSource(string conString, string sourceName)
        {
            connectionString = conString;
            dataSourceName = sourceName;
        }
    }
}

