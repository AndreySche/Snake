using System;

namespace SnakeOOP
{
    class Point
    {
        public int X, Y;
        public char Sym;
        public Point() { }

        public Point(int x, int y, char sym)
        {
            X = x;
            Y = y;
            Sym = sym;
        }
        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
            Sym = p.Sym;
        }

        public void Move(int offset, Direct direction)
        {
            switch (direction)
            {
                case Direct.right: X += offset; break;
                case Direct.left: X -= offset; break;
                case Direct.up: Y += offset; break;
                case Direct.down: Y -= offset; break;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Sym);
        }

        public override string ToString()
        {
            return $"{X}, {Y}, {Sym}"; 
        }
    }
}
