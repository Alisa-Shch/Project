namespace Bridge
{
    internal class Remote
    {
        protected IImplementor Implementor { get; private set; }
        public int Power { get; private set; }
        public int Mode { get; private set; }

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
            Implementor.SetPower(++Power);
        }

        public virtual void PowerMinus()
        {
            Implementor.SetPower(--Power);
        }

        public virtual void ModeNext()
        {
            Implementor.SetMode(++Mode);
        }

        public virtual void ModePreview()
        {
            Implementor.SetMode(--Mode);
        }
    }
}