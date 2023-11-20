namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var waffles = new MenuItem("Вафли с клубникой", false);
            var borsch = new MenuItem("Борщ", false);
            var barbecue = new MenuItem("Шашлык из курицы", false);
            var pancakes = new MenuItem("Блинчики с черникой", true);

            var meatSection = new MenuSection("Мясо");
            meatSection.Add(barbecue);

            var soupsSection = new MenuSection("Супы");
            soupsSection.Add(borsch);

            var dessertsSection = new MenuSection("Десерты");
            dessertsSection.Add(pancakes);
            dessertsSection.Add(waffles);

            var menu = new Menu("Ресторан");
            menu.Add(meatSection);
            menu.Add(soupsSection);
            menu.Add(dessertsSection);

            menu.Print();
            Console.ReadLine();
        }
    }
}