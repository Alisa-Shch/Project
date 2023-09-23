namespace MazeAF
{
    class Program
    {
        static void Main(string[] args)
        {
            var f1 = MazeGame.Create(new MazeFactory());
            var f2 = MazeGame.Create(new MazeWithBombFactory());
            var f3 = MazeGame.Create(new MazeWithTrapFactory());
        }
    }
}