
using System;

namespace SnakeOOP
{
    class FoodCreator
    {
        int X, Y;
        char Sym;
        Random rnd = new Random();

        public FoodCreator(int x, int y, char sym)
        {
            X = x;
            Y = y; 
            Sym = sym;
        }

        public Point CreateFood()
        {
            Point food = new Point(rnd.Next(2, X - 2), rnd.Next(2, Y - 2), Sym);
            return food;
        }
    }
}
