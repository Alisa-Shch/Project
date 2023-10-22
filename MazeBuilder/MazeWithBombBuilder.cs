using MazeLibrary;

namespace MazeB
{
    internal class MazeWithBombBuilder : MazeBuilder
    {
        private readonly Maze _maze = new();

        public new void BuildRoom(int roomNumber)
        {
            if (roomNumber < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(roomNumber), "Комната с отрицательным номером не может существовать");
            }
            RoomWithBomb room = new(roomNumber);

            room.SetSide(Direction.South, new WallWithBomb());
            room.SetSide(Direction.East, new WallWithBomb());
            room.SetSide(Direction.North, new WallWithBomb());
            room.SetSide(Direction.West, new WallWithBomb());

            _maze.AddRoom(room);
        }

        public new void BuildDoor(int roomNumber1, int roomNumber2)
        {
            if (roomNumber1 < 0 || roomNumber2 < 0)
            {
                throw new ArgumentOutOfRangeException("Комната с отрицательным номером не может существовать");
            }
            Room? room1 = _maze.RoomNo(roomNumber1);
            Room? room2 = _maze.RoomNo(roomNumber2);
            if (room1 == null || room2 == null)
            {
                throw new ArgumentNullException("Комнаты не существует");
            }
            Door door = new(room1, room2);
            room1.SetSide(Direction.South, door);
            room2.SetSide(Direction.North, door);
        }

        public override Maze GetMaze()
        {
            return _maze;
        }
    }
}