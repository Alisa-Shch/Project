using MazeLibrary;

namespace MazeB
{
    internal class MazeWithBombBuilder : MazeBuilder
    {
        public override Maze GetMaze()
        {
            return new MazeWithBomb();
        }
    }
}