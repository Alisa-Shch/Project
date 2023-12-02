using Mediator.Request;

namespace Mediator
{
    internal class Sprinkler
    {
        public void Check(CalendarRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            if (request is CalendarEventRequest)
            {
                Console.WriteLine($"Проверка даты включения разбрызгивателя: {request.Date}");
            }
            else if (request is NewDayRequest)
            {
                Console.WriteLine("Наступил новый день");
            }
        }

        public void Check(AlarmRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            Console.WriteLine($"Проверка времени включения разбрызгивателя: {request.Time}");
        }
    }
}