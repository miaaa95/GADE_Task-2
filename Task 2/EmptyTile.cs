using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    //Q2.1 Creating class called "EmptyTileClass which inheritances from tile class"
    //Exists to indicate empty tile space
    class EmptyTile : Tile
    {
        public EmptyTile(int x, int y, TileType tile_type) : base(x, y, tile_type,'.')
        {
            //constructor for empty tile also inherites the tile constructor
        }
    }
}
