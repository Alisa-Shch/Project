using MazeLibrary;

namespace MazeFactoryMethod
{
    internal class MazeWithTrapGame : MazeGame
    {
        protected override Room CreateRoom(int roomNumber)
        {
            if (roomNumber < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(roomNumber), "Комната с отрицательным номером не может существовать");
            }
            return new RoomWithTrap(roomNumber);
        }
    }
}