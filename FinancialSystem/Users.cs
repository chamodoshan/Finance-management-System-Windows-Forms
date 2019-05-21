using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FinancialSystem
{
    class Users
    {
        public void CreateUser(string name, string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;database=FinancialDB;Integrated Security=SSPI"))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT into users (user_name, email, password) VALUES (@name, @email, @pass)";
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@pass", password);

                    try
                    {
                        connection.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                        System.Windows.Forms.MessageBox.Show("Success !", "Message");
                    }
                    catch (SqlException e)
                    {
                        System.Windows.Forms.MessageBox.Show("Fail !!! - " + Convert.ToString(e), "Error");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        public Boolean Login(string email, string pass)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;database=FinancialDB;Integrated Security=SSPI"))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT * FROM users";

                    try
                    {
                        connection.Open();

                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                if (Reader.GetString(2)== email && Reader.GetString(3)== pass)
                                {
                                    
                                    return true;
                                }
                                else
                                {
                                    //System.Windows.Forms.MessageBox.Show("Login Fail !!! - ", "Error");
                                }
                                  
                            }
                            return false;

                        }

                    }
                    catch (SqlException e)
                    {
                        Console.Write("Error - " + e);
                        System.Windows.Forms.MessageBox.Show("Login Fail !!! - " + Convert.ToString(e), "Error");
                        return false;
                    }
                    finally
                    {
                        connection.Close();
                        
                    }
                }
            }
        }

    }
}
