using MazeLibrary;

namespace MazeAF
{
    internal class MazeFactory
    {
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