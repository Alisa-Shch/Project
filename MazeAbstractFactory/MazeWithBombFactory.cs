using MazeLibrary;

namespace MazeAF
{
    internal class MazeWithBombFactory : MazeFactory
    {
        public override Room CreateRoom(int roomNumber)
        {
            if (roomNumber < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(roomNumber), "Комната с отрицательным номером не может существовать");
            }
            return new RoomWithBomb(roomNumber);
        }

        public override Wall CreateWall()
        {
            return new WallWithBomb();
        }
    }
}