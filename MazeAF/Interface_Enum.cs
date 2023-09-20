using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeAF
{
    internal enum Direction { North, South, East, West };

    internal interface IMapSite
    {
        void Enter();
    }
}