using AbstractFactoryClient.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryClient.Thems2
{
    class Theme2Button           :IButton
    {
        public Theme2Button()
        {
            Console.WriteLine("Theme2Button created");
        }

        public void Render()
        {
            Console.WriteLine("Theme2Button rendered");
        }
    }
}
