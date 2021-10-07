namespace Diary.Commons.Mediator
{
    public interface IMediator
    {
        IColleague Colleague1 { get; set; }
        IColleague Colleague2 { get; set; }

        void Send(NotifyInformation information, IColleague colleague);
    }
}
