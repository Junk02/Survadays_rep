using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survadays
{
    public class Player : Entity
    {

        public const int x_view = 10;
        public const int y_view = 10;

        public Player(string name, char symb, int x, int y) : base(100, name, "Player", symb, x, y)
        {
            base.name = name;
        }

        public Player()
        {

        }

        public void PlayerInfo()
        {
            Console.WriteLine(this.health);
            //протестировать метод Moving
        }

        public static int GetXView()
        {
            return x_view;
        }

        public static int GetYView()
        {
            return y_view;
        }
    }
}
