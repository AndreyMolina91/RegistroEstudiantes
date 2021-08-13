using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data
{
    public class ConfiguracionPostgreSQL
    {

        public ConfiguracionPostgreSQL(string connectionString) => ConnectionString = connectionString;

        public string ConnectionString { get; set; }
    }
}
