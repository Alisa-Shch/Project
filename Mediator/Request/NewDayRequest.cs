namespace Mediator.Request
{
    internal class NewDayRequest : CalendarRequest
    {
        public NewDayRequest(DateOnly date) : base(date) { }
    }
}