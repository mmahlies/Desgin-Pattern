using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponspility
{
    interface IExpenseHandler
    {
        ApproveResponse Approve(IExpensesReport expensesReport);
        void RegisterNext(IExpenseHandler next);
    }

    public enum ApproveResponse
    {
        Denied, Accepted , ByoundTheScope
    }
    
    interface IExpensesReport
    {
         decimal Total { get; }
    }

     interface IExpensesApprover
    {
        ApproveResponse Approve(IExpensesReport report);
    }



}
