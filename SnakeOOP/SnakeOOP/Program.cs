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
            Point point1 = new Point(1, 3, '*');
            point1.Draw();

            Point point2 = new Point(2, 5, '#');
            point2.Draw();
        }
    }
}
