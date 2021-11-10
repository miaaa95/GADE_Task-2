using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    //Q2.2 Creating abstract base class called "Character"
    //Inherits from "Tile"
     abstract class Character:Tile
    {
        //Protected member variables
        protected int HP;
        protected int MaxHP;
        protected int Damage;
        protected int Purse;
        public Tile [] tilevision = new Tile[4];

        public int gethp
        {
            get { return HP;}
            set { HP = value; }
        }

        public int getmaxHp
        {
            get { return MaxHP; }
            set { MaxHP = value; }
        }

        public int getdamage
        {
            get { return Damage; }
            set { Damage = value; }
        }

        public int getpurse
        {
            get { return Purse; }
            set { Purse = value; }
        }

        public  Character(int x, int y, TileType tile_type, char symbol, int hp,int maxhp, int damage,int purse): base(x, y,tile_type,symbol)
        {
            Symbol = symbol;
            HP = hp;
            MaxHP = maxhp;
            Damage = damage;
            Purse = purse;
        }

        //Q2.3 Adding in methods to define generic implementations for the character to use
        //Public virtual void called "Attack"
        public virtual void attack(Character Target)
        {
            //Decreases health of attacking character's damage
            Target.HP = Target.HP - Damage;
        }

        //Public bool called "IsDead"
        public bool isdead()
        {
            
            if(HP <= 0)
            {
                return true;
            }
            else return false;
        }


        //Public virtual bool
        public virtual bool checkrange(Character Target)
        {
            if (DistanceTo(Target) > 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Private integer method called "DistanceTo"
        //Determines absolute distance. Number of spaces to move
        public int DistanceTo(Character character)
        {
            int num = X+Y;
            int num2 = character.X+ character.Y;
            int num3 = Math.Abs(num - num2);
            return num3;
        }

        //Public void method called "Move"
        public void Move(movementEnum move)
        {
            switch (move)
            {
                case movementEnum.Up:
                    Y = Y - 1;
                    break;
                case movementEnum.Down:
                    Y = Y + 1;
                    break;
                case movementEnum.Left:
                    X = X - 1;
                    break;
                case movementEnum.Right:
                    X = X + 1;
                    break;
                case movementEnum.NoMovement:
                    break;
            }
        }

        // ask for some assistance
        //public void Pickup(Item i)
        //{
        //    switch (i.GetTileType)
        //    {
        //        case TileType.Gold:
        //            Pickup_Gold(i);
        //    }
        //}

        // alternative for now
        public void Pickup(Item i)
        {
        Gold gold = (Gold)i;
        Purse = Purse + gold.Getamount;  
        }

        public abstract movementEnum ReturnMove(movementEnum m);

        public abstract override string ToString();






    }
}
