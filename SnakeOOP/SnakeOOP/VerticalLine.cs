using System.Collections.Generic;

namespace SnakeOOP
{
	class VerticalLine : Figure
	{
		public VerticalLine(int yUp, int yDown, int x, char sym)
		{
			list = new List<Point>();
			for (int y = yUp; y <= yDown; y++)
			{
				Point p = new Point(x, y, sym);
				list.Add(p);
			}
		}
	}
}
