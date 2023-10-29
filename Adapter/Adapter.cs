namespace Adapter
{
    internal class Adapter : Duck
    {
        private Turkey _turkey;

        public Adapter(Turkey turkey)
        {
            _turkey = turkey;
        }

        public override void Quack()
        {
            _turkey.Gobble();
        }

        public override void Fly()
        {
            _turkey.Fly();
        }
    }
}