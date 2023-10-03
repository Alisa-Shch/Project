namespace MazeLibrary
{
    public class WallWithBomb : Wall
    {
        private bool _isDestroyed;

        public void SetIsDestroyed(bool isDestroyed)
        {
            _isDestroyed = isDestroyed;
        }

        public override void Enter()
        {
            if (_isDestroyed)
            {
                Console.WriteLine("Стена разрушена");
            }
            else
            {
                base.Enter();
            }
        }
    }
}