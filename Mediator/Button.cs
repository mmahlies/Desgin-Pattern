namespace Mediator
{
    class Button : IComponent
    {
        IMediator _mediator;
        public string Name { get => "submit"; set { } }

        public void Action()
        {
            _mediator.Notify(this, "submit");
        }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
