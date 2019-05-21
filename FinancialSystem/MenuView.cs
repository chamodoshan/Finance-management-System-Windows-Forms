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
    public partial class MenuView : Form
    {
        public MenuView()
        {
            InitializeComponent();
        }

      
        private void PayeePayerForm(object sender, EventArgs e)
        {
            PayeePayerDetailsView f1 = new PayeePayerDetailsView();
            f1.Show();
        }

        private void ExpenseForm(object sender, EventArgs e)
        {
            ExpensesAndIncomeDeatilsView f2 = new ExpensesAndIncomeDeatilsView();
            f2.Show();
        }

        private void ReportForm(object sender, EventArgs e)
        {
            DisplayReportView f3 = new DisplayReportView();
            f3.Show();
        }

        private void PredictionForm(object sender, EventArgs e)
        {
            PredictionView f4 = new PredictionView();
            f4.Show();
        }

        private void UpdatePayeeOrPayer(object sender, EventArgs e)
        {
            ViewPayeeAndPayer v1 = new ViewPayeeAndPayer();
            v1.Show();
        }

        private void UpdateExpenseOrIncome(object sender, EventArgs e)
        {
            ViewExpenseAndIncome v2 = new ViewExpenseAndIncome();
            v2.Show();
        }

        private void MenuView_Load(object sender, EventArgs e)
        {

        }
    }
}
