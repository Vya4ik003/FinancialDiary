namespace Diary.Commons.Mediator
{
    public interface IMediator
    {
        IColleague MenuControlColleague { get; set; }
        IColleague MainWindowColleague { get; set; }
        IColleague CenterPageColleague { get; set; }
        IColleague AddPageColleague { get; set; }

        void Send(object information, IColleague colleague);
    }
}
