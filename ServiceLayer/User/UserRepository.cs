using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class UserRepository
    {
        public static User GetUserById(int id)
        {
            string commandText = $"SELECT [Id],[Name],[Surname],[Phone],[IsActive]FROM [dbo].[User] where [Id]={id}";

            var cmd = SqlConnectionExtension.ConnectToDb(commandText);


            SqlDataReader reader = cmd.ExecuteReader();

            User user = new User();

            while (reader.Read())
            {
                user = new User
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Surname = reader.GetString(2),
                    Phone = reader.GetString(3),
                    IsActive = reader.GetBoolean(4)
                };


                

            }
            cmd.Connection.Close();
            cmd.Connection.Dispose();


            return user;
        }


        public static List<User> GetUsers()
        {
            string commandText = $"SELECT [Id],[Name],[Surname],[Phone],[IsActive]FROM [dbo].[User]";

            var cmd = SqlConnectionExtension.ConnectToDb(commandText);

            SqlDataReader reader = cmd.ExecuteReader();

            User user = new User();
            List<User> users = new List<User>();

            while (reader.Read())
            {
                user = new User
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Surname = reader.GetString(2),
                    Phone = reader.GetString(3),
                    IsActive = reader.GetBoolean(4)
                };

                users.Add(user);




            }
            cmd.Connection.Close();
            cmd.Connection.Dispose();


            return users;
        }


        public static int InsertUser(User user)
        {
            string commandText = $"INSERT INTO [dbo].[User]([Name],[Surname],[Phone],[IsActive])VALUES('{user.Name}','{user.Surname}','{user.Phone}',1)";

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
