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
    public partial class Form1 : Form
    {
        Graphics g;

        Line line1 = new Line();
        Line line2 = new Line();

        Rectangle rect = new Rectangle();
        Rectangle rect2 = new Rectangle();

        Triangle treug = new Triangle();
        Triangle treug2 = new Triangle();

        Pentagon pent = new Pentagon();
        Pentagon pent2 = new Pentagon();

        Ellipse ell = new Ellipse();
        Ellipse ell2 = new Ellipse();

        Zvezda zv = new Zvezda();
        Zvezda zv2 = new Zvezda();

        FiguresDraw FList = new FiguresDraw();

        int WhatToDraw;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

            switch (WhatToDraw)
            {
                case 0:
                    line1.Draw(g);
                    break;
                case 1:
                    pent.Draw(g);
                    break;
                case 2:
                    rect.Draw(g);
                    break;
                case 3:
                    treug.Draw(g);
                    break;
                case 4:
                    ell.Draw(g);
                    break;
                case 5:
                    zv.Draw(g);
                    break;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            WhatToDraw = checkedListBox1.SelectedIndex;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();

            g.Clear(Color.White);

            Point point = new Point(52, 52);
            Point point2 = new Point(100, 100);
            Point point3 = new Point(77, 130);
            Point point4 = new Point(22, 120);
            Point point5 = new Point(10, 77);

            Point pointL1 = new Point(52, 52);
            Point pointL2 = new Point(100, 100);

            Point pointR1 = new Point(52, 150);
            Point pointR2 = new Point(172, 250);

            Point pointE1 = new Point(435, 170);
            Point pointE2 = new Point(625, 270);

            Point pointP1 = new Point(400, 75);
            Point pointP2 = new Point(425, 50);
            Point pointP3 = new Point(450, 75);
            Point pointP4 = new Point(435, 100);
            Point pointP5 = new Point(415, 100);

            Point pointZ1 = new Point(515, 60);
            Point pointZ2 = new Point(550, 30);
            Point pointZ3 = new Point(585, 60);
            Point pointZ4 = new Point(575, 100);
            Point pointZ5 = new Point(525, 100);

            Point pointT1 = new Point(300, 170);
            Point pointT2 = new Point(300, 270);
            Point pointT3 = new Point(400, 270);



            line1.ListOfPoints.Add(point);
            line1.ListOfPoints.Add(point3);

            line2.ListOfPoints.Add(pointL1);
            line2.ListOfPoints.Add(pointL2);

            rect.ListOfPoints.Add(point);
            rect.ListOfPoints.Add(point3);

            rect2.ListOfPoints.Add(pointR1);
            rect2.ListOfPoints.Add(pointR2);

            treug.ListOfPoints.Add(point);
            treug.ListOfPoints.Add(point2);
            treug.ListOfPoints.Add(point3);

            treug2.ListOfPoints.Add(pointT1);
            treug2.ListOfPoints.Add(pointT2);
            treug2.ListOfPoints.Add(pointT3);

            pent.ListOfPoints.Add(point);
            pent.ListOfPoints.Add(point2);
            pent.ListOfPoints.Add(point3);
            pent.ListOfPoints.Add(point4);
            pent.ListOfPoints.Add(point5);

            pent2.ListOfPoints.Add(pointP1);
            pent2.ListOfPoints.Add(pointP2);
            pent2.ListOfPoints.Add(pointP3);
            pent2.ListOfPoints.Add(pointP4);
            pent2.ListOfPoints.Add(pointP5);

            ell.ListOfPoints.Add(point);
            ell.ListOfPoints.Add(point5);

            ell2.ListOfPoints.Add(pointE1);
            ell2.ListOfPoints.Add(pointE2);

            zv.ListOfPoints.Add(point);
            zv.ListOfPoints.Add(point2);
            zv.ListOfPoints.Add(point3);
            zv.ListOfPoints.Add(point4);
            zv.ListOfPoints.Add(point5);

            zv2.ListOfPoints.Add(pointZ1);
            zv2.ListOfPoints.Add(pointZ2);
            zv2.ListOfPoints.Add(pointZ3);
            zv2.ListOfPoints.Add(pointZ4);
            zv2.ListOfPoints.Add(pointZ5);

            FList.FigureDraw.Add(line2);
            FList.FigureDraw.Add(zv2);
            FList.FigureDraw.Add(ell2);
            FList.FigureDraw.Add(pent2);
            FList.FigureDraw.Add(rect2);
            FList.FigureDraw.Add(treug2);

            button2_Click(sender,e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            FList.Draw(g);
        }

    }
}
