using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.FactoryMethod
{
  public abstract  class MazeGame
    {
        // factory methods
        public virtual Maze MakeMaze()
        {
            return new Maze();
        }
        public virtual Wall MakeWall()
        { return new Wall(); }
        public virtual Room MakeRoom(int n)
        { return new Room(n); }
        public virtual Door MakeDoor(Room r1, Room r2)
        { return new Door(r1, r2); }
        public MazeGame()
        {
            Maze maze = MakeMaze();
            Room r1 = MakeRoom(1);
            Room r2 = MakeRoom(2);

            Door door = MakeDoor(r1, r2);

            maze.AddRoom(r1);
            maze.AddRoom(r2);

            r1.SetSide(Direction.N, MakeWall());
            r1.SetSide(Direction.E, door);
            r1.SetSide(Direction.W, MakeWall());
            r1.SetSide(Direction.N, MakeWall());
            r2.SetSide(Direction.S, MakeWall());
            r2.SetSide(Direction.N, MakeWall());
            r2.SetSide(Direction.E, MakeWall());
            r2.SetSide(Direction.W, door);

            // maze
        }
    }
}
