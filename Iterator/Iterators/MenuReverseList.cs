using Composite;

namespace Iterator.Iterators
{
    internal class MenuReverseList : IIterator<MenuItem>
    {
        private List<MenuItem> _menuItems;
        private int _item;

        public MenuReverseList(List<MenuItem> items)
        {
            _menuItems = items;
            _item = items.Count - 1;
        }

        public bool HasNext()
        {
            return _item >= 0;
        }

        public MenuItem Next()
        {
            if (HasNext())
            {
                return _menuItems[_item--];
            }
            else
            {
                throw new InvalidOperationException("Больше нет блюд");
            }
        }
    }
}