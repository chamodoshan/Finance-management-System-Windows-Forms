using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FinancialSystem
{
    class PayeeAndPayer
    {
        SqlDataAdapter dataAd;
        SqlCommandBuilder commandBuilder;
        DataTable data;
        public void CreateNewPayeeOrPayer(string name, string address, string contact_num, string email, string payment_method, string person)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;database=FinancialDB;Integrated Security=SSPI"))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;      
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT into payee_and_payer (name, address, contact_number, email, payment_method, person) VALUES (@name, @address, @contact_number, @email, @payment_method, @person)";
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@contact_number", contact_num);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@payment_method", payment_method);
                    command.Parameters.AddWithValue("@person", person);

                    try
                    {
                        connection.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                        System.Windows.Forms.MessageBox.Show("Success !", "Message");
                        PayeeAndPayerViewController CPP = new PayeeAndPayerViewController();
                        CPP.Clear();
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

        public List<string> GetPayeeAndPayer()
        {
            List<string> rows = new List<string>();
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;database=FinancialDB;Integrated Security=SSPI"))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT * FROM payee_and_payer ORDER BY person";

                    try
                    {
                        connection.Open();
                        
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                               
                                 rows.Add(Reader.GetInt32(0).ToString() + " - " + Reader.GetString(1) + " - " + Reader.GetString(6));
                            }

                            
                            return rows;
                        }

                    }
                    catch (SqlException e)
                    {
                        Console.Write("Error - "+e);
                        System.Windows.Forms.MessageBox.Show("Fail !!! - " + Convert.ToString(e), "Error");
                        return rows;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        /*public List<string> GetPayeeAndPayer1()
        {
            List<string> rows = new List<string>();
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;database=FinancialDB;Integrated Security=SSPI"))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT * FROM payee_and_payer";

                    try
                    {
                        connection.Open();

                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {

                                rows.Add(Reader.GetInt32(0).ToString() + " - " + Reader.GetString(1) + " - " + Reader.GetString(6));
                            }


                            return rows;
                        }

                    }
                    catch (SqlException e)
                    {
                        Console.Write("Error - " + e);
                        System.Windows.Forms.MessageBox.Show("Fail !!! - " + Convert.ToString(e), "Error");
                        return rows;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }*/


        public DataTable GetPayeePayer()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;database=FinancialDB;Integrated Security=SSPI");
            dataAd = new SqlDataAdapter("SELECT * FROM payee_and_payer",connection);
            data = new DataTable();
            dataAd.Fill(data);
            return data;
        }

        public void UpdatePayeePayer(DataTable dataTb)
        {
            commandBuilder = new SqlCommandBuilder(dataAd);
            dataAd.Update(dataTb);
            System.Windows.Forms.MessageBox.Show("Success !", "Message");
        }
    }
    
}
