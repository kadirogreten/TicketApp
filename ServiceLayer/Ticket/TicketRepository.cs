using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class TicketRepository
    {
        public static Ticket GetTicketById(int id)
        {
            string commandText= $"SELECT [Id],[UserId],[FirmId],[Title],[Description],[Detail] FROM [dbo].[Ticket] where [Id]={id}";
            var cmd = SqlConnectionExtension.ConnectToDb(commandText);

            SqlDataReader reader= cmd.ExecuteReader();
            Ticket ticket = new Ticket();

            while (reader.Read())
            {
                ticket = new Ticket
                {
                    Id = reader.GetInt32(0),
                    UserId = reader.GetInt32(1),
                    FirmId = reader.GetInt32(2),
                    Title = reader.GetString(3),
                    Description = reader.GetString(4),
                    Detail = reader.GetString(5)
                };
                
            }
            cmd.Connection.Close();
            cmd.Connection.Dispose();

            return ticket;

        }
    }
}
