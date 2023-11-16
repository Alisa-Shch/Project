namespace Decorator
{
    internal class Decorator : Coffee
    {
        public override string? GetDescription()
        {
            return _description;
        }
    }
}