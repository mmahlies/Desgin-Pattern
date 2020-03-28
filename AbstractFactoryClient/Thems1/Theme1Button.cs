using AbstractFactoryClient.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryClient.Thems1
{
    class Theme1Button : IButton
    {
        public Theme1Button()
        {
            Console.WriteLine("Theme1Button created");
        }

        public void Render()
        {
            Console.WriteLine("Theme1Button rendered");
        }
    }
}
