using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponspility
{
    class Employee : IExpensesApprover
    {
        decimal _scopeLimit;
        string _name;
        public Employee(string name, decimal scopeLimit)
        {
            this._scopeLimit = scopeLimit;
            this._name = name;
        }
        public ApproveResponse Approve(IExpensesReport report)
        {
            return (report.Total <= _scopeLimit) ? ApproveResponse.Accepted : ApproveResponse.ByoundTheScope;
        }
    }
}
