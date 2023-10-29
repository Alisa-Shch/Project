namespace Adapter
{
    internal class RubberDuck : Duck
    {
        public override void Quack()
        {
            Console.WriteLine("Резиновая утка крякает");
        }

        public override void Fly()
        {
            Console.WriteLine("Резиновая утка не умеет летать");
        }
    }
}