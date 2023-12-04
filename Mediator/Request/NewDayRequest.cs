namespace Mediator.Request
{
    internal class NewDayRequest : CalendarRequest
    {
        public NewDayRequest() : base(CurrentDate()) { }

        public static DateOnly CurrentDate() 
        {
            DateTime dateTime = DateTime.Now;
            return new DateOnly(dateTime.Year, dateTime.Month, dateTime.Day);
        }
    }
}