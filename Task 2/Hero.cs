using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    //Q2.6 concrete hero subclass that inherits from Character
    class Hero: Character
    {
        public Hero(int x, int y,TileType tile_type) :base(x, y, tile_type, 'H', 10, 10, 2,0)
        {
            //constructor that receives x and y positions
            //calls character constructor initialiser
            //Hero = 2 Damage
        }

        bool checkvalidmove(movementEnum charactermove)
        {
            bool valid = false;

            switch (charactermove)
            {
                case movementEnum.Right:
                        if(tilevision[2].GetType() == typeof(EmptyTile) || tilevision[2].GetType() == typeof(Item) ||  tilevision[2].GetType() == typeof(Gold))
                    {
                        valid = true;
                        break;
                    }
                    break;
                case movementEnum.Left:
                    if (tilevision[3].GetType() == typeof(EmptyTile) || tilevision[3].GetType() == typeof(Item) || tilevision[3].GetType() == typeof(Gold))
                    {
                        valid = true;
                        break;
                    }
                    break;
                case movementEnum.Down:
                    if (tilevision[1].GetType() == typeof(EmptyTile) || tilevision[1].GetType() == typeof(Item) || tilevision[1].GetType() == typeof(Gold))
                    {
                        valid = true;
                        break;
                    }
                    break;
                case movementEnum.Up:
                    if (tilevision[0].GetType() == typeof(EmptyTile) || tilevision[0].GetType() == typeof(Item) || tilevision[0].GetType() == typeof(Gold))
                    {
                        valid = true;
                        break;
                    }
                    break;
            }

            return valid;
        }
        
        //Overridden ReturnMove() method
        public override movementEnum ReturnMove( movementEnum move = movementEnum.NoMovement)
        {
            //receives movement indicator based on directional button press
            if (checkvalidmove(move))
            {
                return move;
            }
            else return movementEnum.NoMovement;
        }

        //overridden to string to display stats
        public override string ToString()
        {
            //Q3.2 Display the gold amount in the Stats display section
            return "Player Stats:" + '\n' + "HP: " + HP + "/ "+ MaxHP+ '\n' + "Damage: " + Damage + '\n' + "[" + X + "," + Y + "] "+ getpurse +" Gold";
        }
    }
}
