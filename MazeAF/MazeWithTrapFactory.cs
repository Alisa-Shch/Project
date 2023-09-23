using MazeLibrary;

namespace MazeAF
{
    internal class MazeWithTrapFactory : MazeFactory
    {
        public override Room CreateRoom(int roomNumber)
        {
            return new RoomWithTrap(roomNumber);
        }
    }
}