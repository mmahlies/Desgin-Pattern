using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
  public  class Maze
    {
        public Room[] Rooms{ get; set; }

        public Maze()
        {

        }

        public void AddRoom(Room room)
        {
            this.Rooms[room.RoomNo] = room;
        }
    }
}
