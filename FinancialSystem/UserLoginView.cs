using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialSystem
{
    public partial class UserLoginView : Form
    {
        UserController UC = new UserController();
        public UserLoginView()
        {
            InitializeComponent();
        }


        public Boolean login = false;
        private void Login(object sender, EventArgs e)
        {
            loading.Visible = true;
            loading.Dock = DockStyle.Fill;
            backgroundWorker1.RunWorkerAsync();
        }

        private void RegisterView(object sender, EventArgs e)
        {
            UserRegisterView view = new UserRegisterView();
            this.Hide();
            view.ShowDialog();
            this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string email = this.txt_mail.Text;
            string pass = this.txt_pass.Text;

            Thread.Sleep(1000);
            Boolean value = UC.Login(email, pass);

            if (value)
            {
                login = true;
                
            }
            else
            {
                login = false;
            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (login)
            {
                MenuView view = new MenuView();
                this.Hide();
                view.ShowDialog();
                this.Close();
            }
            else
            {
                loading.Visible = false;
            }
        }
    }
}
