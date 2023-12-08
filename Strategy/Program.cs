namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WildDuck wildDuck = new();
            wildDuck.Fly();
            wildDuck.Swim();
            wildDuck.Quack();

            IronDuck ironDuck = new();
            ironDuck.Fly();
            ironDuck.Quack();
            ironDuck.Swim();
        }
    }
}