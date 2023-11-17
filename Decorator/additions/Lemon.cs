using Decorator.сoffee;

namespace Decorator.additions
{
    internal class Lemon : Decorator
    {
        public Lemon(Coffee coffee)
            : base(coffee, 3, ", лимон") { }
    }
}