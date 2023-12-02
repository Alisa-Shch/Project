namespace Mediator.Request
{
    internal class CalendarEventRequest : CalendarRequest
    {
        public CalendarEventRequest(DateOnly date) : base(date) { }
    }
}