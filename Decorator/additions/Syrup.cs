using Decorator.сoffee;

namespace Decorator.additions
{
    internal class Syrup : Decorator
    {
        public Syrup(Coffee coffee)
            : base(coffee, 1, ", cироп") { }
    }
}