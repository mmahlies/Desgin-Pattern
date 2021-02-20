    using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
   public  class MazeGame
    {

        /// <summary>
        /// The real problem with this member function isn't
       // its size but its inflexibility.It hard-codes the maze layout.Changing the
       //layoutmeans changing this member function, either by overriding it—whichmeans
       //reimplementing the whole thing—or by changing parts ofit—which is error-prone
       //and doesn't promote reuse.
        /// </summary>
        /// <returns></returns>
        public Maze CreateMze() {
            Maze maze = new Maze();
            Room r1 = new Room(1);
            Room r2 = new Room(2);

            Door door1 = new Door(r1, r2);


            maze.AddRoom(r1);
            maze.AddRoom(r2);

            r1.SetSide(Direction.N, new Wall());
            r1.SetSide(Direction.E, door1);
            r1.SetSide(Direction.S, new Wall());
            r1.SetSide(Direction.W, new Wall());


            return maze;
        }
    }
}
