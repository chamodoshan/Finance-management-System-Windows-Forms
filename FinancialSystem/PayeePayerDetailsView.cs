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
    public partial class PayeePayerDetailsView : Form
    {
        //private DBFinancialSystem database = new DBFinancialSystem();
        PayeeAndPayerViewController CPP = new PayeeAndPayerViewController();
        public PayeePayerDetailsView()
        {
            InitializeComponent();
            //CPP.Load();
        }

        private void SavePayeeOrPayer(object sender, EventArgs e)
        {
            string name = this.txt_name.Text;
            string address = this.txt_add.Text;
            string contact_num = this.txt_num.Text;
            string email = this.txt_email.Text;
            string payment_method = this.txtBox_p_method.Text;
            string person;
            bool isChecked = payee.Checked;
            if (isChecked)
            {
                //person = Convert.ToInt32(payee.Tag);
                person = payee.Text;

            }else {
                //person = Convert.ToInt32(payer.Tag);
                person = payer.Text;
            }

            
            CPP.CreatePayeeOrPayer(name, address, contact_num, email, payment_method, person);
        }

        public void Clear()
        {

            txt_name.Clear();
            txt_add.Clear();
            txt_num.Clear();
            txt_email.Clear();
            txtBox_p_method.SelectedIndex = -1;

        }
    }
}
