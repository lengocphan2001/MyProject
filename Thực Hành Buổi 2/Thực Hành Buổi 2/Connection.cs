using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thực_Hành_Buổi_2
{
    class Connection
    {
        string connectionString = "";
        public Connection()
        {
            connectionString = "Data Source = PHAN; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
        }
        public string getConnectionString()
        {
            return connectionString;
        }
    }
}
