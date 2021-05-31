using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.Builder
{
    public class MazeGame
    {
   
        public MazeGame(StandardMazeBuilder builder)
        {
            builder.MakeMaze();
            builder.MakeRoom(0);
            builder.MakeRoom(1);
            builder.MakeDoor(0, 1);
            builder.GetMaze();

            // maze
        }
    }
}
