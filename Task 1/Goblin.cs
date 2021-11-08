using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class Goblin : Enemy
    {

        public Goblin(int x, int y, TileType tile_type, char symbol = 'G', int dmg = 1, int EnemyHP = 10, int MaxEnemyHP = 10) : base(x, y, tile_type, symbol, dmg, EnemyHP, MaxEnemyHP)
        {

        }



        //side note i have not made my map array so do not be surprised by red lines it will be fixed in the future
        public override movementEnum ReturnMove(movementEnum move = movementEnum.NoMovement)
        {
            int random_tile = rnd.Next(0, tilevision.Count);
            while (tilevision[random_tile].GetType() != typeof(EmptyTile))
            {
                random_tile = rnd.Next(0, tilevision.Count);
            }
            switch (random_tile)
            {
                
                case 0:
                    return movementEnum.Up;
                case 1:
                    return movementEnum.Down;
                case 2:
                    return movementEnum.Right;
                case 3:
                    return movementEnum.Left;
                default:
                    return movementEnum.NoMovement;
            }
        }
    }
}
