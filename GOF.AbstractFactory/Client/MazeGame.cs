using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.AbstractFactory
{
   public class MazeGame
    {

        /// <summary>
        /// you can pass any type that innhirt from Mazefactory abstract class     (like magicMAzeFactory)
        /// </summary>
        /// <param name="mazeFactory"></param>
        public MazeGame(MazeFactory mazeFactory)
        {
            Maze maze = mazeFactory.MakeMaze();
            Room r1 = mazeFactory.MakeRoom(1);
            Room r2 = mazeFactory.MakeRoom(2);

            Door door = mazeFactory.MakeDoor(r1, r2);

            maze.AddRoom(r1);
            maze.AddRoom(r2);

            r1.SetSide(Direction.N, mazeFactory.MakeWall());
            r1.SetSide(Direction.E, door);
            r1.SetSide(Direction.W, mazeFactory.MakeWall());
            r1.SetSide(Direction.N, mazeFactory.MakeWall());
            r2.SetSide(Direction.S, mazeFactory.MakeWall());
            r2.SetSide(Direction.N, mazeFactory.MakeWall());
            r2.SetSide(Direction.E, mazeFactory.MakeWall());
            r2.SetSide(Direction.W, door);

            // maze
        }
    }
}
