namespace Strategy
{
    internal class Quack : IQuack
    {
        public void Execute()
        {
            Console.WriteLine("Утка крякает");
        }
    }
}