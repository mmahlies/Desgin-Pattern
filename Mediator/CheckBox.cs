namespace Mediator
{
    public class CheckBox : IComponent
    {
        IMediator _mediator;
        public string Name { get => "CheckBox"; set { } }

        public void Action()
        {
            _mediator.Notify(this, "checked");
        }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
