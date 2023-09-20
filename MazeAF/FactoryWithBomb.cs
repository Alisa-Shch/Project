using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeAF
{
    internal class MazeWithBombFactory : MazeFactory
    {
        public override Room CreateRoom(int no)
        {
            return new RoomWithBomb(no);
        }

        public override Wall CreateWall()
        {
            return new WallWithBomb();
        }
    }
}