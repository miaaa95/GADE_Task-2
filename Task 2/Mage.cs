using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    //Q2.3 concrete Mage subclass
    //A new type of enemy
    class Mage : Enemy 
    {
        public Mage(int x, int y, TileType tile_type) : base(x, y, tile_type, 'M', 1, 5, 5)
        {
             //constructor that receives x and y positions but takes variables through to Enemy class
             //Mage = 5HP
             //Mage = 5 damage
        }

        //overridden method called "checkrange"
        public override bool checkrange(Character Target)
        {
            //Mages attack all characters within a one block radius all around them
            //checking all ranges until it's own overridden CheckRange()
            if(Target.getX == X - 1 && Target.getY == Y - 1)
            {
                //returns true if enemy is in a one block radius from the Mage's x and y position
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

        //overridden ReturnMove() method
        public override movementEnum ReturnMove(movementEnum move = movementEnum.NoMovement)
        {
            //Always returns 0
            //Mages never move
            return movementEnum.NoMovement;
        }
    }
}
