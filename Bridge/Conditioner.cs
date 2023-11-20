namespace Bridge
{
    internal class Conditioner : IImplementor
    {
        public int Power { get; private set; }
        public int Mode { get; private set; }

        public void On()
        {
            Console.WriteLine("Кондиционер включен");
        }

        public void Off()
        {
            Console.WriteLine("Кондиционер выключен");
        }

        public void SetPower(int power)
        {
            if (power > 0)
            {
                Power = power;
                Console.WriteLine($"Мощность кондиционера: {power}");
            }
            else
            {
                throw new ArgumentException(nameof(power), "Значение не может отрицательным или быть равным 0");
            }
        }

        public void SetMode(int mode)
        {
            if (mode > 0)
            {
                Mode = mode;
                Console.WriteLine($"Режим кондиционера: {mode}");
            }
            else
            {
                throw new ArgumentException(nameof(mode), "Значение не может отрицательным или быть равным 0");
            }
        }
    }
}