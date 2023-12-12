using Composite;
using Iterator.Iterators;

namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuItem[] menuItemsArray = {
                new MenuItem("Вафли с клубникой", false),
                new MenuItem("Борщ", false),
                new MenuItem("Шашлык из курицы", false),
                new MenuItem("Блинчики с черникой", true)
            };

            List<MenuItem> menuItemsList = new(menuItemsArray);

            IIterator<MenuItem> arrayIterator = new MenuArray(menuItemsArray);
            IIterator<MenuItem> reverseListIterator = new MenuReverseList(menuItemsList);
            IIterator<MenuItem> veganIterator = new MenuVegan(menuItemsList);

            Console.WriteLine("Меню :");
            PrintMenu(arrayIterator);

            Console.WriteLine("\nОбратное меню:");
            PrintMenu(reverseListIterator);

            Console.WriteLine("\nВеганское меню :");
            PrintMenu(veganIterator);
        }

        static void PrintMenu(IIterator<MenuItem> iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = iterator.Next();
                menuItem.Print();
            }
        }
    }
}