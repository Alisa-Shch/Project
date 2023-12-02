namespace Mediator.Request
{
    internal class NewDayRequest : CalendarRequest
    {
        public NewDayRequest() : base(new DateOnly()) { }
    }
}