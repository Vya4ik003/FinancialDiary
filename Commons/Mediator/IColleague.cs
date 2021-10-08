namespace Diary.Commons.Mediator
{
    public interface IColleague
    {
        IMediator ConcreteMediator { get; }
        void Notify(object information);
        void Send(object information);
    }
}
