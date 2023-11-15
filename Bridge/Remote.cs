namespace Bridge
{
    internal class Remote
    {
        protected Implementor implementor { get; set; }
        public int Power { get; set; }
        public int Mode { get; set; }

        public Remote(Implementor implementor)
        {
            ArgumentNullException.ThrowIfNull(implementor);
            this.implementor = implementor;
        }

        public void TurnOn()
        {
            implementor.On();
        }

        public void TurnOff()
        {
            implementor.Off();
        }

        public virtual void PowerPlus()
        {
            implementor.SetPower(++Power);
        }

        public virtual void PowerMinus()
        {
            implementor.SetPower(--Power);
        }

        public virtual void ModeNext()
        {
            implementor.SetMode(++Mode);
        }

        public virtual void ModePreview()
        {
            implementor.SetMode(--Mode);
        }
    }
}