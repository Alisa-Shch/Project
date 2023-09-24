using MazeLibrary;

namespace MazeB
{
    internal class MazeWithTrapBuilder : MazeBuilder
    {
        public override Maze GetMaze()
        {
            return new MazeWithTrap();
        }
    }
}