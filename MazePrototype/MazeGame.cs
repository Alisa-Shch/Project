using MazeLibrary;

namespace MazePrototype
{
    internal class MazeGame
    {
        public static Maze Create(Room roomPrototype, Door doorPrototype)
        {
            Room room1 = roomPrototype.Clone();
            Room room2 = roomPrototype.Clone();
            Door door = doorPrototype.Clone();
            Wall wall = new();

            room1.SetSide(Direction.North, door);
            room1.SetSide(Direction.South, wall);
            room1.SetSide(Direction.East, wall);
            room1.SetSide(Direction.West, wall);

            room2.SetSide(Direction.South, door);
            room2.SetSide(Direction.East, wall);
            room2.SetSide(Direction.West, wall);
            room2.SetSide(Direction.North, wall);

            Maze maze = new();
            maze.AddRoom(room1);
            maze.AddRoom(room2);

            return maze;
        }
    }
}