using Mediator.Request;

namespace Mediator
{
    internal class Sprinkler
    {
        public void Check(CalendarRequest request)
        {
            if (request is CalendarEventRequest)
            {
                Console.WriteLine($"Проверка даты включения разбрызгивателя: {request.date}");
            }
            else if (request is NewDayRequest)
            {
                Console.WriteLine("Наступил новый день");
            }
        }

        public void Check(AlarmRequest request)
        {
            Console.WriteLine($"Проверка времени включения разбрызгивателя: {request.time}");
        }
    }
}