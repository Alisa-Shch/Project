namespace Facade
{
    internal class Facade
    {
        private TV tv;
        private Audio audio;
        private DVD dvd;

        public Facade()
        {
            tv = new TV();
            audio = new Audio();
            dvd = new DVD();
        }

        public void On()
        {
            tv.On();
            audio.On();
            dvd.In();
            dvd.Play();
        }

        public void Off()
        {
            Console.WriteLine("Выключение домашнего кинотеатра");
            tv.Off();
            audio.Off();
            dvd.Out();
        }
    }
}