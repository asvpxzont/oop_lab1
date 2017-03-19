using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Ellipse : Rectangle
    {
        public override void Draw(Graphics g)
        {
            g.DrawEllipse(pen, ListOfPoints[0].X, ListOfPoints[0].Y, ListOfPoints[1].X - ListOfPoints[0].X, ListOfPoints[1].Y - ListOfPoints[0].Y);
        }
    }
}
