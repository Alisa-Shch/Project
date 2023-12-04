namespace Command.Commands
{
    internal class OpenDoor : ICommand
    {
        private Door _door;

        public OpenDoor(Door door)
        {
            _door = door ?? throw new ArgumentNullException(nameof(door));
        }

        public void Execute()
        {
            _door.Open();
        }
    }
}