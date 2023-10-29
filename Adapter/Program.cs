namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck Duck = new();
            Duck.Quack();
            Duck.Fly();

            Duck rubberDuck = new RubberDuck();
            rubberDuck.Quack();
            rubberDuck.Fly();

            Turkey turkey = new();
            Duck Adapter = new Adapter(turkey);
            Adapter.Quack();
            Adapter.Fly();          
        }
    }
}