namespace Diary.Commons.Mediator
{
    public interface IMediator
    {
        IColleague MenuControlColleague { get; set; }
        IColleague MainWindowColleague { get; set; }
        IColleague CenterPageColleague { get; set; }

        void Send(object info, IColleague colleague);
    }
}
