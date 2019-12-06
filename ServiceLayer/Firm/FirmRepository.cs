using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class FirmRepository
    {
        //Firm ID sini getiren sorgu methodu
        public static Firm GetFirmById(int id)
        {
            //Firmanın id si ile firmanın tüm bilgileri sorgulandı.
            string commandText = $"SELECT [Id],[FirmName],[Address],FROM [dbo].[Firm] where [Id]={id}";
            //sqlconnectionextension helper ile db bağlantısı sağlandı.
            var cmd = SqlConnectionExtension.ConnectToDb(commandText);
            //reader ile ile sorgu okuması yapıldı.
            SqlDataReader reader = cmd.ExecuteReader();

            Firm firm = new Firm();

            while (reader.Read())
            {
                firm = new Firm
                {
                    Id = reader.GetInt32(0),
                    FirmName = reader.GetString(1),
                    Address = reader.GetString(2),
                };

            }
            cmd.Connection.Close();
            cmd.Connection.Dispose();
            return firm;
        }


        //Firm yı getiren sorgu methodu
        public static List<Firm> GetFirms()
        {
            string commandText = $"SELECT [Id],[FirmName],[Address], FROM [dbo].[Firm]";

            var cmd = SqlConnectionExtension.ConnectToDb(commandText);

            SqlDataReader reader = cmd.ExecuteReader();

            Firm firm = new Firm();
            List<Firm> firms = new List<Firm>();

            while (reader.Read())
            {
                firm = new Firm
                {
                    Id = reader.GetInt32(0),
                    FirmName = reader.GetString(1),
                    Address = reader.GetString(2),
                };

                firms.Add(firm);
            }
            cmd.Connection.Close();
            cmd.Connection.Dispose();
            return firms;
        }

        //firm a insert metodu eklendi.
        public static int InsertFirm(Firm firm)
        {
            string commandText = $"INSERT INTO [dbo].[Firm]([FirmName],[Address])VALUES('{firm.FirmName}','{firm.Address}')";

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

        public static int DeleteFirmById(int id)
        {
            string commandText = $"Delete FROM [dbo].[Firm] where [Id]={id}";
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
