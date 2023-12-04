namespace Command.Commands
{
    internal class OffLight : ICommand
    {
        private Light _light;

        public OffLight(Light light)
        {
            _light = light ?? throw new ArgumentNullException(nameof(light));
        }

        public void Execute()
        {
            _light.Off();
        }
    }
}