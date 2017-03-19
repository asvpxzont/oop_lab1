using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures
{
    class FiguresDraw
    {
        public List<Mainfigure> FigureDraw { get; set; }
        public FiguresDraw()
        {
            FigureDraw = new List<Mainfigure>();
        }

        public void Draw (Graphics g)
        {
            for (int i=0;i<FigureDraw.Count;i++)
            {
                FigureDraw[i].pen = new Pen(Color.Black, 1);
                FigureDraw[i].Draw(g);
            }
            
        }

    }
}
