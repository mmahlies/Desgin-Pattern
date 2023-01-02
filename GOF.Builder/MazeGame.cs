using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.Builder
{
    public class MazeGame
    {
   
        public MazeGame(StandardMazeBuilder builder)
        {
            builder.BuildMaze();
            builder.BuildRoom(0);
            builder.BuildRoom(1);
            builder.BuildDoor(0, 1);
            builder.GetMaze();

            // maze
        }
    }
}
