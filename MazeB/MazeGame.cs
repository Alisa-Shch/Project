namespace MazeB
{
    internal class MazeGame
    {
        public static void Create(MazeBuilder builder)
        {
            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1, 2);
        }
    }
}