using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class PDF:Document
    {
        public PDF(IPrinter printer)
            : base(printer)
        {

        }
        public override void Print()
        {
         printer.PrintFromPrinter( "print PDF");
        }
    }
}
