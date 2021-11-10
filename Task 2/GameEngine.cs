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
            game_map = new Map(10, 10, 15, 15, 3,2);
        }

        public void MovePlayer(movementEnum movement)
        {
            switch (movement)
            {
                case movementEnum.Up:
                game_map.GetPlayer.Move(game_map.GetPlayer.ReturnMove(movementEnum.Up));
                    break;

                case movementEnum.Down:
                    game_map.GetPlayer.Move(game_map.GetPlayer.ReturnMove(movementEnum.Down));
                    break;

                case movementEnum.Left:
                    game_map.GetPlayer.Move(game_map.GetPlayer.ReturnMove(movementEnum.Left));
                    break;

                case movementEnum.Right:
                    game_map.GetPlayer.Move(game_map.GetPlayer.ReturnMove(movementEnum.Right));
                    break;
            }
           
        }

        public void MoveEnemies(movementEnum movement)
        {
            for (int i = 0; i < game_map.GetEnemies.Length; i++)
            {
                game_map.GetEnemies[i].Move(game_map.GetEnemies[i].ReturnMove(movement));
            }
            EnemyAttack();
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
                return "You did attack "+game_map.GetPlayer.getdamage+" damage to a "+game_map.GetEnemies[Enemy].GetType().Name
                +" they now have " + game_map.GetEnemies[Enemy].gethp + " HP";
            }
            else
            {
                return "Target was not in range";
            }
        }

        public void EnemyAttack()
        {
            for (int i = 0; i < game_map.GetEnemies.Length; i++)
            {
                
                switch (game_map.GetEnemies[i].getsymbol)
                {
                    case 'G':
                        foreach (Tile T in game_map.GetEnemies[i].tilevision)
                        {
                            if (T.getX == game_map.GetPlayer.getX && (T.getY == game_map.GetPlayer.getY))
                            {
                                game_map.GetEnemies[i].attack(game_map.GetPlayer);
                            }
                        }
                        break;

                    case 'M':
                                game_map.GetEnemies[i].attack(game_map.GetPlayer);
                        break;
                }
            }
            
        }

        

        public override string ToString()
        {
           return game_map.DrawMap();
        }

    }
}
