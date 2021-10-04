namespace Diary.Commons.Mediator
{
    public class NotifyInformation
    {
        public ActionTypes ActionType { get; set; }
        public object[] Information { get; set; }

        public NotifyInformation(ActionTypes actionType, params object[] info)
        {
            ActionType = actionType;
            Information = info;
        }
    }
}
