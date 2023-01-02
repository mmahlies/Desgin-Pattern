using Core;
using Core.Models.MagicModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.FactoryMethod
{
  public  class MagicMazeGame     :MazeGame
    {

        public override Maze MakeMaze()
        {
            return new MagicMaze();
        }
        public override Wall MakeWall()
        { return new MagicWall(); }
        public override Room MakeRoom(int n)
        { return new MagicRoom(n); }
        public override Door MakeDoor(Room r1, Room r2)
        { return new MagicDoor((MagicRoom)r1, (MagicRoom)r2); }
        public MagicMazeGame()
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
