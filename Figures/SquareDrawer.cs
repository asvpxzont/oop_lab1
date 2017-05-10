using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures
{
    class SquareDrawer : Drawer
    {
        public void Draw(Mainfigure figure, Graphics g)
        {
            PointF first = new PointF(figure.Point1.X, figure.Point1.Y);
            PointF second = new PointF(figure.Point2.X, figure.Point2.Y);
            if (second.X>first.X && second.Y>first.Y)
            g.DrawRectangle(figure.pen, first.X, first.Y, second.X - first.X, second.X - first.X);
            else
            if (first.X>second.X && second.Y>first.Y)
            g.DrawRectangle(figure.pen, second.X, first.Y, first.X - second.X, first.X - second.X);
            else 
            if (first.X>second.X && first.Y>second.Y)
            g.DrawRectangle(figure.pen, second.X, second.Y, first.X - second.X, first.X - second.X);
            else
                g.DrawRectangle(figure.pen, first.X, second.Y, second.X - first.X, second.X - first.X);
        }
    }
}
