using MazeLibrary;

namespace MazePrototype
{
    public class MazePrototypeWithBombFactory : MazePrototypeFactory
    {
        protected MazePrototypeWithBombFactory()
            : base(new Maze(), new RoomWithBomb(), new WallWithBomb(), new Door()) { }
    }
}