using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialSystem
{
    class DisplayPredictionViewController
    {
        ExpenseAndIncome EI = new ExpenseAndIncome();
        List<int> expense = new List<int>();
        List<int> income = new List<int>();
        public int totalE;
        public int totalI;
        public int countE;
        public int countI;
        public int avgE;
        public int avgI;

        public void CalculatePrediction(string date)
        {
            if (IsDateValid(date))
            {
              
                DateTime dt = DateTime.Parse(date);
                DayOfWeek dow = dt.DayOfWeek; 
                string str = dow.ToString();
                DateTime lastWednesday = DateTime.Now.AddDays(-1);
                switch (str) {
                    case "Monday":
                        while (lastWednesday.DayOfWeek != DayOfWeek.Monday)
                            lastWednesday = lastWednesday.AddDays(-1);
                        break;
                    case "Tuesday":
                        while (lastWednesday.DayOfWeek != DayOfWeek.Tuesday)
                            lastWednesday = lastWednesday.AddDays(-1);
                        break;
                    case "Wendnesday":
                        while (lastWednesday.DayOfWeek != DayOfWeek.Wednesday)
                            lastWednesday = lastWednesday.AddDays(-1);
                        break;
                    case "Thursday":
                        while (lastWednesday.DayOfWeek != DayOfWeek.Thursday)
                            lastWednesday = lastWednesday.AddDays(-1);
                        break;
                    case "Friday":
                        while (lastWednesday.DayOfWeek != DayOfWeek.Friday)
                            lastWednesday = lastWednesday.AddDays(-1);
                        break;
                    case "Saturday":
                        while (lastWednesday.DayOfWeek != DayOfWeek.Saturday)
                            lastWednesday = lastWednesday.AddDays(-1);
                        break;
                    case "Sunday":
                        while (lastWednesday.DayOfWeek != DayOfWeek.Sunday)
                            lastWednesday = lastWednesday.AddDays(-1);
                        break;

                }
                
                
                Console.WriteLine(lastWednesday.ToString("yyyy/MM/dd"));

                List<List<string>> data = new List<List<string>>();
                data = EI.GetExpenseIncomeData(lastWednesday.ToString("yyyy/MM/dd"));

                for (int i = 0; i < data.Count; i++)
                {
                    if (data[i][1] == "Expense")
                    {
                        totalE = totalE + int.Parse(data[i][0]);
                        countE++;
                        //var max = int.Parse(data[i][0]);
                        expense.Add(int.Parse(data[i][0]));
                    }
                    else if (data[i][1] == "Income")
                    {
                       totalI = totalI + int.Parse(data[i][0]);
                        countI++;
                        income.Add(int.Parse(data[i][0]));
                    }
                    
                }

                /*var maxE = expense.Max();
                var minE = expense.Min();
                midE = (maxE + minE) / 2;*/

                /*var maxI = income.Max();
                var minI = income.Min();
                midI = (maxI + minI) / 2;*/

                avgE = totalE / countE;
                avgI = totalI / countI;

                List<int> diversity = new List<int>();
                for (int i = 0; i < expense.Count; i++)
                {
                    diversity.Add(expense[i] - avgE);
                }

                for (int i = 0; i < diversity.Count; i++)
                {
                    Console.WriteLine(diversity[i]);
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Date is Invalid !!! Please select a future date", "Error");
            }
            
        }

        Boolean IsDateValid(string date)
        {
            DateTime now = DateTime.Now;
            string today = now.ToString("yyyy/M/d");

            if (DateTime.Parse(date) > DateTime.Parse(today)) 
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
