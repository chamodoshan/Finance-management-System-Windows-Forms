using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FinancialSystem
{
    class PayeeAndPayerViewController
    {
        //private DBFinancialSystem database = new DBFinancialSystem();
        PayeeAndPayer pp = new PayeeAndPayer();

        public void CreatePayeeOrPayer(string name,string address, string contact_num, string email, string payment_method, string person)
        {
            Console.WriteLine(payment_method);
            /* DBFinancialSystem.PayeeAndPayerTableRow newRow = grid.PayeeAndPayerTable.NewPayeeAndPayerTableRow();
             newRow.Name = name;
             newRow.Address = address;
             newRow.ContactNumber = contact_num;
             newRow.Email = email;
             newRow.PaymentMethod = payment_method;
             newRow.Person = Convert.ToString(person);
             //newRow.Id = id;

             grid.PayeeAndPayerTable.AddPayeeAndPayerTableRow(newRow);
             grid.PayeeAndPayerTable.AcceptChanges();

             string x = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
             this.database.WriteXml(x + "\\cw.xml");*/
            if (IsEmpty(name) || IsEmpty(address) || IsEmpty(contact_num) || IsEmpty(email) || IsEmpty(payment_method))
            {
                System.Windows.Forms.MessageBox.Show("Some Fields are Empty !!!" , "Error");
            } else if (!IsNumbersOnly(contact_num))
            {
                System.Windows.Forms.MessageBox.Show("Contact Number is Invalid !!!", "Error");
            } else if (!IsEmailValid(email))
            {
                System.Windows.Forms.MessageBox.Show("Email is Invalid !!!", "Error");

            }
            else
            {
                name =Uppercase(name);
                address = Uppercase(address);
                pp.CreateNewPayeeOrPayer(name, address, contact_num, email, payment_method, person);
            }

        }

        bool IsEmailValid(string email)
        {
            try
            {
                var email_address = new System.Net.Mail.MailAddress(email);
                return email_address.Address == email;
            }
            catch
            {
                return false;
            }
        }

        bool IsNumbersOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
                    
            }

            return true;
        }

        bool IsEmpty(string str)
        {
            if(str == "")
            {
                return true;
            }

            return false;
        }

        string Uppercase(string str)
        {
           
            return str.First().ToString().ToUpper() + str.Substring(1);
           
        }

        public void Clear()
        {
            PayeePayerDetailsView PPDV = new PayeePayerDetailsView();
            PPDV.Clear();
        }

        public DataTable GetPayeePayer()
        {
            return pp.GetPayeePayer();
        }

        public void UpdatePayeePayer(DataTable dataTb)
        {
            pp.UpdatePayeePayer(dataTb);
        }

    }
}
