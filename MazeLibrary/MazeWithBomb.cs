namespace MazeLibrary
{
    public class MazeWithBomb : Maze  
    {
        private readonly Dictionary<int, RoomWithBomb> _rooms = new();

        public void AddRoom(RoomWithBomb room)
        {
            _rooms[room.Number] = room;
        }

        public new RoomWithBomb? RoomNo(int roomNumber)
        {
            return (_rooms.ContainsKey(roomNumber) ? _rooms[roomNumber] : null);
        }
    }
}