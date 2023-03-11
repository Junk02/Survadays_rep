using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survadays
{
    public class Floor : PhysicalObject
    {

        public Floor(string name, char symb, int x, int y) : base(name, "Object", symb, x, y)
        {

        }    
    }
}
