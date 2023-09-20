using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeAF
{
    internal class WallWithBomb : Wall
    {
        internal static bool IsDestroyed;

        public static void isD(bool isDestroyed)
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
                Console.WriteLine("Вы врезались в стену");
            }
        }
    }
}