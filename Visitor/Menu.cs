namespace Visitor
{
    internal class Menu : Component
    {
        private string _name;

        public Menu(string name)
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
                throw new InvalidOperationException("Блюдо не найдено");
            }

            Components.Remove(component);
        }

        public override void Print()
        {
            Console.WriteLine($"Меню \"{_name}\"");
            foreach (var component in Components)
            {
                component.Print();
            }
        }

        public override void Accept(IVisitor visitor)
        {
            foreach (var component in Components)
            {
                component.Accept(visitor);
            }
        }
    }
}