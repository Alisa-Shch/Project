namespace Composite
{
    public class Menu
    {
        private string _name;
        private string _description;
        private double _price;

        public Menu(string name, string description, double price)
        {
            _name = name;
            _description = description;
            _price = price;
        }

        public string getName()
        {
            return _name;
        }

        public string getDescription()
        {
            return _description;
        }

        public double getPrice()
        {
            return _price;
        }
    }
}