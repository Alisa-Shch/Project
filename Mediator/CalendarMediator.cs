using Mediator.Request;

namespace Mediator
{
    internal class CalendarMediator : IMediator
    {
        private Calendar _calendar;
        private CoffeePot _coffeePot;
        private Sprinkler _sprinkler;

        public CalendarMediator(Calendar calendar, CoffeePot coffeePot, Sprinkler sprinkler)
        {
            _calendar = calendar;
            _coffeePot = coffeePot;
            _sprinkler = sprinkler;
        }

        public void Execute(IRequest request)
        {
            if (request is CalendarRequest calendarRequest)
            {
                _calendar.OnEvent();
                _coffeePot.Check(calendarRequest);
                _sprinkler.Check(calendarRequest);
            }
        }
    }
}