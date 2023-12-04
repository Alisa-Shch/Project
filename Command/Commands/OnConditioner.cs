namespace Command.Commands
{
    internal class OnConditioner : ICommand
    {
        private Conditioner _conditioner;

        public OnConditioner(Conditioner conditioner)
        {
            _conditioner = conditioner ?? throw new ArgumentNullException(nameof(conditioner));
        }

        public void Execute()
        {
            _conditioner.On();
        }
    }
}