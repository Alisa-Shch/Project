namespace Mediator
{
    internal class CoffeePot
    {
        public void Check(CalendarRequest calendarRequest)
        {
            Console.WriteLine($"Проверка даты для приготовления кофе: {calendarRequest.date}");
        }

        public void Check(AlarmRequest alarmRequest)
        {
            Console.WriteLine($"Проверка времени для приготовления кофе: {alarmRequest.time}");
        }
    }
}