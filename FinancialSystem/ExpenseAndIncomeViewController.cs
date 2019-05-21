using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Data;

namespace FinancialSystem
{
    class ExpenseAndIncomeViewController
    {
        List<string> rows = new List<string>();
        ExpenseAndIncome EI = new ExpenseAndIncome();

        public List<string> GetPayeePayer()
        {
            PayeeAndPayer pp = new PayeeAndPayer();
            rows = pp.GetPayeeAndPayer();
            return rows;
        }

        public bool IsEmpty(string str)
        {
            if (str == "")
            {
                return true;
            }

            return false;
        }

        public void CreateExpenseOrIncome(List<List<string>> data)
        {
            EI.CreateExpenseOrIncomeXml(data);
            EI.CreateExpenseOrIncome(data);
        }

        bool IsNumbersOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }

            }

            return true;
        }

        public DataTable GetExpenseIncome()
        {
            return EI.GetExpenseIncome();
        }

        public List<ExpensesAndIncomes> GetExpenseIncomeXml()
        {
            return EI.GetExpenseIncomeXml();
        }

        public void UpdateExpenseIncome(DataTable dataTb)
        {
            EI.UpdateExpenseIncome(dataTb);
        }

    }


}
