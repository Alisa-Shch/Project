using MazeLibrary;

namespace MazeFactoryMethod
{
    internal class MazeGame
    {
        public Maze Create()
        {
            Room room1 = CreateRoom(1);
            Room room2 = CreateRoom(2);
            Door door = CreateDoor(room1, room2);
            Wall wall = CreateWall();

            room1.SetSide(Direction.North, door);
            room1.SetSide(Direction.South, wall);
            room1.SetSide(Direction.East, wall);
            room1.SetSide(Direction.West, wall);

            room2.SetSide(Direction.South, door);
            room2.SetSide(Direction.East, wall);
            room2.SetSide(Direction.West, wall);
            room2.SetSide(Direction.North, wall);

            Maze maze = CreateMaze();
            maze.AddRoom(room1);
            maze.AddRoom(room2);

            return maze;
        }

        public virtual Room CreateRoom(int roomNumber)
        {
            return new Room(roomNumber);
        }

        public virtual Door CreateDoor(Room room1, Room room2)
        {
            return new Door(room1, room2);
        }

        public virtual Wall CreateWall()
        {
            return new Wall();
        }

        public virtual Maze CreateMaze()
        {
            return new Maze();
        }
    }
}