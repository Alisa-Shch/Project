namespace MazeB
{
    class Program
    {
        static void Main(string[] args)
        {
            MazeGame.Create(new MazeBuilder());
            MazeGame.Create(new MazeWithBombBuilder());
            MazeGame.Create(new MazeWithTrapBuilder());
        }
    }
}