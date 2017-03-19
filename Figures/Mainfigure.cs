using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures
{
    abstract class Mainfigure
    {
        public Mainfigure()
        {
            ListOfPoints = new List<Point>();
            pen = new Pen(Color.Black, 1);
        }

        public List<Point> ListOfPoints { get; set; }
        public int NumberOfPoints { get; set; }
        public Pen pen { get; set; } 

        public virtual void Draw(Graphics g) {}

    }

}
