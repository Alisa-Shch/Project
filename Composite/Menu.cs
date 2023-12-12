namespace Composite
{
    public class Menu : MenuComponent
    {
        private List<MenuComponent> _menuComponents = new();
        private string _name;

        public Menu(string name)
        {
            _name = name;
        }

        public override void Print()
        {
            Console.WriteLine($"Меню {_name}:");
            _menuComponents.ForEach(component => component.Print());
        }

        public override void Add(MenuComponent component)
        {
            ArgumentNullException.ThrowIfNull(component);

            _menuComponents.Add(component);
        }

        public override void Remove(MenuComponent component)
        {
            ArgumentNullException.ThrowIfNull(component);

            if (!_menuComponents.Contains(component))
            {
                throw new InvalidOperationException("Указанный компонент не найден в меню");
            }

            _menuComponents.Remove(component);
        }
    }
}