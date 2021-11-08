﻿using System;
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
        public List <Tile> tilevision;

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

        public List <Tile> Vision
        {
            get { return tilevision; }
            set { tilevision = value; }
        }


        //public enum indicating character movement
       



        public  Character(int x, int y, TileType tile_type, char symbol, int hp,int maxhp, int damage): base(x, y,tile_type,symbol)
        {
            Symbol = symbol;
            HP = hp;
            MaxHP = maxhp;
            Damage = damage;
            tilevision = new List<Tile>();
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
            return false;
        }

        //Private integer method called "DistanceTo"
        //Determines absolute distance. Number of spaces to move
        private int DistanceTo()
        {
            return 0;
        }

        //Public void method called "Move"
        public void Move(movementEnum move)
        {
            switch (move)
            {
                case movementEnum.Up:
                    Y = Y + 1;
                    break;
                case movementEnum.Down:
                    Y = Y - 1;
                    break;
                case movementEnum.Left:
                    X = X - 1;
                    break;
                case movementEnum.Right:
                    X = X + 1;
                    break;
            }
        }

        public abstract movementEnum ReturnMove(movementEnum m);

        public abstract override string ToString();






    }
}
