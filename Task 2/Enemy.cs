using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    //Q2.4 abstract enemy class that inherits from character
    abstract class Enemy : Character
    {
        //random object used to randomise numbers
        protected Random rnd = new Random();

        //constructor that receives x and y positions, enemys damage, starting HP
        //sends data of positions to character subclass through a constructor initialiser
        public  Enemy(int x, int y,TileType tile_type, char symbol, int dmg, int EnemyHP,int MaxEnemyHP) : base(x, y, tile_type, symbol,dmg, EnemyHP, MaxEnemyHP,0)
        {
            Damage = dmg;
            MaxHP = MaxEnemyHP;
            HP = EnemyHP;
        }

        //overridden to string that uses enemy class and outputs "EnemyClassName at [X, Y] (Amount DMG)"
        public override string ToString()
        {
            string output = GetType().Name+'\n'+ " at["+ X +","+ Y+"]  \n "+ HP+" HP \n"+"{"+ Damage+"}";
            return output;
        }
    }
}
//"Enemy class name at[" + X.ToString + "," + Y.ToString + "](Amunt of " + Damage + ")"
