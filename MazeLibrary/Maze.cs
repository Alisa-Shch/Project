namespace MazeLibrary
{
    public class Maze
    {
        private readonly Dictionary<int, Room> _rooms = new();

        public void AddRoom(Room room)
        {
            _rooms[room.Number] = room;
        }

        public Room? RoomNo(int roomN)
        {
            return _rooms.ContainsKey(roomN) ? _rooms[roomN] : null;
        }
    }
}