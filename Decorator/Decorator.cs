using Decorator.CoffeeN;

namespace Decorator
{
    internal class Decorator : Coffee
    {
        private Coffee _coffee;
        private double _extraPrice;

        public Decorator(Coffee coffee, double extraPrice, string descriptionAddition)
            : base(coffee.GetDescription() + descriptionAddition)
        {
            _coffee = coffee;
            _extraPrice = extraPrice;
        }

        public override double Price()
        {
            return _coffee.Price() + _extraPrice;
        }
    }
}