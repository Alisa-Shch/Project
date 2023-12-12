using Composite;

namespace Iterator.Iterators
{
    internal class MenuArray : IIterator<MenuItem>
    {
        private MenuItem[] _menuItems;
        private int _item;

        public MenuArray(MenuItem[] menuItems)
        {
            _menuItems = menuItems;
            _item = 0;
        }

        public bool HasNext()
        {
            return _menuItems.Length > _item;
        }

        public MenuItem Next()
        {
            if (HasNext())
            {
                return _menuItems[_item++];
            }
            else
            {
                throw new InvalidOperationException("Блюд больше нет");
            }
        }
    }
}