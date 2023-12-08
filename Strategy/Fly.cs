namespace Strategy
{
    internal class Fly : IFly
    {
        public void Execute()
        {
            Console.WriteLine("Утка летает");
        }
    }
}