using MazeLibrary;
using MazeAF;

namespace MazePrototype
{    
    internal class MazePrototypeFactory : MazeFactory
    {
        private Maze _prototypeMaze;
        private Room _prototypeRoom;
        private Wall _prototypeWall;
        private Door _prototypeDoor;

        public MazePrototypeFactory(Maze prototypeMaze, Room prototypeRoom, Wall prototypeWall, Door prototypeDoor)
        {
            _prototypeMaze = prototypeMaze;
            _prototypeRoom = prototypeRoom;
            _prototypeWall = prototypeWall;
            _prototypeDoor = prototypeDoor;
        }

        public override Maze CreateMaze()
        {
            return _prototypeMaze.Clone();
        }

        public override Room CreateRoom(int roomNumber)
        {
            if (roomNumber < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(roomNumber), "Комната с отрицательным номером не может существовать");
            }
            var room = _prototypeRoom.Clone();
            room.Initialize(roomNumber);
            return room;
        }

        public override Wall CreateWall()
        {
            return _prototypeWall.Clone();
        }

        public override Door CreateDoor(Room room1, Room room2)
        {
            if (room1 == null || room2 == null)
            {
                throw new ArgumentNullException("Комнаты не существует");
            }
            var door = _prototypeDoor.Clone();
            door.Initialize(room1, room2);
            return door;
        }
    }
}