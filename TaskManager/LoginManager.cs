using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Data;

namespace TaskManager
{
    static public class LoginManager
    {
        static MD5 md5;
        static public bool Login(string username, string password, SqlConnection connection)
        {
            string password_hash = GetMD5(password);
            try
            {
                string sqlQuery = @"select * from Users where [Login] = @p1";
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                cmd.Parameters.Add("@p1", SqlDbType.NVarChar).Value = username;
                SqlDataReader reader = cmd.ExecuteReader();
                bool tg = false;
                
                while (reader.Read())
                {
                    Console.WriteLine(password_hash);
                    if (reader["Password"].ToString() == password_hash)
                    {
                        tg = true;
                        break;
                    }
                } 
                connection.Close();
                return tg;
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                connection.Close();
                return false;
            }

        }
        static private string GetMD5(string text)
        {
            if(md5== null)
                md5 = MD5.Create();

            byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(text));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sBuilder.Append(hash[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}
