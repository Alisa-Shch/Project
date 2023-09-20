using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeAF
{
    internal class Room : IMapSite
    {
        internal readonly int RoomNumber;

        IMapSite[] sides = new IMapSite[4];

        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
        }

        public IMapSite GetSide(Direction dir)
        {
            return sides[(int)dir];
        }

        public void SetSide(Direction dir, IMapSite side)
        {
            sides[(int)dir] = side;
        }

        public virtual void Enter()
        {
            Console.WriteLine($"Вы в комнате {RoomNumber}");
        }
    }
}