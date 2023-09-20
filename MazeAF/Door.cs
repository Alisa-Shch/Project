using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeAF
{
    internal class Door : IMapSite
    {
        //static Random rnd = new Random();

        protected readonly bool isOpen;

        protected readonly Room Room1;
        protected readonly Room Room2;

        public Door(Room room1, Room room2)
        {
            //isOpen = rnd.Next(2) == 0 ? true : false;
            isOpen = true;

            Room1 = room1;
            Room2 = room2;
        }

        public Room OtherSideFrom(Room room)
        {
            return room == Room1 ? Room2 : Room1;
        }

        public virtual void Enter()
        {
            if (isOpen)
            {
                Console.WriteLine("Вы прошли через дверь");
            }
            else
            {
                Console.WriteLine("Дверь закрыта");
            }
        }
    }
}