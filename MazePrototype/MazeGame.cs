using MazeLibrary;

namespace MazePrototype
{
    public class MazeGame
    {
        public static Maze Create(MazePrototypeFactory prototypeFactory)
        {
            Room room1 = prototypeFactory.CreateRoom();
            Room room2 = prototypeFactory.CreateRoom();
            Door door = prototypeFactory.CreateDoor();
            Wall wall = prototypeFactory.CreateWall();

            room1.SetSide(Direction.North, door);
            room1.SetSide(Direction.South, wall);
            room1.SetSide(Direction.East, wall);
            room1.SetSide(Direction.West, wall);

            room2.SetSide(Direction.South, door);
            room2.SetSide(Direction.East, wall);
            room2.SetSide(Direction.West, wall);
            room2.SetSide(Direction.North, wall);

            Maze maze = prototypeFactory.CreateMaze();
            maze.AddRoom(room1);
            maze.AddRoom(room2);

            return maze;
        }
    }
}