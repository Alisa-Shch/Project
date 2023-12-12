using Composite;

namespace Iterator.Iterators
{
    internal class MenuVegan : IIterator<MenuItem>
    {
        private List<MenuItem> _menuItems;
        private int _item;

        public MenuVegan(List<MenuItem> items)
        {
            _menuItems = items;
            _item = 0;
        }

        public bool HasNext()
        {
            while (_item < _menuItems.Count && !_menuItems[_item].IsVegan)
            {
                _item++;
            }
            return _item < _menuItems.Count;
        }

        public MenuItem Next()
        {
            if (HasNext())
            {
                return _menuItems[_item++];
            }
            else
            {
                throw new InvalidOperationException("Больше нет веганских блюд");
            }
        }
    }
}