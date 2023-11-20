using Decorator.CoffeeN;

namespace Decorator.Additions
{
    internal class Sugar : Decorator
    {
        public Sugar(Coffee coffee)
            : base(coffee, 1, ", cахар") { }
    }
}