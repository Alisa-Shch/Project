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
            if (maze == null || room == null || wall == null || door == null)
            {
                throw new ArgumentNullException("Объект не существует");
            }

            _prototypeMaze = maze;
            _prototypeRoom = room;
            _prototypeWall = wall;
            _prototypeDoor = door;
        }

        public MazePrototypeFactory() 
            : this(new Maze(), new Room(), new Wall(), new Door()) { }

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