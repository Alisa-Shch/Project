namespace MazeSingleton
{
    internal class SingletonMazeWithTrapFactory : SingletonMazeFactory
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