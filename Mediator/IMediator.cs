using Mediator.Request;

namespace Mediator
{
    internal interface IMediator
    {
        public void Execute(IRequest request);
    }
}