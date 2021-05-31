using Core;
using GOF.FluentBuilder.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.Builder
{
    public  class StandardMazeBuilder : InitilizeMaze, IMakeRoom  , IMakeDoor, IProduceMaze
    {
        private StandardMazeBuilder()
        {

        }
        public static InitilizeMaze Initialize()
        {
            return new StandardMazeBuilder();
        }
        private Maze maze { get; set; }
        public virtual IMakeRoom InitilizeMaze()
        {
            maze = new Maze();
            return this;
        }
        public virtual Wall MakeWall()
        { return new Wall(); }
        public virtual IMakeDoor MakeRoom(int n)
        {
            Room r = new Room(n);
            r.SetSide(Direction.E, new Wall());
            r.SetSide(Direction.W, new Wall());
            r.SetSide(Direction.N, new Wall());
            r.SetSide(Direction.S, new Wall());
            maze.Rooms[n] = r;
            return this;
        }
        public virtual IProduceMaze MakeDoor(int r1No, int r2No)
        {
            Room r1 = maze.Rooms[r1No];
            Room r2 = maze.Rooms[r2No];

            Door door = new Door(r1, r2);
            r1.SetSide(Direction.E, door);
            r2.SetSide(Direction.W, door);
            return this;
        }

        public virtual Maze GetMaze()
        {
            return maze;
        }

    }
}
