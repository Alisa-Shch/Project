using MazeAF;

namespace MazeSingleton
{
    public class SingletonMazeFactory : MazeFactory
    {
        private static SingletonMazeFactory? _instance;

        private SingletonMazeFactory() { }

        public static SingletonMazeFactory Instance
        {
            get
            {
                _instance ??= new SingletonMazeFactory();
                return _instance;
            }
        }
    }
}