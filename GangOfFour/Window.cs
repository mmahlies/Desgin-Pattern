using AbstractFactoryClient.interfaces;
using System;

namespace GangOfFour
{
    public class Window
    {
        public Window(IGUIFactory gUIFactory)
        {
            IButton button = gUIFactory.CreateButton();
            button.Render();

            ITextBox textBox = gUIFactory.CreateTextBox();
            textBox.Render();
        }
    }
}
