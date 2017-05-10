using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures
{
    class LineDrawer :Drawer
    {
        public void Draw(Mainfigure figure, Graphics g)
        {
            PointF first = new PointF(figure.Point1.X, figure.Point1.Y);
            PointF second = new PointF(figure.Point2.X, figure.Point2.Y);
            g.DrawLine(figure.pen, first, second);
        }
    }
}
