using System;

namespace Core
{
  public     class MagicMapSite        :MapSite
    {
        /// <summary>
        //*
        //        Enter provides a simple basis for more sophisticated gameoperations.For example,
        //if you are in a room and say "Go East," thegame can simply determine which MapSite
        //is immediately to theeast and then call Enter on it.The subclass-specificEnter
        //operation will figure out whether your location changedor your nose got hurt.        
        /// </summary>
        public virtual void Enter()
        {
        }
    }



}
