namespace Bridge
{
    internal class RemoteControl : Remote
    {
        private Dictionary<int, (int Power, int Mode)> dictionary = new Dictionary<int, (int Power, int Mode)>();

        public RemoteControl(Implementor implementor) 
            : base(implementor)  { }

        public void Save(int index)
        {
            if (index <= 0)
            {
                throw new ArgumentException(nameof(index), "index должен быть больше 0");
            }

            dictionary[index] = (Power, Mode);
            Console.WriteLine("Сохраненный режим {0}: Мощность {1}, Режим {2}", index, Power, Mode);
        }

        public void Load(int index)
        {
            if (index <= 0)
            {
                throw new ArgumentException(nameof(index), "index должен быть больше 0");
            }

            if (dictionary.ContainsKey(index))
            {
                var d = dictionary[index];
                int savedPower = d.Power;
                int savedMode = d.Mode;

                Power = savedPower;
                Mode = savedMode;
                implementor.SetPower(Power);
                implementor.SetMode(Mode);
                Console.WriteLine("Загруженный режим {0}: Мощность {1}, Режим {2}", index, Power, Mode);
            }
            else
            {
                Console.WriteLine("Режим с индексом {0} не найден.", index);
            }
        }

    }
}