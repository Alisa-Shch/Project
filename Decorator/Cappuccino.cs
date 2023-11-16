namespace Decorator
{
    internal class Cappuccino : Coffee
    {
        public Cappuccino()
        {
            _description = "Капучино";
        }

        public override double Price()
        {
            return 25;
        }
    }
}