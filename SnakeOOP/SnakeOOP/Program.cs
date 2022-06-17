using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            InitVariables();
            Console.ReadLine();
        }

        private static void InitVariables()
        {
            Point point1 = new Point() { x = 1, y = 3, sym = '*' };
            point1.Draw();

            Point point2 = new Point() { x = 2, y = 5, sym = '#' };
            point2.Draw();
        }
    }
}
