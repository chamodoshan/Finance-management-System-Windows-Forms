using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialSystem
{
    class UserController
    {
        Users user = new Users();
        public void CreateUser(string name, string email, string password, string conPassword)
        {
            if (IsEmpty(name) || IsEmpty(email) || IsEmpty(password) || IsEmpty(conPassword))
            {
                System.Windows.Forms.MessageBox.Show("Some Fields are Empty !!!", "Error");
            }
            else if (!IsMatch(password, conPassword))
            {
                System.Windows.Forms.MessageBox.Show("Password Does not Match !!!", "Error");
            }
            else if (!IsEmailValid(email))
            {
                System.Windows.Forms.MessageBox.Show("Email is Invalid !!!", "Error");

            }
            else
            {
                name = Uppercase(name);
                user.CreateUser(name, email, password);
            }
        }

        public Boolean Login(string email, string pass)
        {
            if (!IsEmailValid(email))
            {
                System.Windows.Forms.MessageBox.Show("Email is Invalid !!!", "Error");
                return false;
            }
            else
            {
               Boolean value = user.Login(email, pass);
                return value;
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

        bool IsEmpty(string str)
        {
            if (str == "")
            {
                return true;
            }

            return false;
        }

        bool IsMatch(string pass, string conPass)
        {
            if (pass == conPass)
            {
                return true;
            }

            return false;
        }

        string Uppercase(string str)
        {

            return str.First().ToString().ToUpper() + str.Substring(1);

        }
    }
}
