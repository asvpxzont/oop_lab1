using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Triangle : Mainfigure
    {
        public Triangle()
            {
            NumberOfPoints = 3;
        }

        public override void Draw(Graphics g)
        {
            List<PointF> temp = new List<PointF>();
            PointF tempItem = new PointF();
            for (int i = 0; i <= NumberOfPoints - 1; i++)
            {
                tempItem.X = ListOfPoints[i].X;
                tempItem.Y = ListOfPoints[i].Y;
                temp.Add(tempItem);
            }

            g.DrawPolygon(pen, temp.ToArray());
        }
    }
}
