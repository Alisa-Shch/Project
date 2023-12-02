using Mediator.Request;

namespace Mediator
{
    internal class CoffeePot
    {
        public void Check(CalendarRequest request)
        {
            if (request is CalendarEventRequest)
            {
                Console.WriteLine($"Проверка даты для приготовления кофе: {request.date}");
            }
            else if (request is NewDayRequest)
            {
                Console.WriteLine("Наступил новый день");
            }
        }

        public void Check(AlarmRequest request)
        {
            Console.WriteLine($"Проверка времени для приготовления кофе: {request.time}");
        }
    }
}