using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class GameEngine
    {
        private Map game_map;
        
        
        public bool MovePlayer()
        {
            return false;
        }
       public  GameEngine( Map map)
        {
            map = new Map(5, 10, 10, 15, 3);
        }

        
    }
}
