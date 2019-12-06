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

        public static List<Ticket> GetTickets()
        {
            string commandText = $"SELECT [Id],[UserId],[FirmId],[Title],[Description],[Detail] FROM [dbo].[Ticket]";

            var cmd = SqlConnectionExtension.ConnectToDb(commandText);

            SqlDataReader reader = cmd.ExecuteReader();

            Ticket ticket = new Ticket();
            List<Ticket> tickets = new List<Ticket>();

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

                tickets.Add(ticket);
            }
            cmd.Connection.Close();
            cmd.Connection.Dispose();


            return tickets;
        }
        public static int InsertTicket(Ticket ticket)
        {
            string commandText = $"INSERT INTO [dbo].[Ticket]([UserId],[FirmId],[Title],[Description],[Detail])VALUES('{ticket.UserId}','{ticket.FirmId}','{ticket.Title}','{ticket.Description}','{ticket.Detail}')";

            int data = 0;
            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd = SqlConnectionExtension.ConnectToDb(commandText);

                data = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Connection.Dispose();
            }

            return data;

        }
              

        
        public static int DeleteTicketById(int id)
        {
            string commandText = $"Delete FROM [dbo].[Ticket] where [Id]={id}";
            int data = 0;
            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd = SqlConnectionExtension.ConnectToDb(commandText);

                data = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Connection.Dispose();
            }

            return data;

        }

    }
}
