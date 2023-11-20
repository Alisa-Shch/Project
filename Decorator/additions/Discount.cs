using Decorator.CoffeeN;

namespace Decorator.Additions
{
    internal class Discount : Decorator
    {
        public Discount(Coffee coffee)
            : base(coffee, coffee.Price() * (-0.05), " + Скидка") { }
    }
}