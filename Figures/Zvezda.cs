using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Zvezda : Pentagon
    {
        public override void Draw(Graphics g)
        {
            g.DrawLine(pen, ListOfPoints[0].X, ListOfPoints[0].Y, ListOfPoints[2].X, ListOfPoints[2].Y);
            g.DrawLine(pen, ListOfPoints[0].X, ListOfPoints[0].Y, ListOfPoints[3].X, ListOfPoints[3].Y);
            g.DrawLine(pen, ListOfPoints[1].X, ListOfPoints[1].Y, ListOfPoints[4].X, ListOfPoints[4].Y);
            g.DrawLine(pen, ListOfPoints[1].X, ListOfPoints[1].Y, ListOfPoints[3].X, ListOfPoints[3].Y);
            g.DrawLine(pen, ListOfPoints[2].X, ListOfPoints[2].Y, ListOfPoints[4].X, ListOfPoints[4].Y);
        }
    }
}
