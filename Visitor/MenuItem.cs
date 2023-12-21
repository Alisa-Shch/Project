namespace Visitor
{
    internal class MenuItem : Component
    {
        public string Name { get; private set; }
        public bool IsVegan { get; private set; }

        public MenuItem(string name, bool isVegan)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            IsVegan = isVegan;
        }

        public override void Add(Component component)
        {
            throw new InvalidOperationException("Нельзя добавить к блюду");
        }

        public override void Print()
        {
            string isVegan = IsVegan ? "(Веганское блюдо)" : "";
            Console.WriteLine($"{Name} {isVegan}");
        }

        public override void Remove(Component component)
        {
            throw new InvalidOperationException("Нельзя удалить из блюда");
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}