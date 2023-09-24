namespace MazeLibrary
{
    public class MazeWithTrap : Maze
    {
        private readonly Dictionary<int, RoomWithTrap> _rooms = new();

        public void AddRoom(RoomWithTrap room)
        {
            _rooms[room.Number] = room;
        }

        public new RoomWithTrap? RoomNo(int roomNumber)
        {
            return (_rooms.ContainsKey(roomNumber) ? _rooms[roomNumber] : null);
        }
    }
}