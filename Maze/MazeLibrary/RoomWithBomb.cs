namespace MazeLibrary
{
    public class RoomWithBomb : Room
    {
        private static Random Rnd = new();

        private readonly bool _isDestroyed;

        public RoomWithBomb(int roomNumber) : base(roomNumber)
        {
            _isDestroyed = Rnd.Next(2) == 0;
        }

        public override void Enter()
        {
            base.Enter();
            if (_isDestroyed)
            {
                Console.WriteLine("Бомба взорвалась");
            }
            else
            {
                Console.WriteLine("Бомба не взорвалась");
            }
        }

        public override Room Clone()
        {
            return new RoomWithBomb(Number);
        }
    }
}