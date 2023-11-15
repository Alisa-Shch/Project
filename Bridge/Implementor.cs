namespace Bridge
{
    internal abstract class Implementor
    {
        public abstract void On();
        public abstract void Off();
        public abstract void SetPower(int power);
        public abstract void SetMode(int mode);
    }
}