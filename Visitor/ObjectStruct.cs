using System.Xml.Linq;

namespace Visitor
{
    internal class ObjectStruct
    {
        private Component _root;

        public ObjectStruct(Component root)
        {
            _root = root ?? throw new ArgumentNullException(nameof(root));
        }

        public void Accept(IVisitor visitor)
        {
            List<Component> components = new();
            Component? root = _root;

            while (root != null || components.Count > 0)
            {
                while (root != null)
                {
                    components.Add(root);
                    root = root.IsNext() ? root.Next() : null;
                }

                int lastIndex = components.Count - 1;
                root = components[lastIndex];
                components.RemoveAt(lastIndex);

                root.Accept(visitor);
                root = root.IsNext() ? root.Next() : null;
            }
        }
    }
}