namespace Strategy
{
    internal abstract class Duck
    {
        private IFly _flyBehavior;
        private IQuack _quackBehavior;
        private ISwim _swimBehavior;

        protected Duck(IFly fly, IQuack quack, ISwim swim)
        {
            _flyBehavior = fly;
            _quackBehavior = quack;
            _swimBehavior = swim;
        }

        public void Quack()
        {
            _quackBehavior.Execute();
        }

        public void Fly()
        {
            _flyBehavior.Execute();
        }

        public void Swim()
        {
            _swimBehavior.Execute();
        }
    }
}