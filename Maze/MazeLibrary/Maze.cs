namespace MazeLibrary
{
    public class Maze
    {
        private readonly Dictionary<int, Room> _rooms = new();

        public void AddRoom(Room room)
        {
            if (room == null)
            {
                throw new ArgumentNullException(nameof(room), "Комнаты не существует");
            }
            _rooms[room.Number] = room;
        }

        public Room? RoomNo(int roomNumber)
        {
            if (roomNumber < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(roomNumber), "Комната с отрицательным номером не существует");
            }
            return _rooms.ContainsKey(roomNumber) ? _rooms[roomNumber] : null;
        }

        public Maze Clone()
        {
            return new Maze();
        }
    }
}