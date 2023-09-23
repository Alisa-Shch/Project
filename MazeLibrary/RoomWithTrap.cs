namespace MazeLibrary
{
    public class RoomWithTrap : Room
    {
        private static Random Rnd = new();

        private readonly bool _isHungry;

        public RoomWithTrap(int roomNumber) : base(roomNumber)
        {
            _isHungry = Rnd.Next(2) == 0 ? true : false;
        }

        public override void Enter()
        {
            base.Enter();
            Console.WriteLine("В комнате тигр");
            if (_isHungry)
            {
                Console.WriteLine("Он голоден и пытается вас съест");
            }
            else
            {
                Console.WriteLine("Он оказался сытым, вы в безопасности");
            }
        }
    }
}