using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class BankServices :IBankAcount
    {
        // compose multiple api into one api and provide to the client
        public void Deposit()
        {
            throw new NotImplementedException();
        }

        public void WithDraw()
        {
            //
            throw new NotImplementedException();
        }
    }
}
