namespace Diary.Commons.Mediator
{
    public interface IColleague
    {
        IMediator Mediator { get; set; }
        void Notify(object info);
        void Send(object info);
    }
}
