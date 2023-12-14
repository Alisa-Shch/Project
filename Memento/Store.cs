namespace Memento
{
    internal class Store
    {
        private List<IMemento> _mementos;

        public Store()
        {
            _mementos = new();
        }

        public void Add(IMemento memento)
        {
            _mementos.Add(memento);
        }

        public IMemento Previous()
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

        public IMemento GetByDate(DateTime date)
        {
            IMemento ?memento = _mementos.FirstOrDefault(m => m.GetDate() == date);

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