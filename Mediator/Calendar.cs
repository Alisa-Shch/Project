using Mediator.Request;

namespace Mediator
{
    internal class Calendar
    {
        private CalendarMediator _mediator;

        public Calendar(CalendarMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        public void OnEvent(CalendarRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            _mediator.Execute(request);
        }
    }
}