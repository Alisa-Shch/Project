using Decorator.сoffee;

namespace Decorator.additions
{
    internal class Sugar : Decorator
    {
        public Sugar(Coffee coffee)
            : base(coffee, 1, ", cахар") { }
    }
}