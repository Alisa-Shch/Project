using System;

namespace MazeLibrary
{
    public class Door : IMapSite
    {
        private static Random Rnd = new Random();

        private readonly bool _isOpen;

        private readonly Room _Room1;
        private readonly Room _Room2;

        public Door(Room room1, Room room2)
        {
            _isOpen = Rnd.Next(2) == 0 ? true : false;

            _Room1 = room1;
            _Room2 = room2;
        }

        public Room OtherSideFrom(Room room)
        {
            if (room == _Room1)
            {
                return _Room2;
            }
            else if (room == _Room2)
            {
                return _Room1;
            }
            else
            {
                throw new ArgumentException("Комнаты не существует");
            }
        }

        public virtual void Enter()
        {
            if (_isOpen)
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