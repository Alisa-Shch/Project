namespace Bridge
{
    internal class TV : IImplementor
    {
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
                Console.WriteLine($"Режим телевизора установлен на {mode}");
            }
            else
            {
                throw new ArgumentException(nameof(mode), "Значение не может отрицательным или быть равным 0");
            }
        }
    }
}