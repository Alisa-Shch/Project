namespace MazeFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var method1 = new MazeGame();
            var maze1 = method1.Create();

            var method2 = new MazeWithBombGame();
            var maze2 = method2.Create();

            var method3 = new MazeWithTrapGame();
            var maze3 = method3.Create();
        }
    }
}