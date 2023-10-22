using MazeAF;

namespace MazeSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory1 = MazeGame.Create(SingletonMazeFactory.Instance);
            var factory2 = MazeGame.Create(SingletonMazeWithBombFactory.Instance);
            var factory3 = MazeGame.Create(SingletonMazeWithTrapFactory.Instance);
        }
    }
}