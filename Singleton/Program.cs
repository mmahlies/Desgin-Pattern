using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class SingletonClass
    {
        
        static SingletonClass uniqueInstance = null;
        private SingletonClass()
        {

        }

        //lazy instaintioation
        public static SingletonClass GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new SingletonClass(); 
            }
            return uniqueInstance;
        }
    }
}
