using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models.MagicModel
{
    public class MagicDoor : Door
    {
        public bool isOpen{ get; set; }
        private MagicRoom Room1 { get; set; }
        private MagicRoom Room2 { get; set; }


        public MagicDoor(MagicRoom room1, MagicRoom room2)    :base(room1,room2)
        {
            this.Room1 = Room1;
            this.Room2 = Room2;

        }



    }
}
