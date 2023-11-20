namespace Composite
{
    internal class MenuSection : MenuComponent
    {
        private readonly List<MenuComponent> _menuComponents = new();
        private string _name;

        public MenuSection(string name)
        {
            _name = name;
        }

        public override void Print()
        {
            Console.WriteLine($"{_name}:");
            _menuComponents.ForEach(component => component.Print());
        }

        public override void Add(MenuComponent component)
        {
            ArgumentNullException.ThrowIfNull(nameof(component), "Компонент не существует");

            _menuComponents.Add(component);
        }

        public override void Remove(MenuComponent component)
        {
            ArgumentNullException.ThrowIfNull(component);

            if (!_menuComponents.Contains(component))
            {
                throw new InvalidOperationException("Указанный компонент не найден в секции");
            }

            _menuComponents.Remove(component);
        }
    }
}