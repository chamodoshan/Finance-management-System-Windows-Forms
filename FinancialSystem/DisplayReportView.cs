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
    public partial class DisplayReportView : Form
    {
        DisplayReportViewController DR = new DisplayReportViewController();
        public DisplayReportView()
        {
            InitializeComponent();
            GetExpeseIncomeData();
        }

        public void GetExpeseIncomeData()
        {
            //List<Row> data = new List<Row>();
            int [] values =DR.GetExpenseIncomeData();
            n_of_expense.Text = values[0].ToString();
            n_of_income.Text = values[1].ToString();
            max_expense.Text = values[2].ToString();
            max_income.Text = values[3].ToString();
            min_expense.Text = values[4].ToString();
            min_income.Text = values[5].ToString();
            total_expense.Text = values[6].ToString();
            total_income.Text = values[7].ToString();
            profit.Text = values[8].ToString();
            loss.Text = values[9].ToString();
        }
    }

    
}
