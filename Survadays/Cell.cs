using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survadays
{
    public class Cell
    {
        public List<GameObject> gameObjects;

        public Cell() //инициализация игровой клетки(создание списка игровых объектов)
        {
            gameObjects = new List<GameObject>(1);
        }

        public void AddGameObject(GameObject obj) //метод добавления в клетку игрового объекта
        {
            gameObjects.Add(obj);
        }
        
        public void DeleteGameObject(GameObject obj)
        {
            gameObjects.RemoveAt(gameObjects.IndexOf(obj));
        }

        public static GameObject GetGameObject(Cell cell, int ind)
        {
            try { return (GameObject)cell.gameObjects[ind]; }
            catch (Exception ex)
            {
                Message.MethodError(ex, "GetGameObject");
                return new GameObject();
            }
        }

        /*public Player GetPlayer(int ind)
        {
            try { return (Player)gameObjects[ind]; }

            catch (Exception ex)
            {
                Message.MethodError(ex, "GetPlayer");
            }
            return new Player();
        }*/

        public static Player GetPlayer(Cell cell)
        {
            try
            {
                for (int i = 0; i < cell.gameObjects.Count; i++)
                    if (cell.gameObjects[i].type == "Player") return (Player)cell.gameObjects[i];
            }

            catch (Exception ex)
            {
                Message.MethodError(ex, "GetPlayer");
            }
            return new Player();
        }

        public static Entity GetEntity(Cell cell, int ind)
        {
            try { return (Entity)cell.gameObjects[ind]; }
            catch(Exception ex) 
            {
                Message.MethodError(ex, "GetEntity");
                return new Entity();
            }
        }

        public static GameObject GetPhysicalObject(Cell cell, int ind)
        {
            return (PhysicalObject)cell.gameObjects[ind];
        }

        public static GameObject GetItem(Cell cell, int ind)
        {
            return (Item)cell.gameObjects[ind];
        }
    }
}
