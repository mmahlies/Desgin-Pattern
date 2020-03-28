using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryClient.interfaces
{
   public interface IGUIFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}
