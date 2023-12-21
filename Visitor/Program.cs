namespace Visitor
{
    class Program
    {
        static void Main()
        {
            MenuItem waffles = new("Вафли с клубникой", false);
            MenuItem vegetableSoup = new("Овощной суп", true);
            MenuItem borsch = new("Борщ", false);
            MenuItem caesarSalad = new("Салат Цезарь", false);
            MenuItem pancakes = new("Блинчики с черникой", true);
            MenuItem fruitPlatter = new("Фруктовое ассорти", true);

            Section dessertsSection = new("Десерты:");
            dessertsSection.Add(waffles);
            dessertsSection.Add(pancakes);

            Section healthyEatingSection = new("Здоровое питание:");
            healthyEatingSection.Add(caesarSalad);
            healthyEatingSection.Add(fruitPlatter);

            Section soupSection = new("Супы:");
            soupSection.Add(borsch);
            soupSection.Add(vegetableSoup);

            Menu myMenu = new("Мое меню");
            myMenu.Add(dessertsSection);
            myMenu.Add(healthyEatingSection);
            myMenu.Add(soupSection);

            myMenu.Print();

            CountVeganVisitor countVeganVisitor = new();

            ObjectStruct objectStructure = new(myMenu);
            objectStructure.Accept(countVeganVisitor);

            Console.WriteLine($"Число блюд для веганов: {countVeganVisitor.GetResult()}");
        }
    }
}