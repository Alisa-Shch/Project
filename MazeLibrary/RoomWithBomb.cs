namespace MazeLibrary
{
    public class RoomWithBomb : Room
    {
        private static Random Rnd = new();

        private readonly bool _IsDestroyed;

        public RoomWithBomb(int roomNumber) : base(roomNumber)
        {
            _IsDestroyed = Rnd.Next(2) == 0 ? true : false;
            WallWithBomb.SetIsDestroyed(_IsDestroyed);
        }

        public override void Enter()
        {
            base.Enter();
            if (_IsDestroyed)
            {
                Console.WriteLine("Бомба взорвалась");
            }
            else
            {
                Console.WriteLine("Бомба не взорвалась");
            }
        }
    }
}