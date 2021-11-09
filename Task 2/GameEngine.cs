using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class GameEngine
    {
        private Map game_map;
         public Map GetMap
        {
            get { return game_map; }
            set { game_map = value; }
        }
        
       
       public  GameEngine()
        {
            game_map = new Map(10, 10, 15, 15, 3);
        }

        public bool MovePlayer(movementEnum movement)
        {
            if(game_map.GetPlayer.ReturnMove(movement) == movement)
            {
                //game_map.Create(TileType.Empty, game_map.GetPlayer.getX, game_map.GetPlayer.getY);
                //game_map.GetPlayer.Move(movement);
                //game_map.GetMaps[game_map.GetPlayer.getX, game_map.GetPlayer.getY] = game_map.GetPlayer;
                return true;
            }
            return false;
        }

        public string PlayerAttack(int Enemy)
        {
            bool EnemyInRange = false;

            foreach(Tile T in game_map.GetPlayer.tilevision)
            {
                if(T.getX == game_map.GetEnemies[Enemy].getX && (T.getY == game_map.GetEnemies[Enemy].getY))
                {
                    EnemyInRange = true;
                    break;
                }
            }
             
            if (EnemyInRange)
            {
                game_map.GetPlayer.attack(game_map.GetEnemies[Enemy]);
                return "You did attack"+game_map.GetPlayer.getdamage+" damage to a "+game_map.GetEnemies[Enemy].GetTileType
                +"they now have" + game_map.GetEnemies[Enemy].gethp + "HP";
            }
            else
            {
                return "Target was not in range";
            }
        }

        

        public override string ToString()
        {
           return game_map.DrawMap();
        }

    }
}
