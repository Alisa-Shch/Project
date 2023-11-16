namespace Decorator
{
    internal class Sugar : Decorator
    {
        private Coffee _coffee;

        public Sugar(Coffee coffee)
        {
            _coffee = coffee;
        }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + ", cахар";
        }

        public override double Price()
        {
            return 1 + _coffee.Price();
        }
    }
}