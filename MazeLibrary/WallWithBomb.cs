namespace MazeLibrary
{
    public class WallWithBomb : Wall
    {
        private static bool IsDestroyed;

        public static void SetIsDestroyed(bool isDestroyed)
        {
            IsDestroyed = isDestroyed;
        }

        public override void Enter()
        {
            if (IsDestroyed)
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