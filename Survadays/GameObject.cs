using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Survadays
{
    public class GameObject
    {
        public string name;
        public char symb;
        public int x_pos, y_pos;
        public string type;

        public GameObject(string name, string type, char symb, int x, int y)
        {
            this.name = name;
            this.type = type;
            this.symb = symb;
            x_pos = x;
            y_pos = y;
        }

        public GameObject() {}

        public void Moving(GameObject obj, Map map, int step, int direction)
        {
            try
            {
                if (direction == 0)
                {
                    if (obj.x_pos >= step - 1 && obj.y_pos >= step - 1)
                    {
                        map.GetCell(obj.x_pos, obj.y_pos).DeleteGameObject(obj);
                        obj.x_pos--;
                        obj.y_pos--;
                        map.GetCell(obj.x_pos, obj.y_pos).AddGameObject(obj);
                    }
                }
            }
            catch (Exception ex)
            {
                Message.MethodError(ex, System.Reflection.MethodBase.GetCurrentMethod().Name.ToString());
            }
        }
    }
}
