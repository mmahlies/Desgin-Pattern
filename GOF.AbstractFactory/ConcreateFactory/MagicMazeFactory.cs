using Core;
using Core.Models.MagicModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.AbstractFactory
{
  public  class MagicMazeFactory    :MazeFactory
    {
        public virtual Maze MakeMaze()
        {
            // magic wall
            return new Maze();
        }
        public virtual Wall MakeWall()
        { return new MagicWall(); }
        public virtual Room MakeRoom(int n)
        { return new MagicRoom(n); }
        public virtual Door MakeDoor(MagicRoom r1, MagicRoom r2)
        { return new MagicDoor(r1, r2); }
    }
}
