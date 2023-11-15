using MazeLibrary;

namespace MazePrototype
{
    public class MazePrototypeWithTrapFactory : MazePrototypeFactory
    {
        protected MazePrototypeWithTrapFactory()
        : base(new Maze(), new RoomWithTrap(), new Wall(), new Door())
        { }
    }
}