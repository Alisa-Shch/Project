namespace Mediator.Request
{
    internal class AlarmRequest : IRequest
    {
        public TimeOnly time { get; private set; }

        public AlarmRequest(TimeOnly time)
        {
            this.time = time;
        }
    }
}