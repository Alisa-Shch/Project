namespace Command.Commands
{
    internal class OnLight : ICommand
    {
        private Light _light;

        public OnLight(Light light)
        {
            _light = light ?? throw new ArgumentNullException(nameof(light));
        }

        public void Execute()
        {
            _light.On();
        }
    }
}