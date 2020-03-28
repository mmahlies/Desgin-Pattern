namespace Mediator
{
    public interface IMediator
    {
        void Notify(IComponent sender, string eventName);

    }
}
