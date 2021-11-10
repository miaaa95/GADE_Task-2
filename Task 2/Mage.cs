﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class Mage : Enemy 
    {
        public Mage(int x, int y, TileType tile_type) : base(x, y, tile_type, 'M', 1, 5, 5)
        {

        }

       public override bool checkrange(Character Target)
        {
            
            if(Target.getX == X - 1 && Target.getY == Y - 1)
            {
                return true;
            }

            else if (Target.getX == X - 1 && Target.getY == Y + 1)
            {
                return true;
            }

            else if (Target.getX == X + 1 && Target.getY == Y - 1)
            {
                return true;
            }

            else if (Target.getX == X + 1 && Target.getY == Y + 1)
            {
                return true;
            }

            else if (Target.getX == X + 1 && Target.getY == Y)
            {
                return true;
            }
            else if (Target.getX == X - 1 && Target.getY == Y)
            {
                return true;
            }
            else if (Target.getX == X && Target.getY == Y + 1)
            {
                return true;
            }
            else if (Target.getX == X  && Target.getY == Y - 1)
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
