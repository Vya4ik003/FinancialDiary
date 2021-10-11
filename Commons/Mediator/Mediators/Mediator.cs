namespace Diary.Commons.Mediator
{
    public class Mediator : IMediator
    {
        public IColleague MenuControlColleague { get; set; }
        public IColleague MainWindowColleague { get; set; }
        public IColleague CenterPageColleague { get; set; }
        public IColleague AddCategoryColleague { get; set; }

        public void Send(object information, IColleague colleague)
        {
            SendToColleague(colleague, MenuControlColleague, MainWindowColleague, information);
            SendToColleague(colleague, MenuControlColleague, CenterPageColleague, information);
            SendToColleague(colleague, MenuControlColleague, AddCategoryColleague, information);
            SendToColleague(colleague, AddCategoryColleague, MenuControlColleague, information);
        }

        private void SendToColleague(IColleague currentColleague, IColleague colleague1, IColleague colleague2, object information)
        {
            if (currentColleague == colleague1)
                colleague2?.Notify(information);
            else
                colleague1?.Notify(information);
        }
    }
}
