namespace Visitor
{
    internal class CountVeganVisitor : IVisitor
    {
        public int VeganCount { get; private set; }

        public void Visit(Component component)
        {
            if (component is MenuItem menuItem && menuItem.IsVegan)
            {
                VeganCount++;
            }
        }

        public object GetResult()
        {
            return VeganCount;
        }
    }
}