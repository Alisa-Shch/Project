using Mediator.Request;

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

        public void Execute(IRequest request)
        {
            if (request is AlarmRequest alarmRequest)
            {
                _alarm.OnEvent();
                _coffeePot.Check(alarmRequest);
                _sprinkler.Check(alarmRequest);
            }
        }
    }
}