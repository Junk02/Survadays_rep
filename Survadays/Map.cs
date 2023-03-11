using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Survadays
{
    public class Map
    {
        public int map_x, map_y;
        public Cell[,] map;

        public Map(int map_size_x, int map_size_y) //инициализация(создание) карты
        {
            this.map_x = map_size_x;
            this.map_y = map_size_y;
            map = new Cell[map_x, map_y];
            for (int i = 0; i < map_x; i++)
                for (int j = 0; j < map_y; j++)
                    map[i, j] = new Cell(); 
        }

        public void DrawMap(int x_view, int y_view, int x_pos, int y_pos) //вывод карты для игрока
        {
            try
            {
                Console.SetCursorPosition(0, 0);
                if (x_pos >= x_view && y_pos >= y_view)
                    for (int i = x_pos - x_view; i <= x_pos + x_view; i++)
                    {
                        for (int j = y_pos - y_view; j <= y_pos + y_view; j++)
                            Console.Write(map[i, j].gameObjects.Last().symb);
                        Console.WriteLine();
                    }

                else
                {
                    for (int i = 0; i <= x_pos + x_view; i++)
                    {
                        for (int j = 0; j <= y_pos + y_view; j++)
                            Console.Write(map[i, j].gameObjects.Last().symb);
                        if (i != x_pos + x_view)
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception ex) { Message.MethodError(ex, "DrawMap"); }
        }

        public Cell GetCell(int x, int y) //получение конкретной клетки на карте(для обращения)
        {
            try { return map[x, y]; }
            catch (Exception ex) { Message.MethodError(ex, "GetCell"); return new Cell(); }
        }
    }
}
