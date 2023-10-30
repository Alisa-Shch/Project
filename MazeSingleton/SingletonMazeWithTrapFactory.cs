namespace MazeSingleton
{
    public class SingletonMazeWithTrapFactory : MazeFactory
    {
        private static SingletonMazeWithTrapFactory? _instance;

        private SingletonMazeWithTrapFactory() { }

        public static SingletonMazeWithTrapFactory Instance
        {
            get
            {
                _instance ??= new SingletonMazeWithTrapFactory();
                return _instance;
            }
        }
    }
}