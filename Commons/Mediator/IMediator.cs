namespace Commons.Mediator
{
    public interface IMediator
    {
        void Send(NotifyInformation information, IColleague colleague);
    }
}
