using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.Builder
{
    public abstract class StandardMazeBuilder
    {
        private Maze maze { get; set; }
        public virtual void MakeMaze()
        {
            maze = new Maze();
        }
        public virtual Wall MakeWall()
        { return new Wall(); }
        public virtual void MakeRoom(int n)
        {
            Room r = new Room(n);
            r.SetSide(Direction.E, new Wall());
            r.SetSide(Direction.W, new Wall());
            r.SetSide(Direction.N, new Wall());
            r.SetSide(Direction.S, new Wall());
            maze.Rooms[n] = r;
        }
        public virtual void MakeDoor(int r1No, int r2No)
        {
            Room r1 = maze.Rooms[r1No];
            Room r2 = maze.Rooms[r2No];

            Door door = new Door(r1, r2);
            r1.SetSide(Direction.E, door);
            r2.SetSide(Direction.W, door);
        }

        public virtual Maze GetMaze()
        {
            return maze;
        }

    }
}
