using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survadays
{
    public class Entity : GameObject
    {
        public int health;
        public int x_view;
        public int y_view;

        public Entity(int health, string name, string type, char symb, int x, int y) : base(name, type, symb, x, y)
        {
            this.health = health;
        }

        public Entity() {}        
    }
}
