using System.Collections.Generic;

namespace SnakeOOP
{
    class Walls
    {
        public List<Figure> walls { get; private set; }

        public Walls(Point endPoint)
        {
            Point startPoint = new Point(0, 0, endPoint.Sym);
            walls = new List<Figure>();
            walls.Add(new Line(0, 0, endPoint.Sym, endPoint.X, true));
            walls.Add(new Line(0, endPoint.Y, endPoint.Sym, endPoint.X, true));

            walls.Add(new Line(0, 1, endPoint.Sym, endPoint.Y - 1, false));
            walls.Add(new Line(endPoint.X - 1, 1, endPoint.Sym, endPoint.Y - 1, false));
        }
    }
}