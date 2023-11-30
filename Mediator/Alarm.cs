namespace Mediator
{
    internal class Alarm
    {
        public void OnEvent()
        {
            Console.WriteLine("Сработало оповещение");
        }

        public void Check(CalendarRequest calendarRequest)
        {

        }
    }
}