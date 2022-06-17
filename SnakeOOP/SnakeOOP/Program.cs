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
            int x1 = 1, y1 = 3;
            char sim1 = '*';
            Draw(x1, y1, sim1);

            x1 = 2; y1 = 4;
            char sim2 = '#';
            Draw(x1, y1, sim2);
        }

        private static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
