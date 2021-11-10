using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    abstract class Enemy : Character
    {
        protected Random rnd = new Random();

        public  Enemy(int x, int y,TileType tile_type, char symbol, int dmg, int EnemyHP,int MaxEnemyHP) : base(x, y, tile_type, symbol,dmg, EnemyHP, MaxEnemyHP,0)
        {
            Damage = dmg;
            MaxHP = MaxEnemyHP;
            HP = EnemyHP;
        }

        public override string ToString()
        {
            string output = GetType().Name+'\n'+ " at["+ X +","+ Y+"]  \n "+ HP+" HP \n"+"{"+ Damage+"}";
            return output;
        }
    }
}
//"Enemy class name at[" + X.ToString + "," + Y.ToString + "](Amunt of " + Damage + ")"