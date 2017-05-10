using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures
{
    public class Mainfigure
    {
        private Point point1;
        public Point Point1
        {
            get { return point1; }
            set { point1 = value; }
        }
        private Point point2;
        public Point Point2
        {
            get { return point2; }
            set { point2 = value; }
        }
        public Mainfigure()
        {
            pen = new Pen(Color.Black, 1);
        }

        public Pen pen { get; set; } 

        public typesoffigures type { get; set; }

    }

}
