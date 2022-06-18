using System;

namespace SnakeOOP
{
	class Point
	{
		public int x;
		public int y;
		public char Sym;

		public Point()
		{
		}

		public Point(int x, int y, char sym)
		{
			this.x = x;
			this.y = y;
			this.Sym = sym;
		}

		public Point(Point p)
		{
			x = p.x;
			y = p.y;
			Sym = p.Sym;
		}

		public void Move(int offset, Direction direction)
		{
			if (direction == Direction.RIGHT)
			{
				x = x + offset;
			}
			else if (direction == Direction.LEFT)
			{
				x = x - offset;
			}
			else if (direction == Direction.UP)
			{
				y = y - offset;
			}
			else if (direction == Direction.DOWN)
			{
				y = y + offset;
			}
		}

		public bool IsHit(Point p)
		{
			return p.x == this.x && p.y == this.y;
		}

		public void Draw()
		{
			Console.SetCursorPosition(x, y);
			Console.Write(Sym);
		}

		public void Clear()
		{
			Sym = ' ';
			Draw();
		}

		public override string ToString()
		{
			return x + ", " + y + ", " + Sym;
		}
	}
}
