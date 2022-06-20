using System;
using System.Collections.Generic;

namespace SnakeOOP
{
    class Point
    {
        public int X;
        public int Y;
        public char Sym;

        public Point() : this(0, 0, '*') { }

        public Point(int x, int y, char sym) { X = x; Y = y; Sym = sym; }

        public void Clear() { Sym = ' '; Draw(); }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Sym);
        }

        static public Point operator +(Point a, Point b) => new Point( a.X + b.X, a.Y + b.Y, b.Sym);
    }
}
