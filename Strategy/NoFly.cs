namespace Strategy
{
    internal class NoFly : IFly
    {
        public void Execute()
        {
            Console.WriteLine("Утка не летает");
        }
    }
}