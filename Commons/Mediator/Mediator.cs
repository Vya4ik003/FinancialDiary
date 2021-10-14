using System;
using Diary.Commons.Mediator.Information;

namespace Diary.Commons.Mediator
{
    public class Mediator : IMediator
    {
        public IColleague MenuControlColleague { get; set; }
        public IColleague MainWindowColleague { get; set; }
        public IColleague CenterPageColleague { get; set; }

        public void Send(object information, IColleague colleague)
        {
            if (colleague == MenuControlColleague && information is MenuActions)
            {
                MainWindowColleague.Notify(information);
            }
            else if (colleague == CenterPageColleague)
            {
                MenuControlColleague.Notify(information);
            }
            else
                throw new Exception("Unexpected collegue.");
        }
    }
}
