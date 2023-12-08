namespace Strategy
{
    internal class NoQuack : IQuack
    {
        public void Execute()
        {
            Console.WriteLine("Утка не крякает");
        }
    }
}