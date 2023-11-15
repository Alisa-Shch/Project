using System.Collections;

namespace Composite
{
    public class PancakeMenu
    {
        private List<Menu> menuItems;

        public PancakeMenu()
        {
            menuItems = new();
            addItem("Завтрак из блинов", "Блины с яичницей-болтуньей и тостами", 2.99);
            addItem("Обычный блинный завтрак", "Блины с яичницей-глазуньей и колбасой", 2.99);
            addItem("Блинчики с черникой", "Блины со свежей черникой", 3.49);
            addItem("Вафли", "Вафли с черникой или клубникой", 3.59);
        }

        private void addItem(string name, string description, double price)
        {
            menuItems.Add(new Menu(name, description, price));
        }

        public List<Menu> getMenuItems()
        {
            return menuItems;
        }
    }
}