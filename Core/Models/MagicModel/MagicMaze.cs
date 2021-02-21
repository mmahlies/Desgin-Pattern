using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models.MagicModel
{
  public  class MagicMaze    :Maze
    {
        public MagicRoom[] Rooms{ get; set; }

      

        public void AddRoom(MagicRoom room)
        {
            this.Rooms[room.RoomNo] = room;
        }
    }
}
