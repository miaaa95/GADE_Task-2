using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    //Q2.1 Creating subclass called "ObstacleClass" which inheritances from tile class"
    //Exists to indicate empty tile space
    class Obstacle : Tile
    {
        public Obstacle(int x,int y, TileType tile_type) : base(x, y, tile_type,'X')
        {
            //constructor for obstacle class also inherites the tile constructor
        }
    }
}
