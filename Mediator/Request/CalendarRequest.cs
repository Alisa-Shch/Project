namespace Mediator.Request
{
    internal class CalendarRequest : IRequest
    {
        public DateOnly date { get; private set; }

        public CalendarRequest(DateOnly date)
        {
            this.date = date;
        }
    }
}