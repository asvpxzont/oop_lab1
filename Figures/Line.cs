using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures
{
    class Line : Mainfigure
    {

        public Line ()
        {
            NumberOfPoints = 2;
        }

        public override void Draw(Graphics g)
        {
            g.DrawLine(pen, ListOfPoints[0].X, ListOfPoints[0].Y, ListOfPoints[1].X, ListOfPoints[1].Y);
        }
    }
}
