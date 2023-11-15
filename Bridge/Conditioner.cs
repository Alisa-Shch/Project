namespace Bridge
{
    internal class Conditioner : Implementor
    {
        public override void On()
        {
            Console.WriteLine("Кондиционер включен");
        }

        public override void Off()
        {
            Console.WriteLine("Кондиционер выключен");
        }

        public override void SetPower(int power)
        {
            if (power > 0)
            {
                Console.WriteLine($"Мощность кондиционера установлена ​​на {power}");
            }
            else
            {
                throw new ArgumentException(nameof(power), "Значение не может отрицательным или быть равным 0");
            }
        }

        public override void SetMode(int mode)
        {
            if (mode > 0)
            {
                Console.WriteLine($"Режим кондиционера установлен на {mode}");
            }
            else
            {
                throw new ArgumentException(nameof(mode), "Значение не может отрицательным или быть равным 0");
            }
        }
    }
}