using MazeLibrary;

namespace MazePrototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var roomPrototype = new Room(1);
            var maze = MazeGame.Create(roomPrototype);
        }
    }
}