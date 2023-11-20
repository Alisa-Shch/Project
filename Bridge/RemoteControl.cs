namespace Bridge
{
    internal class RemoteControl : Remote
    {
        private Dictionary<int, (int Power, int Mode)> _dictionary = new();

        public RemoteControl(IImplementor implementor) 
            : base(implementor)  { }

        public void Save(int index)
        {
            if (index <= 0)
            {
                throw new ArgumentException(nameof(index), "index должен быть больше 0");
            }

            _dictionary[index] = (Power, Mode);
            Console.WriteLine("Сохраненный режим {0}: Мощность {1}, Режим {2}", index, Power, Mode);
        }

        public void Load(int index)
        {
            if (index <= 0)
            {
                throw new ArgumentException(nameof(index), "index должен быть больше 0");
            }

            if (_dictionary.ContainsKey(index))
            {
                Implementor.SetPower(_dictionary[index].Power);
                Implementor.SetMode(_dictionary[index].Mode);
                Console.WriteLine("Загруженный режим {0}: Мощность {1}, Режим {2}", index, Power, Mode);
            }
            else
            {
                Console.WriteLine("Режим с индексом {0} не найден.", index);
            }
        }
    }
}