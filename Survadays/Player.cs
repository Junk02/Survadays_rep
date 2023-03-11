using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survadays
{
    public class Player : Entity
    {

        public Player(string name, char symb, int x, int y) : base(100, name, "Player", symb, x, y)
        {
            base.name = name;
            x_view = Console.BufferHeight - 4;
            y_view = (Console.BufferWidth - 3) / 2 + (Console.BufferWidth - 3) / 4 - 2;
        }

        public Player() {}

        public void PlayerInfo()
        {
            Console.WriteLine(this.health);
            //протестировать метод Moving
        }
    }
}
