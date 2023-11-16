namespace Decorator
{
    internal class Coffee
    {
        protected string? _description;

        public virtual string? GetDescription()
        {
            return _description;
        }

        public virtual double Price() 
        { 
            return 0;
        }
    }
}