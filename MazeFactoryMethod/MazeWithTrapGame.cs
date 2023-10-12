using MazeLibrary;

namespace MazeFactoryMethod
{
    internal class MazeWithTrapGame : MazeGame
    {
        public override Room CreateRoom(int roomNumber)
        {
            return new RoomWithTrap(roomNumber);
        }
    }
}