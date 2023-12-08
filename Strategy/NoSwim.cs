namespace Strategy
{
    internal class NoSwim : ISwim
    {
        public void Execute()
        {
            Console.WriteLine("Утка не плавает");
        }
    }
}