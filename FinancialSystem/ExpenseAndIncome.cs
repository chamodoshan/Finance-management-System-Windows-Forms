using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace FinancialSystem
{
    class ExpenseAndIncome
    {
        Boolean check = false;
        SqlDataAdapter dataAd;
        SqlCommandBuilder commandBuilder;
        DataTable data;
        List<ExpensesAndIncomes> readElement = new List<ExpensesAndIncomes>();
        XmlSerializer xs;
        public void CreateExpenseOrIncome(List<List<string>> data)
        {
            for (int i = 0; i < data.Count; i++)
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;database=FinancialDB;Integrated Security=SSPI"))
                {
                
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "INSERT into expense_and_income (amount, reason, date, payee_or_payer_id, expense_or_income) VALUES (@amount, @reason, @date, @payeepayer, @expenseincome)";
                        command.Parameters.AddWithValue("@amount", data[i][0]);
                        command.Parameters.AddWithValue("@reason", data[i][1]);
                        command.Parameters.AddWithValue("@date", DateTime.Parse(data[i][2]));
                        command.Parameters.AddWithValue("@payeepayer",data[i][3]);
                        command.Parameters.AddWithValue("@expenseincome", data[i][4]);

                        try
                        {
                            connection.Open();
                            int recordsAffected = command.ExecuteNonQuery();
                            check = true;

                        }
                        catch (SqlException e)
                        {
                            Console.WriteLine(e);
                            System.Windows.Forms.MessageBox.Show("Fail !!! - "+ Convert.ToString(e), "Error");
                            break;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }

            }

            if (check)
            {
                System.Windows.Forms.MessageBox.Show("Success !","Message");
            }

        }

        public List<List<string>> GetExpenseIncomeDataInDateRange()
        {

            List<string> amount = new List<string>();
            List<string> date = new List<string>();
            List<string> type = new List<string>();
            List<List<string>> data = new List<List<string>>();
            DateTime now = DateTime.Now;
            string today = now.ToString("yyyy/M/d");
            string start = new DateTime(now.Year, now.Month, 1).ToString("yyyy/M/d");
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;database=FinancialDB;Integrated Security=SSPI"))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT * FROM expense_and_income WHERE date between '" + DateTime.Parse(start) + "' And '" + DateTime.Parse(today) + "'";

                    try
                    {
                        connection.Open();

                        using (SqlDataReader Reader = command.ExecuteReader())
                        {       
                            while (Reader.Read())
                            {
                                amount.Add(Reader.GetString(1));
                                date.Add(Reader.GetDateTime(3).ToString());
                                type.Add(Reader.GetString(5));
                            }

                            for (int i = 0; i < amount.Count; i++)
                            {
                                List<string> temp = new List<string>();
                                temp.Add(amount[i]);
                                temp.Add(date[i]);
                                temp.Add(type[i]);
                                data.Add(temp);

                            }

                            return data;
                        }

                    }
                    catch (SqlException e)
                    {
                        Console.Write("Error - " + e);
                        System.Windows.Forms.MessageBox.Show("Fail !!! - " + Convert.ToString(e), "Error");
                        return data;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        public List<List<string>> GetExpenseIncomeData(string date)
        {

            List<string> amount = new List<string>();
            List<string> type = new List<string>();
            List<List<string>> data = new List<List<string>>();
           
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;database=FinancialDB;Integrated Security=SSPI"))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT * FROM expense_and_income WHERE date = '" + DateTime.Parse(date) + "'"; 

                    try
                    {
                        connection.Open();

                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                amount.Add(Reader.GetString(1));
                                type.Add(Reader.GetString(5));
                            }

                            for (int i = 0; i < amount.Count; i++)
                            {
                                List<string> temp = new List<string>();
                                temp.Add(amount[i]);
                                temp.Add(type[i]);
                                data.Add(temp);

                            }

                            return data;
                        }

                    }
                    catch (SqlException e)
                    {
                        Console.Write("Error - " + e);
                        System.Windows.Forms.MessageBox.Show("Fail !!! - " + Convert.ToString(e), "Error");
                        return data;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        public void CreateExpenseOrIncomeXml(List<List<string>> data)
        {
            ReadXml();

            int count = readElement.Count();
            int id = 0;
            if (count != 0)
            {
                id = int.Parse(readElement[count-1].Id);
            }

            List<ExpensesAndIncomes> elements = new List<ExpensesAndIncomes>();


            string path = "D:\\work/4th Year/Enterprise/Courseworks/FinancialSystem v0.3/FinancialSystem/XMLDB.xml";
          
            xs = new XmlSerializer(typeof(List<ExpensesAndIncomes>));
            StreamWriter writer = new StreamWriter(path);

            for (int i = 0; i < data.Count; i++)
            {
                ExpensesAndIncomes ss = new ExpensesAndIncomes();
                id++;
                ss.Id = id.ToString();
                ss.Amount = data[i][0];
                ss.Reason = data[i][1];
                ss.Date = data[i][2];
                ss.PayeePayer = data[i][3];
                ss.Type = data[i][4];
                elements.Add(ss);
            }

            var combined = readElement.Concat(elements).ToList();
            xs.Serialize(writer, combined);

        }
        public void ReadXml()
        {

            string path = "D:\\work/4th Year/Enterprise/Courseworks/FinancialSystem v0.3/FinancialSystem/XMLDB.xml";
            StreamReader read = new StreamReader(path);
            xs = new XmlSerializer(typeof(List<ExpensesAndIncomes>));
            //xs.Deserialize(read);
            readElement = (List<ExpensesAndIncomes>)xs.Deserialize(read);
            read.Close();

        }

        public DataTable GetExpenseIncome()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;database=FinancialDB;Integrated Security=SSPI");
            dataAd = new SqlDataAdapter("SELECT * FROM expense_and_income", connection);
            data = new DataTable();
            dataAd.Fill(data);
            return data;
        }

        public List<ExpensesAndIncomes> GetExpenseIncomeXml()
        {
            string path = "D:\\work/4th Year/Enterprise/Courseworks/FinancialSystem v0.3/FinancialSystem/XMLDB.xml";
            StreamReader read = new StreamReader(path);
            xs = new XmlSerializer(typeof(List<ExpensesAndIncomes>));
            //xs.Deserialize(read);
            readElement = (List<ExpensesAndIncomes>)xs.Deserialize(read);
            read.Close();
            return readElement;
        }

        public void UpdateExpenseIncome(DataTable dataTb)
        {
            commandBuilder = new SqlCommandBuilder(dataAd);
            dataAd.Update(dataTb);
            System.Windows.Forms.MessageBox.Show("Success !", "Message");
        }
    }

    public class ExpensesAndIncomes
    {
        public string Id { get; set; }
        public string Amount { get; set; }
        public string Reason { get; set; }
        public string Date { get; set; }
        public string PayeePayer { get; set; }
        public string Type { get; set; }
    }
}
