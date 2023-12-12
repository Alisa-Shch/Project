namespace Iterator
{
    internal interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }
}