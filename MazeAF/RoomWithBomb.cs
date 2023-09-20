using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeAF
{
    internal class RoomWithBomb : Room
    {
        static Random rnd = new Random();

        internal readonly bool IsDestroyed;

        public RoomWithBomb(int roomNumber) : base(roomNumber)
        {
            IsDestroyed = rnd.Next(2) == 0 ? true : false;
            WallWithBomb.isD(IsDestroyed);
        }

        public override void Enter()
        {
            base.Enter();
            if (IsDestroyed)
            {
                Console.WriteLine("Бомба взорвалась");
            }
            else
            {
                Console.WriteLine("Бомба не взорвалась");
            }
        }
    }
}