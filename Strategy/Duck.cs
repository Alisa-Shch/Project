namespace Strategy
{
    internal abstract class Duck
    {
        protected IFly _flyBehavior {  get; private set; }
        protected IQuack _quackBehavior { get; private set; }
        protected ISwim _swimBehavior { get; private set; }

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