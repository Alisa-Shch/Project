namespace Composite
{
    internal class MenuItem : MenuComponent
    {
        private string _name;
        private bool _isVegan;

        public MenuItem(string name, bool isVegan)
        {
            _name = name;
            _isVegan = isVegan;
        }

        public override void Print()
        {
            string isVegan = _isVegan ? "(Веганское блюдо)" : "";
            Console.WriteLine($"- {_name} {isVegan}");
        }

        public override void Add(MenuComponent component)
        {
            throw new InvalidOperationException("Нельзя добавить к блюду");
        }

        public override void Remove(MenuComponent component)
        {
            throw new InvalidOperationException("Нельзя удалить из блюда");
        }
    }
}