using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public static class ConnectionHelper
    {
        private static string connectionString =@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Ticket.DataAccessLayer;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";

        public static string ConnectionString
        {
            get { return connectionString; }
        }

    }
}
