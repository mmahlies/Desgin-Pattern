using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
   public abstract  class Document
    {
       protected IPrinter printer;
       public Document(IPrinter printer)
       {
           this.printer = printer;
       }
       public abstract void Print();
    }
}
