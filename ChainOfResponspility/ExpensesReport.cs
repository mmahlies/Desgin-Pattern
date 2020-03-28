using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponspility
{
    class ExpensesReport : IExpensesReport
    {
        public decimal Total { get; private set; }
        public ExpensesReport(decimal total)
        {
            this.Total = total;
        }
    }
}
