using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    abstract class Item : Tile
    {
        public Item(int x, int y, TileType tile_type, char symbol) : base(x, y, tile_type, symbol)
        {

        }

        public abstract override string ToString();
    }
}
