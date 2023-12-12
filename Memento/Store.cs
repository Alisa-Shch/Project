namespace MementoN
{
    internal class Store
    {
        private List<Memento> _mementos;

        public Store()
        {
            _mementos = new();
        }

        public void Add(Memento memento)
        {
            _mementos.Add(memento);
        }

        public Memento Previous()
        {
            if (_mementos.Count > 0)
            {
                return _mementos[^1];
            }
            else
            {
                throw new InvalidOperationException("Пусто");
            }
        }

        public Memento GetByDate(DateTime date)
        {
            Memento ?memento = _mementos.FirstOrDefault(m => m.GetDate() == date);

            if (memento != null)
            {
                return memento;
            }
            else
            {
                throw new InvalidOperationException($"Не найдено состояние для даты {date}");
            }
        }
    }
}