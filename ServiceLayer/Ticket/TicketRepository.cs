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

        //Herhangi bir şikayeti şikayet sahibi ve firma adı ile birlikte ticket Id'sine göre getirmek için metot (inner join)
        public static Complaint GetComplaintById(int id)
        {
            string commandText = $"SELECT [Ticket.Title],[Ticket.Description],[Ticket.Detail]," +
                $"[Firm.FirmName],[Firm.Address],[User.Name],[User.Surname] FROM [dbo].[Ticket] inner join [dbo].[Firm] on [Ticket.FirmId]=[Firm.Id]" +
                $" inner join [dbo].[User] on [Ticket.UserId]=[User.Id] where [Ticket.Id]={id}";
            var cmd = SqlConnectionExtension.ConnectToDb(commandText);

            SqlDataReader reader = cmd.ExecuteReader();
            Complaint complaint = new Complaint();

            while (reader.Read())
            {
                complaint = new Complaint
                {
                    Title = reader.GetString(0),
                    Description = reader.GetString(1),
                    Detail = reader.GetString(2),
                    FirmName = reader.GetString(3),
                    UserName = reader.GetString(4),
                    UserSurName = reader.GetString(5),
                    Address= reader.GetString(6)
                };

            }
            cmd.Connection.Close();
            cmd.Connection.Dispose();

            return complaint;

        }


        //bütün şikayetleri firma adı ve şikayet sahibi ile birlikte listelemek için metod (inner join)
        public static List<Complaint> GetComplaints()
        {
            string commandText = $"SELECT [Ticket.Title],[Ticket.Description],[Ticket.Detail]," +
                $"[Firm.FirmName],[Firm.Address],[User.Name],[User.Surname] FROM [dbo].[Ticket] inner join [dbo].[Firm] on [Ticket.FirmId]=[Firm.Id]" +
                $" inner join [dbo].[User] on [Ticket.UserId]=[User.Id]";

            var cmd = SqlConnectionExtension.ConnectToDb(commandText);

            SqlDataReader reader = cmd.ExecuteReader();

            Complaint complaint = new Complaint();
            List<Complaint> complaints = new List<Complaint>();

            while (reader.Read())
            {
                complaint = new Complaint
                {
                    Title = reader.GetString(0),
                    Description = reader.GetString(1),
                    Detail = reader.GetString(2),
                    FirmName = reader.GetString(3),
                    UserName = reader.GetString(4),
                    UserSurName = reader.GetString(5),
                    Address=reader.GetString(6)
                };

                complaints.Add(complaint);
            }
            cmd.Connection.Close();
            cmd.Connection.Dispose();


            return complaints;
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
