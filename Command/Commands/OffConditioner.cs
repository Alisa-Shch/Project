namespace Command.Commands
{
    internal class OffConditioner : ICommand
    {
        private Conditioner _conditioner;

        public OffConditioner(Conditioner conditioner)
        {
            _conditioner = conditioner ?? throw new ArgumentNullException(nameof(conditioner));
        }

        public void Execute()
        {
            _conditioner.Off();
        }
    }
}