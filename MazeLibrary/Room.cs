namespace MazeLibrary
{
    public class Room : IMapSite
    {
        internal int Number {  get; private set; }

        protected IMapSite[] _sides = new IMapSite[4];

        public Room(int roomNumber)
        {
            Number = roomNumber;
        }

        public IMapSite GetSide(Direction dir)
        {
            return _sides[(int)dir];
        }

        public void SetSide(Direction dir, IMapSite side)
        {
            _sides[(int)dir] = side;
        }

        public virtual void Enter()
        {
            Console.WriteLine($"Вы в комнате {Number}");
        }
    }
}