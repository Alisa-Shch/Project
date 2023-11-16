namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new();

            facade.On();
            facade.Off();
        }
    }
}