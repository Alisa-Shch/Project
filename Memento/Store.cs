namespace MementoN
{
    internal class Store
    {
        private Memento _memento;

        public Store()
        {
            _memento = new Memento();
        }

        public void Add(Memento memento)
        {
            _memento = memento;
        }

        public Memento Previous()
        {
            return _memento;
        }
    }
}