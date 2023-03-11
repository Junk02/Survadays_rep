                  ///////////////////////////////////////////////////////////////////////////////
                  //░██████╗██╗░░░██╗██████╗░██╗░░░██╗░█████╗░██████╗░░█████╗░██╗░░░██╗░██████╗//
                  //██╔════╝██║░░░██║██╔══██╗██║░░░██║██╔══██╗██╔══██╗██╔══██╗╚██╗░██╔╝██╔════╝//
                  //╚█████╗░██║░░░██║██████╔╝╚██╗░██╔╝███████║██║░░██║███████║░╚████╔╝░╚█████╗░//
                  //░╚═══██╗██║░░░██║██╔══██╗░╚████╔╝░██╔══██║██║░░██║██╔══██║░░╚██╔╝░░░╚═══██╗//
                  //██████╔╝╚██████╔╝██║░░██║░░╚██╔╝░░██║░░██║██████╔╝██║░░██║░░░██║░░░██████╔╝//
                  //╚═════╝░░╚═════╝░╚═╝░░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝░░░╚═╝░░░╚═════╝░//
                  ///////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survadays
{
    internal class Program
    {
        static void Main()
        {
            Console.SetWindowSize(140, 40);
            Console.BufferWidth = 140;
            Console.BufferHeight = 40;
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.White;

            int left_center_logo = Console.BufferWidth / 2 - 36;

            Random rand = new Random();            


            //Logo
            Console.SetCursorPosition(left_center_logo, 3);
            Console.Write("░██████╗██╗░░░██╗██████╗░██╗░░░██╗░█████╗░██████╗░░█████╗░██╗░░░██╗░██████╗");
            Console.SetCursorPosition(left_center_logo, 4);
            Console.Write("██╔════╝██║░░░██║██╔══██╗██║░░░██║██╔══██╗██╔══██╗██╔══██╗╚██╗░██╔╝██╔════╝");
            Console.SetCursorPosition(left_center_logo, 5);
            Console.Write("╚█████╗░██║░░░██║██████╔╝╚██╗░██╔╝███████║██║░░██║███████║░╚████╔╝░╚█████╗░");
            Console.SetCursorPosition(left_center_logo, 6);
            Console.Write("░╚═══██╗██║░░░██║██╔══██╗░╚████╔╝░██╔══██║██║░░██║██╔══██║░░╚██╔╝░░░╚═══██╗");
            Console.SetCursorPosition(left_center_logo, 7);
            Console.Write("██████╔╝╚██████╔╝██║░░██║░░╚██╔╝░░██║░░██║██████╔╝██║░░██║░░░██║░░░██████╔╝");
            Console.SetCursorPosition(left_center_logo, 8);
            Console.Write("╚═════╝░░╚═════╝░╚═╝░░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝░░░╚═╝░░░╚═════╝░");

            Console.SetCursorPosition(Console.BufferWidth / 2 - 14, 15);

            Console.Write("Press any button to start...");

            Console.ReadKey();


            //Preparation
            Console.SetCursorPosition(0, 0);

            for (int i = 0; i < Console.WindowHeight; i++)
            {
                for (int j = 0; j < Console.WindowWidth; j++)
                    Console.Write(Convert.ToChar(rand.Next(50, 100)));
            }


            Console.Clear();


            Game game = new Game(1000, 1000);

        }
    }

}