namespace Visitor
{
    internal class Section : Component
    {
        private string _name;

        public Section(string name)
        {
            _name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public override void Add(Component component)
        {
            if (component == null)
            {
                throw new ArgumentNullException(nameof(component), "Недопустимое значение");
            }
            Components.Add(component);
        }

        public override void Remove(Component component)
        {
            if (component == null)
            {
                throw new ArgumentNullException(nameof(component));
            }
            if (!Components.Contains(component))
            {
                throw new InvalidOperationException("Компонент не найден");
            }

            Components.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine($"{_name}");
            foreach (var component in Components)
            {
                component.Print();
            }
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}