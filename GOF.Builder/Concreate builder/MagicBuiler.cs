using Core;
using Core.Models.MagicModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.Builder.Concreate_builder
{
    public class MagicBuiler : StandardMazeBuilder
    {
        private MagicMaze maze { get; set; }
        public MagicBuiler()
        {
            maze = new MagicMaze();
        }
        public override void BuildDoor(int r1No, int r2No)
        {
            MagicRoom r1 = maze.Rooms[r1No];
            MagicRoom r2 = maze.Rooms[r2No];

            MagicDoor door = new MagicDoor(r1, r2);
            r1.SetSide(Direction.E, door);
            r2.SetSide(Direction.W, door);
        }

        public override void BuildRoom(int n)
        {
            MagicRoom r = new MagicRoom(n);
            r.SetSide(Direction.E, new Wall());
            r.SetSide(Direction.W, new Wall());
            r.SetSide(Direction.N, new Wall());
            r.SetSide(Direction.S, new Wall());
            maze.Rooms[n] = r;
        }

    }
}
