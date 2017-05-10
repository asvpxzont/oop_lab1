using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class DrawerFactory
    {
        public Drawer createdfactorytodraw(typesoffigures typeoffigure)
        {
            switch (typeoffigure)
            {
                case typesoffigures.line: return new LineDrawer();
                case typesoffigures.triangle: return new TriangleDrawer();
                case typesoffigures.rectangle: return new RectangleDrawer();
                case typesoffigures.circle: return new CircleDrawer();
                case typesoffigures.ellipse: return new EllipseDrawer();
                case typesoffigures.square: return new SquareDrawer();
                default: return null;
            }
        }
    }
}
