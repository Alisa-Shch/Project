using Mediator.Request;

namespace Mediator
{
    internal class Alarm
    {
        private AlarmMediator _mediator;

        public Alarm(AlarmMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        public void OnEvent(AlarmRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            _mediator.Execute(request);
        }
    }
}