namespace MazeSingleton
{
    internal class SingletonMazeWithTrapFactory : MazeFactory
    {
        private static SingletonMazeWithTrapFactory? _instance;

        private SingletonMazeWithTrapFactory() { }

        public new static SingletonMazeWithTrapFactory Instance
        {
            get
            {
                _instance ??= new SingletonMazeWithTrapFactory();
                return _instance;
            }
        }
    }
}