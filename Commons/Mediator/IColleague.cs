namespace Commons.Mediator
{
    public interface IColleague
    {
        IMediator ConcreteMediator { get; }
        void Notify(NotifyInformation information);
        void Send(NotifyInformation information);
    }
}
