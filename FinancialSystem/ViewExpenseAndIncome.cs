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
    public partial class ViewExpenseAndIncome : Form
    {
        ExpenseAndIncomeViewController CEI = new ExpenseAndIncomeViewController();
        DataTable dataTb = new DataTable();
        List<ExpensesAndIncomes> data = new List<ExpensesAndIncomes>();
        List<ExpensesAndIncomes> expense = new List<ExpensesAndIncomes>();
        List<ExpensesAndIncomes> income = new List<ExpensesAndIncomes>();
        public ViewExpenseAndIncome()
        {
            InitializeComponent();
        }

        private void ViewExpenseAndIncome_Load_1(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
        }

        private void Update(object sender, EventArgs e)
        {
            CEI.UpdateExpenseIncome(dataTb);
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            dataTb = CEI.GetExpenseIncome();
            /*DataView dv = new DataView(dataTb);
            DataView dv1 = new DataView(dataTb);
            dv.RowFilter = "expense_or_income='Expense'";
            dv1.RowFilter = "expense_or_income='Income'";
            dataGridView3.DataSource = dv;
            dataGridView4.DataSource = dv1;*/
            data = CEI.GetExpenseIncomeXml();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Type == "Expense")
                {
                    expense.Add(data[i]);
                }
                else if (data[i].Type == "Income")
                {
                    income.Add(data[i]);
                }

            }
            dataGridView3.DataSource = expense;
            dataGridView4.DataSource = income;
        }
    }

    
}
