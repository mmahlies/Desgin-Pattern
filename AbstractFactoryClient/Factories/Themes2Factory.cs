using AbstractFactoryClient.interfaces;
using AbstractFactoryClient.Thems1;
using AbstractFactoryClient.Thems2;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryClient.Factories
{
    public class Themes2Factory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new Theme2Button();
        }

        public ITextBox CreateTextBox()
        {
            return new Theme2TextBox();
        }
    }
}
