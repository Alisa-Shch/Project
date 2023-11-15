using MazeLibrary;
using MazeAF;

namespace MazePrototype
{
    public class MazePrototypeFactory : MazeFactory        
    {
        private Maze _prototypeMaze;
        private Room _prototypeRoom;
        private Wall _prototypeWall;
        private Door _prototypeDoor;

        protected MazePrototypeFactory(Maze maze, Room room, Wall wall, Door door)
        {
            _prototypeMaze = maze.Initialize();
            _prototypeRoom = room.Initialize();
            _prototypeWall = wall.Initialize();
            _prototypeDoor = door.Initialize();
        }

        public override Maze CreateMaze()
        {
            return _prototypeMaze.Clone();
        }

        public Room CreateRoom()
        {
            return _prototypeRoom.Clone();
        }

        public override Wall CreateWall()
        {
            return _prototypeWall.Clone();
        }

        public Door CreateDoor()
        {
            return _prototypeDoor.Clone();
        }
    }
}