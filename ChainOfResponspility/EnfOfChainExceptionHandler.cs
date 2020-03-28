using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponspility
{
    class EnfOfChainExceptionHandler : IExpenseHandler
    {
        private static readonly EnfOfChainExceptionHandler enfOfChainExceptionHandler = new EnfOfChainExceptionHandler();
        public static EnfOfChainExceptionHandler Instance
        {
            get
            { return enfOfChainExceptionHandler; }
        }
        public ApproveResponse Approve(IExpensesReport expensesReport)
        {
            return ApproveResponse.Denied;
        }

        public void RegisterNext(IExpenseHandler next)
        {
            throw new Exception("End of chain ex");
        }

        private EnfOfChainExceptionHandler()
        {

        }

    }
}
