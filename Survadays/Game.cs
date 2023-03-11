using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Survadays
{
    public class Game
    {
        public Map terrain;
        public Player player;
        public int dis_height = Console.BufferHeight - 2;
        public int dis_width = Console.BufferWidth - 3;
        public int game_dis_height = Console.BufferHeight - 2;
        public int game_dis_width = (Console.BufferWidth - 3) / 2  + (Console.BufferWidth - 3) / 4;

        public Game(int x, int y)
        {
            Message message = new Message(); //создание объекта
            terrain = new Map(x, y); //создание объекта карты


            GameInit(); //начальная инициализация игры


            terrain.DrawMap(game_dis_height - 2, game_dis_width - 2, player.x_pos, player.y_pos);
            
            Thread.Sleep(100000);
        }

        public void GameInit()
        {
            try
            {
                for (int i = 0; i < terrain.map_x; i++) //заполнение каждой клетки карты объектом "пол"
                {
                    for (int j = 0; j < terrain.map_y; j++)
                        terrain.GetCell(i, j).AddGameObject(new Floor("Floor", '0', i, j));
                }
                
                terrain.GetCell(3, 3).AddGameObject(new Player("Artem", '.', 3, 3)); //добавление игрока на карту
                player = Cell.GetPlayer(terrain.GetCell(3, 3));
            }
            catch (Exception ex) { Message.MethodError(ex, "MapInit"); }
        }
    }
}
