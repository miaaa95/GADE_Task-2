using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class Map
    {
        private Tile[,] map;
        public Tile[,] GetMaps
        {
            get { return map; }
            set { map = value; }
        }

        private Hero Player;
        public Hero GetPlayer
        {
            get { return Player; }
            set { Player = value; }
        }

        private Enemy []  enemies;

        public Enemy[] GetEnemies
        {
            get { return enemies; }
            set { enemies = value; }
        }

        private int mapwidth;

        public int getmapwidth
        {
            get { return mapwidth; }
            set { mapwidth = value; }
        }

        private int mapheight;

        public int getmapheight
        {
            get { return mapheight; }
            set { mapheight = value; }
        }
        private Random rnd = new Random();

        public Map(int min_width,int max_width, int min_height, int max_height,int num_enemies)
        {
            mapwidth = rnd.Next(min_width, max_width+1);
            mapheight = rnd.Next(min_height, max_height+1);

            map = new Tile[mapwidth, mapheight];

            enemies = new Enemy[num_enemies];

            generate_map();

            Player = (Hero)Create(TileType.Hero);
            map[Player.getX, Player.getY] = Player;

            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = (Enemy)Create(TileType.Enemy);
                map[enemies[i].getX, enemies[i].getY] = enemies[i];
            }
            UpdateVision();
        }

        
        public void updatemap()
        {
            generate_map();
            map[Player.getX, Player.getY] = Player;
            for (int i = 0; i < enemies.Length; i++)
            {
                map[enemies[i].getX, enemies[i].getY] = enemies[i];
            }
            UpdateVision();
        }
         void generate_map()
        {
            create_tiles();
            create_borders();
        }
        private  void create_borders()
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0;x < map.GetLength(0);x++)
                {
                    if ((y == 0 || y == map.GetLength(1) - 1) || x == 0 || (x == map.GetLength(0) - 1))
                    {
                        map[x,y] = new Obstacle(x, y, TileType.Barrier);
                    }
                }
            }
        }

        private void create_tiles()
        {
            for (int y = 0;y < map.GetLength(1);y++)
            {
                for (int x = 0; x < map.GetLength(0);x++)
                {
                    map[x,y] = new EmptyTile(x,y, TileType.Empty);
                }
            }
        }
        
       private Tile Create(TileType tileType,int x = 0, int y = 0)
        {
            switch (tileType)
            {
                case TileType.Hero:
                    int HeroX = rnd.Next(0, mapwidth-1);
                    int HeroY = rnd.Next(0, mapheight-1);
                    while( map[HeroX,HeroY].GetType() != typeof(EmptyTile))
                    {
                         HeroX = rnd.Next(0, mapwidth);
                         HeroY = rnd.Next(0, mapheight);
                    }
                    return new Hero(HeroX, HeroY, tileType);

                case TileType.Enemy:
                    int EnemyX = rnd.Next(0, mapwidth);
                    int EnemyY = rnd.Next(0, mapheight);

                    while (map[EnemyX, EnemyY].GetType() != typeof(EmptyTile))
                    {
                        EnemyX = rnd.Next(0, mapwidth);
                        EnemyY = rnd.Next(0, mapheight);
                    }
                    return new Goblin(EnemyX, EnemyY, tileType);
                default:
                    return null;
            }
        }

        public void UpdateVision()
        {
            foreach(Enemy E in enemies)
            {
              //  E.Vision.Clear();
                E.tilevision[0] = map[E.getX, E.getY - 1];
                E.tilevision[1] = map[E.getX, E.getY + 1];
                E.tilevision[2] = map[E.getX + 1, E.getY];
                E.tilevision[3] = map[E.getX - 1, E.getY];
            }
            //Player.Vision.Clear();
            Player.tilevision[0] = map[Player.getX, Player.getY - 1];
            Player.tilevision[1] = map[Player.getX, Player.getY + 1];
            Player.tilevision[2] = map[Player.getX + 1, Player.getY];
            Player.tilevision[3] = map[Player.getX - 1, Player.getY];
        }

        public string DrawMap()
        {
            string output = "";
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    output += map[x, y].getsymbol; 
                }
                output += '\n';
            }
            return output;
        }
        
    }
}
