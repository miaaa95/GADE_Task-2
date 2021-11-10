﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class GameEngine
    {
        //Q3.3 private map variable
        private Map game_map;
        //public get accessor
         public Map GetMap
        {
             //constructor that creates a map object with sensible values
            get { return game_map; }
            set { game_map = value; }
        }
        
       public  GameEngine()
        {
            game_map = new Map(10, 10, 15, 15, 3,2);
        }

        //Q3.3 Allows player to move a space if the move is valid
        //Players move one unit on the grid
        public void MovePlayer(movementEnum movement)
        {
            switch (movement)
            {
                    //move up
                case movementEnum.Up:
                game_map.GetPlayer.Move(game_map.GetPlayer.ReturnMove(movementEnum.Up));
                    break;

                    //move down
                case movementEnum.Down:
                    game_map.GetPlayer.Move(game_map.GetPlayer.ReturnMove(movementEnum.Down));
                    break;

                    //move left
                case movementEnum.Left:
                    game_map.GetPlayer.Move(game_map.GetPlayer.ReturnMove(movementEnum.Left));
                    break;

                    //move right
                case movementEnum.Right:
                    game_map.GetPlayer.Move(game_map.GetPlayer.ReturnMove(movementEnum.Right));
                    break;
            }
           
        }

        //Q3.3 All enemies move only when the player moves
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
                //enemy stats update after every attack or movement
                game_map.GetPlayer.attack(game_map.GetEnemies[Enemy]);
                return "You did attack "+game_map.GetPlayer.getdamage+" damage to a "+game_map.GetEnemies[Enemy].GetType().Name
                +" they now have " + game_map.GetEnemies[Enemy].gethp + " HP";
            }
            else
            {
                return "Target was not in range";
            }
        }

        //Q3.3 Enemies attack after player moves
        //Enemies attack when player attacks
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
