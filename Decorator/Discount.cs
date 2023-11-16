namespace Decorator
{
    internal class Discount : Decorator
    {
        private Coffee _coffee;

        public Discount(Coffee coffee)
        {
            _coffee = coffee;
        }
        public override string GetDescription()
        {
            return _coffee.GetDescription() + " + Скидка";
        }

        public override double Price()
        {
            return _coffee.Price() - _coffee.Price()*0.05;
        }
    }
}