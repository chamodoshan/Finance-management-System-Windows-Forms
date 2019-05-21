using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialSystem
{
    public partial class UserRegisterView : Form
    {
        public UserRegisterView()
        {
            InitializeComponent();
        }

        BackgroundWorker bw;

        UserController UC = new UserController();
        private void Register(object sender, EventArgs e)
        {
            bw = new BackgroundWorker();
            bw.DoWork += (obj, ea) => RegisterTask(1);
            bw.RunWorkerAsync();
        }

        private void LoginView(object sender, EventArgs e)
        {
            UserLoginView view2 = new UserLoginView();
            this.Hide();
            view2.ShowDialog();
            this.Close();
        }

        private async void RegisterTask(int times)
        {
            string name = this.txt_name.Text;
            string email = this.txt_mail.Text;
            string password = this.txt_pass.Text;
            string conPassword = this.txt_con_pass.Text;

            UC.CreateUser(name, email, password, conPassword);
        }
    }
}
