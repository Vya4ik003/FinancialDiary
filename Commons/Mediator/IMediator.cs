namespace Diary.Commons.Mediator
{
    public interface IMediator
    {
        void Send(NotifyInformation information, IColleague colleague);
    }
}
