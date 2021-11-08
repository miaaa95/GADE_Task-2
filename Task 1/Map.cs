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

        private List<Enemy> enemies;

        private List<Enemy> GetEnemies
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
            mapwidth = rnd.Next(min_width, max_width);
            mapheight = rnd.Next(min_height, max_height);
            map = new Tile[mapwidth, mapheight];
            enemies = new List<Enemy>();
            
            generate_map(num_enemies);
            UpdateVision();
        }
        private void generate_map(int num)
        {
            for (int y = 0; y < mapwidth; y++)
            {
                for (int x = 0; x < mapheight; x++)
                {
                    if(x == 0|| x == mapwidth - 1|| y == 0 || y == mapheight - 1)
                    {
                        Create(TileType.Barrier, x, y);
                    }
                    else
                    {
                        Create(TileType.Empty, x, y);
                    }
                }
            }
            Create(TileType.Hero);
            for (int i = 0; i < num; i++)
            {
                Create(TileType.Enemy);
            }
        }

        public void Create(TileType tileType,int x = 0, int y = 0)
        {
            switch (tileType)
            {
                case TileType.Barrier:
                    Obstacle barrier = new Obstacle(x, y, tileType, 'X');
                    map[x, y] = barrier;
                    break;
                case TileType.Empty:
                    EmptyTile tile = new EmptyTile(x, y, tileType, '.');
                    map[x, y] = tile;
                    break;
                case TileType.Hero:
                    int HeroX = rnd.Next(0, mapwidth);
                    int HeroY = rnd.Next(0, mapheight);

                    while( map[HeroX,HeroY].GetType() != typeof(EmptyTile))
                    {
                         HeroX = rnd.Next(0, mapwidth);
                         HeroY = rnd.Next(0, mapheight);
                    }

                    Hero newHero = new Hero(HeroX, HeroY, tileType, 'H', 10, 100, 100);
                    Player = newHero;
                    map[HeroX, HeroY] = newHero;
                    break;
                case TileType.Enemy:
                    int EnemyX = rnd.Next(0, mapwidth);
                    int EnemyY = rnd.Next(0, mapheight);

                    while (map[EnemyX, EnemyY].GetType() != typeof(EmptyTile))
                    {
                        EnemyX = rnd.Next(0, mapwidth);
                        EnemyY = rnd.Next(0, mapheight);
                    }
                    Goblin newEnemy = new Goblin(EnemyX, EnemyY, tileType, 'G', 10, 100, 100);
                    enemies.Add(newEnemy);
                    map[EnemyX, EnemyY] = newEnemy;
                    break;
            }
        }

        public void UpdateVision()
        {
            foreach(Enemy E in enemies)
            {
                E.tilevision.Clear();
            }

          

        }
    
    }
}
