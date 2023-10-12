using System;

namespace MazeLibrary
{
    public class Door : IMapSite
    {
        private static Random Rnd = new();

        private readonly bool _isOpen;
        private readonly Room _room1;
        private readonly Room _room2;

        public Door(Room room1, Room room2)
        {
            if (room1 == null || room2 == null)
            {
                throw new ArgumentException("Комнаты не существует");
            }

            _isOpen = Rnd.Next(2) == 0;

            _room1 = room1;
            _room2 = room2;
        }

        public Room OtherSideFrom(Room room)
        {
            if (room == _room1)
            {
                return _room2;
            }
            else if (room == _room2)
            {
                return _room1;
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