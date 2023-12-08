namespace Strategy
{
    internal class RubberDuck : Duck
    {
        public RubberDuck() : base(new NoFly(), new NoQuack(), new Swim()) { }
    }
}