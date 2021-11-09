using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    //Q2.1
    //Abstract class called "Tile"
    //Base class for all in-game objects that have positions on the map
    abstract class Tile
    {
        //Public enum called "TileType" defining the type of tile being set
        //Either a hero, enemy, gold, or weopon
       

        //Protected member variables
        protected int X;
        protected int Y;
        protected char Symbol;
        protected TileType TypeOfTile;

        // tile class constructor
        public Tile(int x, int y,TileType tile_type, char symbol)
        {
            X = x;
            Y = y;
            Symbol = symbol;
            TypeOfTile = tile_type;
        }

        //Accessors for protected variables
        public int getX
        { 
          get { return X; }
          set { X = value; }
        }
       
        public int getY { set { Y = value; } get { return Y; } }
        
        public char getsymbol{ set { Symbol = value; } get { return Symbol; } }

        public TileType GetTileType
        {
            set { TypeOfTile = value; }
            get { return TypeOfTile; }

        }
        //Public enum called "TileType" defining the type of tile being set
        //Either a hero, enemy, gold, or weopon
        
    }
}
