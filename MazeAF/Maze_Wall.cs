using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeAF
{
    internal class Maze
    {
        readonly Dictionary<int, Room> rooms = new Dictionary<int, Room>();

        void AddRoom(Room room)
        {
            rooms[room.RoomNumber] = room;
        }

        Room RoomNo(int roomN)
        {
            return rooms.ContainsKey(roomN) ? rooms[roomN] : null;
        }
    }

    internal class Wall : IMapSite
    {
        public virtual void Enter()
        {
            Console.WriteLine("Вы врезались в стену");
        }
    }
}