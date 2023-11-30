namespace Mediator
{
    internal class AlarmMediator : IMediator
    {
        private Alarm _alarm;
        private CoffeePot _coffeePot;
        private Sprinkler _sprinkler;

        public AlarmMediator(Alarm alarm, CoffeePot coffeePot, Sprinkler sprinkler)
        {
            _alarm = alarm;
            _coffeePot = coffeePot;
            _sprinkler = sprinkler;
        }

        public void Execute()
        {
            AlarmRequest request = new();

            _alarm.OnEvent();
            _coffeePot.Check(request);
            _sprinkler.Check(request);
        }
    }
}