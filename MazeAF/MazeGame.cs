using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeAF
{
    internal class MazeGame
    {
        public void MazeCreate()
        {
            MazeFactory factory = new MazeFactory();
            MazeFactory factoryW = new MazeWithBombFactory();

            Room r1 = factory.CreateRoom(1);
            Room r2 = factoryW.CreateRoom(2);
            Door door = factory.CreateDoor(r1, r2);

            r1.Enter();
            door.Enter();
            door.OtherSideFrom(r1).Enter();
        }
    }
}