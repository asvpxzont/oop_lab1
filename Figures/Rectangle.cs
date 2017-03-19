using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Rectangle : Mainfigure
    {

        public Rectangle()
        {
            NumberOfPoints = 2;
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(pen, ListOfPoints[0].X, ListOfPoints[0].Y, ListOfPoints[1].X - ListOfPoints[0].X, ListOfPoints[1].Y - ListOfPoints[0].Y);
        }

    }
}
