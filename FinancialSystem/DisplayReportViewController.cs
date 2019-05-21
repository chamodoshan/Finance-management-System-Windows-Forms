using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialSystem
{
    class DisplayReportViewController
    {
        ExpenseAndIncome EI = new ExpenseAndIncome();
        List<int> expense = new List<int>();
        List<int> income = new List<int>();
        public int countE;
        public int countI;
        public string minE;
        public string minI;
        public string maxE;
        public string maxI;
        public int totalE;
        public int totalI;
        public int profit;
        public int loss;
        public int [] GetExpenseIncomeData()
        {
            //List<Row> data = new List<Row>();
            List<List<string>> data = new List<List<string>>();
           // List<List<string>> expense = new List<List<string>>();
            //List<List<string>> income = new List<List<string>>();
            data = EI.GetExpenseIncomeDataInDateRange();

            for(int i =0; i<data.Count; i++)
            {
                if (data[i][2]== "Expense")
                {
                    totalE = totalE+ int.Parse(data[i][0]);
                    countE++;
                    expense.Add(int.Parse(data[i][0]));
                    //var max = int.Parse(data[i][0]);
                    //expense.Add(data[i]);
                }
                else if (data[i][2] == "Income")
                {
                    totalI = totalI + int.Parse(data[i][0]);
                    countI++;
                    income.Add(int.Parse(data[i][0]));
                    //income.Add(data[i]);
                }
                    //Console.WriteLine(data[i][2]);
            }

            //countE = expense.Count.ToString();
            // countI = income.Count.ToString();

            var maxE = expense.Max();
            var minE = expense.Min();

            var maxI = income.Max();
            var minI = income.Min();
            if (totalE <= totalI)
            {
                profit = totalI - totalE;
                loss = 0;
            }
            else
            {
                loss = totalE - totalI;
                profit = 0;
            }
            int[] values = { countE, countI, maxE, maxI, minE, minI, totalE, totalI, profit, loss };
            return values;
        }
    }
}
