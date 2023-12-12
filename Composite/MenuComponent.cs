namespace Composite
{
    public abstract class MenuComponent
    {
        public abstract void Print();

        public abstract void Add(MenuComponent component);

        public abstract void Remove(MenuComponent component);
    }
}