namespace MementoN
{
    internal class Memento
    {
        private DateTime _date;

        public Memento()
        {
            _date = DateTime.Now;
        }

        public DateTime GetDate()
        {
            return _date;
        }
    }
}