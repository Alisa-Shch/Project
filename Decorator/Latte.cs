namespace Decorator
{
    internal class Latte : Coffee
    {
        public Latte()
        {
            _description = "Латте";
        }
        public override double Price()
        {
            return 20;
        }
    }
}