namespace Command
{
    internal class Multicommand : ICommand
    {
        private List<ICommand> _commands = new();

        public Multicommand(List<ICommand> commands) 
        {
            _commands.AddRange(commands);
        }

        public void Execute()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }
    }
}