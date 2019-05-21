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
    public partial class ViewPayeeAndPayer : Form
    {
        PayeeAndPayerViewController CPP = new PayeeAndPayerViewController();
        DataTable dataTb = new DataTable();
        public ViewPayeeAndPayer()
        {
            InitializeComponent();
           
        }

        private void ViewPayeeAndPayer_Load(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
        }

        private void Update(object sender, EventArgs e)
        {
            CPP.UpdatePayeePayer(dataTb);
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            dataTb = CPP.GetPayeePayer();
            

        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DataView dv = new DataView(dataTb);
            DataView dv1 = new DataView(dataTb);
            dv.RowFilter = "person='payee'";
            dv1.RowFilter = "person='payer'";
            dataGridView1.DataSource = dv;
            dataGridView2.DataSource = dv1;
        }
    }
}
