using AbstractFactoryClient.interfaces;
using AbstractFactoryClient.Thems1;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryClient.Factories
{
  public  class Themes1Factory : IGUIFactory
    {
        // factory method
        public IButton CreateButton()
        {
            return new Theme1Button();
        }
        // factory method
        public ITextBox CreateTextBox()
        {
            return new Theme1TextBox();
        }
    }
}
