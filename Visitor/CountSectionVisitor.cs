namespace Visitor
{
    internal class CountSectionVisitor : IVisitor
    {
        public int SectionCount { get; private set; }

        public void Visit(Component component)
        {
            if (component is Section)
            {
                SectionCount++;
            }
        }

        public object GetResult()
        {
            return SectionCount;
        }
    }
}