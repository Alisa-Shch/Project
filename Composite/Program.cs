using System.Collections;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PancakeMenu pancakeMenu = new();
            List<Menu> breakfastItems = pancakeMenu.getMenuItems();

            DinerMenu diner = new();
            Menu[] lunchItems = diner.getMenuItems();

            for (int i = 0; i < breakfastItems.Count; i++)
            {
                Menu menuItem = breakfastItems[i];
                Console.WriteLine($"{menuItem.getName()}: {menuItem.getDescription()} \t{menuItem.getPrice()}");
            }

            for (int i = 0; i < lunchItems.Length; i++)
            {
                Menu menuItem = lunchItems[i];
                Console.WriteLine($"{menuItem.getName()}: {menuItem.getDescription()} \t{menuItem.getPrice()}");
            }
        }
    }
}