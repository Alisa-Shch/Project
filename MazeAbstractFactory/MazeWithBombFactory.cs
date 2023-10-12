using MazeLibrary;

namespace MazeAF
{
    internal class MazeWithBombFactory : MazeFactory
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