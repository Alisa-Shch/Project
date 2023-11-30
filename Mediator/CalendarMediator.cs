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

        public void Execute()
        {
            CalendarRequest request = new();

            _calendar.OnEvent();
            _coffeePot.Check(request);
            _sprinkler.Check(request);
        }
    }
}