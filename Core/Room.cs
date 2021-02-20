using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Room : MapSite

    {
        public int RoomNo { get; set; }
        private MapSite[] mapSites { get; set; }



        public Room(int roomNo)
        {
            this.RoomNo = roomNo;
            mapSites = new MapSite[4];
        }

        public MapSite GetSide(Direction direction) {
            return mapSites[(int)direction];
        }

        public void SetSide(Direction direction, MapSite mapSite)
        {
            mapSites[(int)direction] = mapSite;
        }
    }

    
}
