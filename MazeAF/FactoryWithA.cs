using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeAF
{
    internal class MazeWithAFactory : MazeFactory
    {
        public override Room CreateRoom(int no)
        {
            return new RoomWithA(no);
        }
    }
}