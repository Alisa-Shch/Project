﻿using MazeLibrary;

namespace MazeB
{
    internal class MazeWithTrapBuilder : MazeBuilder
    {
        private readonly Maze _maze = new();

        public new void BuildRoom(int roomNumber)
        {
            RoomWithTrap room = new(roomNumber);

            room.SetSide(Direction.South, new Wall());
            room.SetSide(Direction.East, new Wall());
            room.SetSide(Direction.North, new Wall());
            room.SetSide(Direction.West, new Wall());

            _maze.AddRoom(room);
        }

        public new void BuildDoor(int roomNumber1, int roomNumber2)
        {
            Room? room1 = _maze.RoomNo(roomNumber1);
            Room? room2 = _maze.RoomNo(roomNumber2);
            Door door = new(room1, room2);
            room1.SetSide(Direction.South, door);
            room2.SetSide(Direction.North, door);
        }

        public override Maze GetMaze()
        {
            return _maze;
        }
    }
}