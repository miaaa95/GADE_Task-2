using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    //Q2.1 abstract class item inherits from Tile
    abstract class Item : Tile
    {
        //constructor receiving x and y positions
        public Item(int x, int y, TileType tile_type, char symbol) : base(x, y, tile_type, symbol)
        {
            //data goes to Tile through constructor initialiser
            //Otherwise empty
        }

        //Abstract to string method that is overridden by subclasses to return items
        public abstract override string ToString();
    }
}
