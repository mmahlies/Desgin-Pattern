using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator1 mediator1 = new Mediator1();
            Button b1 = new Button();
            b1.SetMediator(mediator1);

            CheckBox CheckBox1 = new CheckBox();
            CheckBox1.SetMediator(mediator1);

            CheckBox1.Action();
            b1.Action();

        }
    }
}
