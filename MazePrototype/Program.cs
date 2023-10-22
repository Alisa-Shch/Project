using MazeLibrary;

namespace MazePrototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var roomPrototype = new Room(1);
            var doorPrototype = new Door(new Room(1), new Room(2));

            var maze = MazeGame.Create(roomPrototype, doorPrototype);
        }
    }
}