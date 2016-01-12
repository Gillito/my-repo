using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLines
    {
        List<Point> hLines;

        public HorizontalLines(int xLeft, int xRight, int y, char sym)
        {
            hLines = new List<Point>();

            for (int i = xLeft; i <= xRight; i++)
            {
                Point p = new Point(i, y, sym);
                hLines.Add(p);
            }
        }

        public void DrawHLine()
        {
            foreach (Point item in hLines)
            {
                item.Draw();
            }
        }
    }
}
