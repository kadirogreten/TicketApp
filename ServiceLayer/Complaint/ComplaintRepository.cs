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
                $"[Firm.FirmName],[Firm.Address],[User.Name],[User.Surname],[User.Phone] FROM [dbo].[Ticket] inner join [dbo].[Firm] on [Ticket.FirmId]=[Firm.Id]" +
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
                    Address = reader.GetString(4),
                    UserName = reader.GetString(5),
                    UserSurName = reader.GetString(6),
                    UserPhone=reader.GetString(7)
                };

            }
            cmd.Connection.Close();
            cmd.Connection.Dispose();

            return complaint;

        }

        //bütün şikayetleri firma adı ve şikayet sahibi ile birlikte listelemek için metod (inner join)
        public static List<Complaint> GetComplaints()
        {
            string commandText = $"SELECT t.Title,t.Description,t.Detail,f.FirmName,f.Address,u.Name,u.Surname,u.Phone FROM [dbo].[Ticket] t" +
                $" inner join [dbo].[Firm] f on t.FirmaId = f.Id" +
                $" inner join [dbo].[User] u on t.UserId = u.Id";

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
                    Address = reader.GetString(4),
                    UserName = reader.GetString(5),
                    UserSurName = reader.GetString(6),
                    UserPhone = reader.GetString(7)

                    
                };

                complaints.Add(complaint);
            }
            cmd.Connection.Close();
            cmd.Connection.Dispose();

            return complaints;
        }

        public static List<Complaint> GetComplaintsByFirmName(string firm_name)
        {
            string commandText = $"SELECT t.Title,t.Description,t.Detail,f.FirmName,f.Address,u.Name,u.Surname,u.Phone FROM [dbo].[Ticket] t" +
                $" inner join [dbo].[Firm] f on t.FirmaId = f.Id" +
                $" inner join [dbo].[User] u on t.UserId = u.Id where f.FirmName= '{firm_name}'";

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
                    Address = reader.GetString(4),
                    UserName = reader.GetString(5),
                    UserSurName = reader.GetString(6),
                    UserPhone = reader.GetString(7)


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

        public static List<Complaint> OrderComplaintsByUserName()
        {
            //username göre sıralama
            string commandText = $"SELECT Ticket.Title,Ticket.Description,Ticket.Detail, Firm.FirmName,Firm.Address,[dbo].[User].Name,[dbo].[User].Surname,[dbo].[User].Phone FROM[dbo].[Ticket] inner join[dbo].[Firm] on Ticket.FirmaId=Firm.Id inner join[dbo].[User] on Ticket.UserId=[dbo].[User].Id order by [dbo].[User].Name";

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
                    Address = reader.GetString(4),
                    UserName = reader.GetString(5),
                    UserSurName = reader.GetString(6),
                    UserPhone = reader.GetString(7)
                };

                complaints.Add(complaint);
            }
            cmd.Connection.Close();
            cmd.Connection.Dispose();

            return complaints;
        }
        public static List<Complaint> OrderComplaintsByFirmName()
        {
            //firmname göre sıralama
            string commandText = $"SELECT Ticket.Title,Ticket.Description,Ticket.Detail," +
                $"Firm.FirmName,Firm.Address,[dbo].[User].Name,[dbo].[User].Surname,[dbo].[User].Phone FROM[dbo].[Ticket] inner join[dbo].[Firm] on Ticket.FirmaId=Firm.Id inner join[dbo].[User] on Ticket.UserId=[dbo].[User].Id order by Firm.FirmName";


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
                    Address = reader.GetString(4),
                    UserName = reader.GetString(5),
                    UserSurName = reader.GetString(6),
                    UserPhone = reader.GetString(7)
                };

                complaints.Add(complaint);
            }
            cmd.Connection.Close();
            cmd.Connection.Dispose();

            return complaints;
        }

        public static List<Complaint> OrderComplaintsByTitle()
        {
            //tittle göre sıralama
            string commandText = $"SELECT Ticket.Title,Ticket.Description,Ticket.Detail," +
                $"Firm.FirmName,Firm.Address,[dbo].[User].Name,[dbo].[User].Surname,[dbo].[User].Phone FROM[dbo].[Ticket] inner join[dbo].[Firm] on Ticket.FirmaId=Firm.Id inner join[dbo].[User] on Ticket.UserId=[dbo].[User].Id order by Ticket.Title";

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
                    Address = reader.GetString(4),
                    UserName = reader.GetString(5),
                    UserSurName = reader.GetString(6),
                    UserPhone = reader.GetString(7)
                };

                complaints.Add(complaint);
            }
            cmd.Connection.Close();
            cmd.Connection.Dispose();

            return complaints;
        }


    }
}
