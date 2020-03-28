using AbstractFactoryClient.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryClient.Thems2
{
    class Theme2TextBox        :ITextBox
    {
        public Theme2TextBox()
        {
            Console.WriteLine("Theme2 textbox created");
        }

        public void Render()
        {
            Console.WriteLine("Theme2 text  box rendered");
        }
    }
}
