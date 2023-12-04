using Mediator.Request;

namespace Mediator
{
    internal class CoffeePot
    {
        public void Check(CalendarRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            if (request is NewDayRequest)
            {
                switch (request.Date.DayOfWeek)
                {
                    case DayOfWeek.Saturday:
                    case DayOfWeek.Sunday: Console.WriteLine("Сегодня выходной");
                        break;
                    default: Console.WriteLine("Сегодня будний день");
                        if (DateTime.Now.Hour < 12)
                        {
                            Console.WriteLine("Кофе готовится");
                        }
                        break;
                }
            }
        }

        public void Check(AlarmRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            Console.WriteLine($"Кофе будет готов в {request.Time}");
        }
    }
}