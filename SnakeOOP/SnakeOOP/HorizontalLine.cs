using System;
using System.Collections.Generic;

namespace SnakeOOP
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int x, int y, char sym, int count)
        {
            list = new List<Point>();
            for (int i = 0; i < count; i++)
            {
                list.Add(new Point(x + i, y, sym));
            }
        }
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            base.Draw();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
