using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class ComplaintRepository
    {
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
                    Address = reader.GetString(6)
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
                    Address = reader.GetString(6)
                };

                complaints.Add(complaint);
            }
            cmd.Connection.Close();
            cmd.Connection.Dispose();

            return complaints;
        }


        //Şikayeti sil. Her üç tablodaki ilgili satırı sil.
        public static int DeleteComplaintById(int id)
        {
            int data = 0;
            return data;
        }

        public static List<Complaint> OrderByComplaint()
        {
            //username göre sıralama
            string commandText = $"SELECT [Ticket.Title],[Ticket.Description],[Ticket.Detail]," +
                $"[Firm.FirmName],[Firm.Address],[User.Name],[User.Surname] FROM [dbo].[Ticket] inner join [dbo].[Firm] on [Ticket.FirmId]=[Firm.Id]" +
                $" inner join [dbo].[User] on [Ticket.UserId]=[User.Id] order by [User.Name]";

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
                    Address = reader.GetString(6)
                };

                complaints.Add(complaint);
            }
            cmd.Connection.Close();
            cmd.Connection.Dispose();

            return complaints;
        }
        public static List<Complaint> OrderByFirmName()
        {
            //firmname göre sıralama
            string commandText = $"SELECT [Ticket.Title],[Ticket.Description],[Ticket.Detail]," +
                $"[Firm.FirmName],[Firm.Address],[User.Name],[User.Surname] FROM [dbo].[Ticket] inner join [dbo].[Firm] on [Ticket.FirmId]=[Firm.Id]" +
                $" inner join [dbo].[User] on [Ticket.UserId]=[User.Id] order by [Firm.FirmName]";

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
                    Address = reader.GetString(6)
                };

                complaints.Add(complaint);
            }
            cmd.Connection.Close();
            cmd.Connection.Dispose();

            return complaints;
        }

        public static List<Complaint> OrderByTitle()
        {
            //tittle göre sıralama
            string commandText = $"SELECT [Ticket.Title],[Ticket.Description],[Ticket.Detail]," +
                $"[Firm.FirmName],[Firm.Address],[User.Name],[User.Surname] FROM [dbo].[Ticket] inner join [dbo].[Firm] on [Ticket.FirmId]=[Firm.Id]" +
                $" inner join [dbo].[User] on [Ticket.UserId]=[User.Id] order by [Ticket.Title]";

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
                    Address = reader.GetString(6)
                };

                complaints.Add(complaint);
            }
            cmd.Connection.Close();
            cmd.Connection.Dispose();

            return complaints;
        }


    }
}
