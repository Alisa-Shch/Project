namespace Strategy
{
    internal class WildDuck : Duck
    {
        public WildDuck() : base(new Fly(), new Quack(), new Swim()) { }
    }
}