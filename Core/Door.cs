using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Door :MapSite
    {
        public bool isOpen{ get; set; }
        private MapSite Room1 { get; set; }
        private MapSite Room2 { get; set; }


        public Door(MapSite room1, MapSite room2)
        {
            this.Room1 = Room1;
            this.Room2 = Room2;

        }



    }
}
