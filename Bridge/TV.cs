namespace Bridge
{
    internal class TV : IImplementor
    {
        public int Power { get; private set; }
        public int Mode { get; private set; }

        public void On()
        {
            Console.WriteLine("Телевизор включен");
        }

        public void Off()
        {
            Console.WriteLine("Телевизор выключен");
        }

        public void SetPower(int power)
        {
            if (power > 0)
            {
                Power = power;
                Console.WriteLine($"Мощность телевизора установлена ​​на {power}");
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
                Console.WriteLine($"Режим телевизора установлен на {mode}");
            }
            else
            {
                throw new ArgumentException(nameof(mode), "Значение не может отрицательным или быть равным 0");
            }
        }
    }
}