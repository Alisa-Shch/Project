using Decorator.CoffeeN;

namespace Decorator.Additions
{
    internal class Lemon : Decorator
    {
        public Lemon(Coffee coffee)
            : base(coffee, 3, ", лимон") { }
    }
}