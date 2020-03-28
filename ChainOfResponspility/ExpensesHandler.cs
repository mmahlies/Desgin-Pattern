using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponspility
{
    class ExpensesHandler :IExpenseHandler
    {
        IExpensesApprover _aprover;
        IExpenseHandler _next;
        public ExpensesHandler(IExpensesApprover approver)
        {
            _aprover = approver;
            /// null object pattern and is default decleration 
            /// RegisterNext will override this call
            _next = EnfOfChainExceptionHandler.Instance;
        }

        public ApproveResponse Approve(IExpensesReport expensesReport)
        {
            ApproveResponse result = _aprover.Approve(expensesReport);
            if (result == ApproveResponse.ByoundTheScope)
            {
                return this._next.Approve(expensesReport);
            }
            return result;
        }

        public void RegisterNext(IExpenseHandler next)
        {
            this._next = next;
        }
    }
}
