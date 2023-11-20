namespace Facade
{
    internal class TV
    {
        public void On()
        {
            Console.WriteLine("Телевизор включен");
        }

        public void Off()
        {
            Console.WriteLine("Телевизор выключен");
        }

        public void Mode()
        {
            Console.WriteLine("Режим телевизора изменен");
        }
    }
}