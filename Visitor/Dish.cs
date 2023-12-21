namespace Visitor
{
    internal class Dish : Component
    {
        private string _name;
        private bool _isVegan;

        public Dish(string name, bool isVegan)
        {
            _name = name ?? throw new ArgumentNullException(nameof(name));
            _isVegan = isVegan;
        }

        public override void Add(Component component)
        {
            throw new InvalidOperationException("Блюдо не изменяется");
        }

        public override void Remove(Component component)
        {
            throw new InvalidOperationException("Блюдо не изменяется");
        }

        public override void Print()
        {
            string isVegan = _isVegan ? "(Веганское блюдо)" : "";
            Console.WriteLine($"{_name} {isVegan}");
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}