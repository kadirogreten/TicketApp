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
        public static Firm GetFirmById(int id)
        {
            string commandText = $"SELECT [Id],[FirmName],[Address],FROM [dbo].[Firm] where [Id]={id}";

            var cmd = SqlConnectionExtension.ConnectToDb(commandText);


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
    }
}
