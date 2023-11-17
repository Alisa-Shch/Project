namespace Bridge
{
    public interface IImplementor
    {
        public void On();
        public void Off();
        public void SetPower(int power);
        public void SetMode(int mode);
    }
}