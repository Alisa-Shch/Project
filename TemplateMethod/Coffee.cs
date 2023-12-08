namespace TemplateMethod
{
    internal class Coffee : Drink
    {
        private bool _isAddish;

        public Coffee(bool isAddish)
        {
            _isAddish = isAddish;
        }

        protected override void Brew()
        {
            Console.WriteLine("Завариваем кофе");
        }

        protected override void AddСomponents()
        {
            Console.WriteLine("Добавляем молоко");
        }

        protected override bool IsAddish()
        {
            return _isAddish;
        }
    }
}