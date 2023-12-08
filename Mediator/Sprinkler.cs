using Mediator.Request;

namespace Mediator
{
    internal class Sprinkler
    {
        public void Check(CalendarEventRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            
            Console.WriteLine($"Разбрызгиватель будет включен {request.Date}");
        }

        public void Check(AlarmRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            Console.WriteLine($"Разбрызгиватель будет включен в {request.Time}");
        }
    }
}