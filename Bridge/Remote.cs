namespace Bridge
{
    internal class Remote
    {
        protected IImplementor Implementor { get; private set; }

        public Remote(IImplementor implementor)
        {
            ArgumentNullException.ThrowIfNull(implementor);
            Implementor = implementor;
        }

        public void TurnOn()
        {
            Implementor.On();
        }

        public void TurnOff()
        {
            Implementor.Off();
        }

        public virtual void PowerPlus()
        {
            Implementor.SetPower(Implementor.Power + 1);
        }

        public virtual void PowerMinus()
        {
            Implementor.SetPower(Implementor.Power - 1);
        }

        public virtual void ModeNext()
        {
            Implementor.SetMode(Implementor.Mode + 1);
        }

        public virtual void ModePreview()
        {
            Implementor.SetMode(Implementor.Mode - 1);
        }
    }
}