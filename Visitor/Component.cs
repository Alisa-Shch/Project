namespace Visitor
{
    internal abstract class Component
    {
        public List<Component> Components = new();
        public int i;

        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract void Print();
        public abstract void Accept(IVisitor visitor);

        public Component Next()
        {
            if (!Components[i].IsNext())
            {
                i++;
            }
            if (Components.Count == i)
            {
                i++;
                return this;
            }

            return Components[i].IsNext() ? Components[i].Next() : throw new Exception("Конец");
        }

        public bool IsNext()
        {
            return Components.Count >= i;
        }
    }
}