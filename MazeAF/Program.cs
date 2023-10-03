namespace MazeAF
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory1 = MazeGame.Create(new MazeFactory());
            var factory2 = MazeGame.Create(new MazeWithBombFactory());
            var factory3 = MazeGame.Create(new MazeWithTrapFactory());
        }
    }
}