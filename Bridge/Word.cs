using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Word : Document
    {
        public Word(IPrinter printer): base(printer)
        {

        }
        public override void Print( )
        {
            printer.PrintFromPrinter("word PDF");
        }
    }
}
