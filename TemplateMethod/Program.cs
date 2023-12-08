namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coffee coffee = new(true);
            coffee.Make();

            Tea tea = new();
            tea.Make();
        }
    }
}