using AbstractFactoryClient.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryClient.Thems1
{
    class Theme1TextBox : ITextBox
    {
        public Theme1TextBox()
        {
            Console.WriteLine("Theme1 text  box created");
        }
        public void Render()
        {
            Console.WriteLine("Theme1 text  box rendered");
        }
    }
}
