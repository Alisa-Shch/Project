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

            calendar.OnEvent();
            alarm.OnEvent();
        }
    }
}