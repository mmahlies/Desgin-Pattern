using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.Builder
{
    public class MazeGame
    {
   
        public MazeGame()
        {
            // at any step there are only one option so the client will flow this pattern
            Maze game = StandardMazeBuilder.Initialize()
               .InitilizeMaze()
                        .MakeRoom(1)
                        .MakeDoor(0, 1)
                        .GetMaze();

         

            // maze
        }
    }
}
