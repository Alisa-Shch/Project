namespace MazeSingleton
{
    public class SingletonMazeWithBombFactory : SingletonMazeFactory
    {
        private static SingletonMazeWithBombFactory? _instance;

        private SingletonMazeWithBombFactory() { }

        public new static SingletonMazeWithBombFactory Instance
        {
            get
            {
                _instance ??= new SingletonMazeWithBombFactory();
                return _instance;
            }
        }
    }
}