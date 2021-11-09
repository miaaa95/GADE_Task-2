using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class Gold: Item
    {

        private int amount;

        public int Getamount
        {
            get { return amount; }
            set { amount = value; }
        }

        private Random rnd = new Random();

        public Gold(int x, int y, TileType tile_type, char symbol) : base(x, y, tile_type, symbol)
        {
            amount = rnd.Next(1,6);
        }

        public override string ToString()
        {
            return "You have recieved " + amount + " gold";
        }
    }
}
