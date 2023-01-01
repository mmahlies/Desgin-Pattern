using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponspility
{
    class Program
    {
        static void Main(string[] args)
        {
            ExpensesHandler w1 = new ExpensesHandler(new Employee("w1", 10));
            ExpensesHandler w2 = new ExpensesHandler(new Employee("w2", 20));
            ExpensesHandler w3 = new ExpensesHandler(new Employee("w3", 30));
            w1.RegisterNext(w2);
            w2.RegisterNext(w3);


            ApproveResponse result = w1.Approve(new ExpensesReport(10));
            Console.WriteLine(result);           
            


        }
    }
}
