using MazeLibrary;

namespace MazeFactoryMethod
{
    internal class MazeWithBombGame : MazeGame
    {
        public override Room CreateRoom(int roomNumber)
        {
            return new RoomWithBomb(roomNumber);
        }

        public override Wall CreateWall()
        {
            return new WallWithBomb();
        }
    }
}