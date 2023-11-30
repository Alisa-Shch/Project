using MazeLibrary;
using System.Xml.Linq;

namespace MazeAF
{
    public class MazeFactory
    {
        public virtual Room CreateRoom(int roomNumber)
        {
            if (roomNumber < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(roomNumber), "Комната с отрицательным номером не может существовать");
            }
            return new Room(roomNumber);
        }

        public virtual Door CreateDoor(Room room1, Room room2)
        {
            if (room1 == null || room2 == null)
            {
                throw new ArgumentNullException("Комнаты не существует");
            }
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