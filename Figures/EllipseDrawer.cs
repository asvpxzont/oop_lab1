using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures
{
    class EllipseDrawer :Drawer
    {
        public void Draw(Mainfigure figure,Graphics g)
        {
            g.DrawEllipse(figure.pen, figure.Point1.X, figure.Point1.Y, figure.Point2.X - figure.Point1.X, figure.Point2.Y - figure.Point1.Y);
        }
    }
}
