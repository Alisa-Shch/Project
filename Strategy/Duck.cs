namespace Strategy
{
    internal abstract class Duck
    {
        public IFly FlyBehavior {  get; private set; }
        public IQuack QuackBehavior { get; private set; }
        public ISwim SwimBehavior { get; private set; }

        protected Duck(IFly fly, IQuack quack, ISwim swim)
        {
            FlyBehavior = fly;
            QuackBehavior = quack;
            SwimBehavior = swim;
        }

        public void Quack()
        {
            QuackBehavior.Execute();
        }

        public void Fly()
        {
            FlyBehavior.Execute();
        }

        public void Swim()
        {
            SwimBehavior.Execute();
        }
    }
}