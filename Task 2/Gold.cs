using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    //Q2.2 Cocrete class called Gold inherited from Item
    class Gold: Item
    {
        //private member variable for amount of gold represented through gold that is dropped
        private int amount;
        //public accessor that can return the amount of gold
        public int Getamount
        {
            get { return amount; }
            set { amount = value; }
        }

        private Random rnd = new Random();

        //constructor receiving x and y positions that goes to the Item construcor through a constructor initialiser
        public Gold(int x, int y, TileType tile_type) : base(x, y, tile_type, '$')
        {
            //sets amount to a random amount between 1 and 5 inclusively
            amount = rnd.Next(1,6);
        }

        public override string ToString()
        {
            return "You have recieved " + amount + " gold";
        }
    }
}
