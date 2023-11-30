namespace Mediator
{
    internal class Sprinkler
    {
        public void Check(CalendarRequest calendarRequest)
        {
            Console.WriteLine($"Проверка даты включения разбрызгивателя: {calendarRequest.date}");
        }

        public void Check(AlarmRequest alarmRequest)
        {
            Console.WriteLine($"Проверка времени включения разбрызгивателя: {alarmRequest.time}");
        }
    }
}