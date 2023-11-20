namespace Facade
{
    internal class DVD
    {
        public void In()
        {
            Console.WriteLine("Диск вставлен");
        }

        public void Out()
        {
            Console.WriteLine("Диск выводится");
        }

        public void Play()
        {
            Console.WriteLine("Воспроизведение содержимого диска");
        }
    }
}