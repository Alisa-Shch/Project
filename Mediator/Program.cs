using Mediator.Request;

namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlarmMediator alarmMediator = new(new CoffeePot(), new Sprinkler());
            CalendarMediator calendarMediator = new(new CoffeePot(), new Sprinkler());

            Alarm alarm = new(alarmMediator);
            Calendar calendar = new(calendarMediator);

            AlarmRequest alarmRequest = new(new TimeOnly(9, 30, 00));
            CalendarEventRequest eventRequest = new(new DateOnly(2023, 12, 5));
            NewDayRequest newDayRequest = new();

            alarm.OnEvent(alarmRequest);
            calendar.OnEvent(eventRequest);
            calendar.OnEvent(newDayRequest);
        }
    }
}