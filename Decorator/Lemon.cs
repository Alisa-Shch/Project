namespace Decorator
{
    internal class Lemon : Decorator
    {
        private Coffee _coffee;

        public Lemon(Coffee coffee)
        {
            _coffee = coffee;
        }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + ", лимон";
        }

        public override double Price()
        {
            return 3 + _coffee.Price();
        }
    }
}