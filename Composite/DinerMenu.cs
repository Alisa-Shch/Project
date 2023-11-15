namespace Composite
{
    public class DinerMenu
    {
        private const int _max = 6;
        private Menu[] menuItems;
        private int _index = 0;

        public DinerMenu()
        {
            menuItems = new Menu[_max];
            addItem("Тост", "Бекон с листьями салата и помидорами на цельнозерновом хлебе", 2.99);
            addItem("Суп дня", "Суп  с гарниром из картофельного салата", 2.99);
            addItem("Хот-дог", "Хот-дог с квашеной капустой, соусом, луком, посыпанный сыром", 3.29);
        }

        private void addItem(string name, string description, double price)
        {
            if (_index >= _max-1)
            {
                throw new ArgumentException("Меню переполнено! Не удается добавить элемент в меню");
            }
            else
            {
                menuItems[_index++] = new Menu(name, description, price);
            }            
        }

        public Menu[] getMenuItems()
        {
            return menuItems;
        }
    }
}