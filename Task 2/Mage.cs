using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class Mage : Enemy 
    {
        public Mage(int x, int y, TileType tile_type, char symbol = 'M', int dmg = 5, int EnemyHP = 5, int MaxEnemyHP = 5) : base(x, y, tile_type, symbol, dmg, EnemyHP, MaxEnemyHP)
        {

        }

       public override bool checkrange(Character Target)
        {
            if (DistanceTo(Target) == 1)
            {
                return true;
            }
            if(Target.getX == X - 1 && Target.getY == Y - 1)
            {
                return true;
            }
            if (Target.getX == X - 1 && Target.getY == Y + 1)
            {
                return true;
            }
            if (Target.getX == X + 1 && Target.getY == Y - 1)
            {
                return true;
            }
            if (Target.getX == X + 1 && Target.getY == Y + 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override movementEnum ReturnMove(movementEnum move = movementEnum.NoMovement)
        {
            return movementEnum.NoMovement;
        }
    }
}
