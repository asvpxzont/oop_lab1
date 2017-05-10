using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures
{
    class TriangleDrawer : Drawer
    {
        public void Draw(Mainfigure figure,Graphics g)
        {
            PointF first = new PointF(figure.Point1.X, figure.Point1.Y);
            PointF second = new PointF(figure.Point2.X, figure.Point2.Y);
            PointF third = new PointF(0, 0);
            if (second.X > first.X && second.Y > first.Y)
            {
                third.X = second.X - 2 * (second.X - first.X);
                third.Y = second.Y;
            }
            else
            if (first.X>second.X && second.Y>first.Y)
            {
                third.X = second.X + 2 * (first.X-second.X);
                third.Y = second.Y;
            }
            else
            if (first.X > second.X && first.Y > second.Y)
            {
                third.X = second.X + 2 * (first.X - second.X);
                third.Y = second.Y;
            }
            else
            if (second.X > first.X && first.Y > second.Y)
            {
                third.X = second.X - 2 * (second.X - first.X);
                third.Y = second.Y;
            }
            List<PointF> parray = new List<PointF>();
            parray.Add(first);
            parray.Add(second);
            parray.Add(third);
            g.DrawPolygon(figure.pen, parray.ToArray());
        }
    }
}
