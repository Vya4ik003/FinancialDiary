namespace Diary.Commons.Mediator
{
    public class Mediator : IMediator
    {
        public IColleague Colleague1 { get; set; }
        public IColleague Colleague2 { get; set; }

        public void Send(NotifyInformation information, IColleague colleague)
        {
            if (colleague == Colleague1)
            {
                Colleague2?.Notify(information);
            }
            else
            {
                Colleague1?.Notify(information);
            }
        }
    }
}
