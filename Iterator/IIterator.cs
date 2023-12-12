namespace Iterator
{
    internal interface IIterator<T>
    {
        public bool HasNext();
        public T Next();
    }
}