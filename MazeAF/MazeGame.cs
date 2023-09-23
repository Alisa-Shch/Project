using MazeLibrary;

namespace MazeAF
{
    internal class MazeGame
    {
        public static Maze Create(MazeFactory factory)
        {
            Room r1 = factory.CreateRoom(1);
            Room r2 = factory.CreateRoom(2);
            Door door = factory.CreateDoor(r1, r2);

            Maze maze = new();
            maze.AddRoom(r1);
            maze.AddRoom(r2);

            return maze;
        }
    }
}