namespace Bridge
{
    public interface IImplementor
    {
        public int Power { get; }
        public int Mode { get; }

        public void On();
        public void Off();
        public void SetPower(int power);
        public void SetMode(int mode);
    }
}