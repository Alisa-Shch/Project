namespace Decorator
{
    internal class Syrup : Decorator
    {
        private Coffee _coffee;

        public Syrup(Coffee coffee)
        {
            _coffee = coffee;
        }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + ", cироп";
        }

        public override double Price()
        {
            return 2 + _coffee.Price();
        }
    }
}