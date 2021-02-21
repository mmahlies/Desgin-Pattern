using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models.MagicModel
{
    public class MagicRoom : Room

    {
        public int RoomNo { get; set; }
        private MagicMapSite[] mapSites { get; set; }



        public MagicRoom(int roomNo)                   :base(roomNo)
        {
            this.RoomNo = roomNo;
            mapSites = new MagicMapSite[4];
        }

        public MagicMapSite GetSide(Direction direction) {
            return mapSites[(int)direction];
        }

        public void SetSide(Direction direction, MagicMapSite mapSite)
        {
            mapSites[(int)direction] = mapSite;
        }
    }

    
}
