namespace Mediator
{
    // first mediator implementation
    public class Mediator1 : IMediator
    {
        public void Notify(IComponent sender, string eventName)
        {
            if (sender.Name == "checkBox" && eventName == "checked")
            {
                // show hide some other element and be coubled to those element
            }
            else if (sender.Name == "button" && eventName == "submit")
            {
                // check for check box state and do some other logic based on this state
            }
        }
    }
}
