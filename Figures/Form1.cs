using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    public enum typesoffigures { line, triangle, rectangle, circle, ellipse, square };
    
    public partial class Form1 : Form
    {
        Graphics g;
        public delegate Drawer NewDrawer();
        private Dictionary<int, Typeinfo> Dictionary;
        DrawerFactory CurrentFactory = new DrawerFactory();
        Mainfigure CurrentFigure = new Mainfigure();
        typesoffigures chosenfigure;
        struct Typeinfo
        {
            public string name { get; set; }
            public NewDrawer creator { get; set; }
            public typesoffigures figuretype { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            Dictionary = new Dictionary<int, Typeinfo>();
            Dictionary.Add(0, new Typeinfo() { name = "line", creator = () => { return new LineDrawer(); }, figuretype = typesoffigures.line });
            Dictionary.Add(1, new Typeinfo() { name = "triangle", creator = () => { return new TriangleDrawer(); }, figuretype = typesoffigures.triangle });
            Dictionary.Add(2, new Typeinfo() { name = "rectangle", creator = () => { return new RectangleDrawer(); }, figuretype = typesoffigures.rectangle });
            Dictionary.Add(3, new Typeinfo() { name = "circle", creator = () => { return new CircleDrawer(); }, figuretype = typesoffigures.circle });
            Dictionary.Add(4, new Typeinfo() { name = "ellipse", creator = () => { return new EllipseDrawer(); }, figuretype = typesoffigures.ellipse });
            Dictionary.Add(5, new Typeinfo() { name = "square", creator = () => { return new SquareDrawer(); }, figuretype = typesoffigures.square });
        }

        Point firstpoint = new Point(0, 0);
        Point secondpoint = new Point(0, 0);
        bool firstclick = true;
        bool secondclick = false;
        bool buf = false;


        private void Clear_btn_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (secondclick == true)
            {
                buf = true;
                secondclick = false;
                secondpoint = e.Location;
                Drawer CurrentDrawer = Dictionary[comboBox1.SelectedIndex].creator();
                if (CurrentDrawer != null)
                {
                    CurrentFigure.Point1 = firstpoint;
                    CurrentFigure.Point2 = secondpoint;
                    CurrentFigure.type = chosenfigure;
                    CurrentDrawer.Draw(CurrentFigure, g);
                }

            }
            if (firstclick == true)
            {
                firstclick = false;
                firstpoint = e.Location;
                secondclick = true;
            }
            if (buf == true)
            {
                buf = false;
                firstclick = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenfigure = (typesoffigures)comboBox1.SelectedIndex;
            int currentindex = comboBox1.SelectedIndex;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
