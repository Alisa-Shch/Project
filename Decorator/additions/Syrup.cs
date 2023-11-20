using Decorator.CoffeeN;

namespace Decorator.Additions
{
    internal class Syrup : Decorator
    {
        public Syrup(Coffee coffee)
            : base(coffee, 1, ", cироп") { }
    }
}