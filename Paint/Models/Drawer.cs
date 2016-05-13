using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.Models
{
    public enum Shape
    {
        Pencil,
        Line,
        Eraser,
        Ellipse,
        Rectangle,
        Triangle,
        trapezoid,
        octagon,
        romb,
        hexagon,
        hexagon2,
        cube,
        star,
        pen1
    }

    class Drawer
    {
        public bool IsImage = false;
        public Bitmap bmp;
        public Graphics g;
        public Pen pen;
        Point prevPoint;
        public PictureBox pBox;
        GraphicsPath gPath;

        public Shape Shape;

        public Drawer(PictureBox pBox)
        {
            Shape = Shape.Pencil;

            this.pBox = pBox;

            this.pBox.MouseMove += PictureBox_MouseMove;
            this.pBox.MouseDown += PBox_MouseDown;
            this.pBox.MouseUp += PBox_MouseUp;
            this.pBox.Paint += PBox_Paint;



            pen = new Pen(Color.Black);

            Load("");
        }

        private void PBox_Paint(object sender, PaintEventArgs e)
        {
            if(gPath != null)
            {
                e.Graphics.DrawPath(pen, gPath);
            }

            
        }

        private void PBox_MouseUp(object sender, MouseEventArgs e)
        {
            if(gPath != null)
            {
                g.DrawPath(pen, gPath);
                gPath = null;
            }
        }


        private void PBox_MouseDown(object sender, MouseEventArgs e)
        {
            prevPoint = e.Location;
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Draw(e.Location);
            }
        }

        public void Draw(Point currentPoint)
        {

            IsImage = true;
            switch (Shape)
            {
                case Shape.Pencil:
                    g.DrawLine(pen, prevPoint, currentPoint);
                    prevPoint = currentPoint;
                    break;
                case Shape.pen1:
                    g.DrawLine(pen, prevPoint, currentPoint);
                    prevPoint = currentPoint;
                    break;
                case Shape.Line:
                    gPath = new GraphicsPath();
                    gPath.AddLine(prevPoint, currentPoint);
                    break;
                case Shape.Ellipse:
                    gPath = new GraphicsPath();
                    gPath.AddEllipse(prevPoint.X, prevPoint.Y, currentPoint.X - prevPoint.X, currentPoint.Y - prevPoint.Y);
                    break;
                case Shape.Rectangle:
                    gPath = new GraphicsPath();

                    int width = Math.Abs(currentPoint.X - prevPoint.X); 
                    int height = Math.Abs(currentPoint.Y - prevPoint.Y); 
                    int FX = prevPoint.X, FY = prevPoint.Y; 

                    if (currentPoint.X < prevPoint.X) FX = currentPoint.X; 
                    if (currentPoint.Y < prevPoint.Y) FY = currentPoint.Y; 

                    Rectangle r = new Rectangle(FX, FY, width, height); 
                    gPath.AddRectangle(r);
                    break;
                case Shape.Triangle:
                    gPath = new GraphicsPath();
                    Point p1 = new Point(), p2 = new Point(), p3 = new Point(); 

                    p1.X = prevPoint.X; 
                    p1.Y = prevPoint.Y;

                    p2.X = prevPoint.X + Math.Abs(currentPoint.X - prevPoint.X);
                    p2.Y = prevPoint.Y + Math.Abs(currentPoint.Y - prevPoint.Y);

                    p3.X = prevPoint.X - Math.Abs(currentPoint.X - prevPoint.X);
                    p3.Y = prevPoint.Y + Math.Abs(currentPoint.Y - prevPoint.Y);

                    Point[] points = { p1, p2, p3 };
                    gPath.AddPolygon(points);
                    break;
                case Shape.trapezoid:
                    gPath = new GraphicsPath();
                    Point pp1 = new Point(), pp2 = new Point(), pp3 = new Point(), pp4 = new Point();
                    //Point[] arrtrap =
                   {
                        pp1.X = prevPoint.X + ((currentPoint.X - prevPoint.X) / 4);
                        pp1.Y = prevPoint.Y;

                        pp2.X = currentPoint.X - ((currentPoint.X - prevPoint.X) / 4);
                        pp2.Y = prevPoint.Y;

                        pp3.X = currentPoint.X;
                        pp3.Y = currentPoint.Y;

                        pp4.X = prevPoint.X;
                        pp4.Y = currentPoint.Y;
                        //new Point(prevPoint.X+(currentPoint.X-prevPoint.X)/3,prevPoint.Y),
                        //new Point(currentPoint.X-(currentPoint.X-prevPoint.X)/3,prevPoint.Y),
                        //new Point(currentPoint.X,currentPoint.Y),
                        //new Point(prevPoint.X,currentPoint.Y),
                    };
                    // gPath.AddPolygon(arrtrap);
                    Point[] pointstrap = { pp1, pp2, pp3, pp4 };
                    gPath.AddPolygon(pointstrap);
                    break;
                case Shape.Eraser:
                    Rectangle eRaser = new Rectangle(prevPoint.X - 10, prevPoint.Y - 10, 20, 20);
                    g.FillRectangle(new SolidBrush(Color.White), eRaser);
                    prevPoint = currentPoint;
                    break;
                case Shape.octagon:
                    gPath = new GraphicsPath();
                    Point[] arr5 =
                    {
                        new Point(prevPoint.X+(currentPoint.X-prevPoint.X)/3,prevPoint.Y),
                        new Point(currentPoint.X-(currentPoint.X-prevPoint.X)/3,prevPoint.Y),
                        new Point(currentPoint.X,prevPoint.Y+(currentPoint.Y-prevPoint.Y)/3),
                        new Point(currentPoint.X,currentPoint.Y-(currentPoint.Y-prevPoint.Y)/3),
                        new Point(currentPoint.X-(currentPoint.X-prevPoint.X)/3,currentPoint.Y),
                        new Point(prevPoint.X+(currentPoint.X - prevPoint.X) / 3,currentPoint.Y),
                        new Point(prevPoint.X,currentPoint.Y-(currentPoint.Y-prevPoint.Y)/3),
                        new Point(prevPoint.X,prevPoint.Y+(currentPoint.Y-prevPoint.Y)/3),
                    };
                    gPath.AddPolygon(arr5);
                    break;
                case Shape.romb:
                    gPath = new GraphicsPath();
                    Point[] arr2 ={
                        new Point(prevPoint.X+(currentPoint.X-prevPoint.X)/2,prevPoint.Y),
                        new Point(currentPoint.X,prevPoint.Y+(currentPoint.Y-prevPoint.Y)/2),
                        new Point(currentPoint.X-(currentPoint.X-prevPoint.X)/2,currentPoint.Y),
                        new Point(prevPoint.X,currentPoint.Y-(currentPoint.Y-prevPoint.Y)/2),
                    };
                    gPath.AddPolygon(arr2);
                    break;
                case Shape.hexagon:
                    gPath = new GraphicsPath();
                    Point[] arr4 =
                    {
                        new Point(prevPoint.X+(currentPoint.X-prevPoint.X)/3,prevPoint.Y),
                        new Point(currentPoint.X-(currentPoint.X-prevPoint.X)/3,prevPoint.Y),
                        new Point(currentPoint.X,(currentPoint.Y + prevPoint.Y) / 2),
                        new Point(currentPoint.X-(currentPoint.X-prevPoint.X)/3,currentPoint.Y),
                        new Point(prevPoint.X+(currentPoint.X-prevPoint.X)/3,currentPoint.Y),
                        new Point(prevPoint.X,(currentPoint.Y + prevPoint.Y) / 2),
                    };
                    gPath.AddPolygon(arr4);
                    break;
                case Shape.star:
                    gPath = new GraphicsPath();
                    Point[] arr6 =
                    {
                        new Point(prevPoint.X+(currentPoint.X-prevPoint.X)/2,prevPoint.Y),
                        new Point(currentPoint.X-(currentPoint.X-prevPoint.X)/3,prevPoint.Y+(currentPoint.Y-prevPoint.Y)/3),
                        //new Point(currentPoint.X,prevPoint.Y+(currentPoint.Y-prevPoint.Y)/4),
                        new Point(currentPoint.X-(currentPoint.X-prevPoint.X)/3,currentPoint.Y-(currentPoint.Y-prevPoint.Y)/4),
                        new Point(currentPoint.X-(currentPoint.X-prevPoint.X)/4,currentPoint.Y),
                        new Point(prevPoint.X+(currentPoint.X-prevPoint.X)/2,currentPoint.Y-(currentPoint.Y-prevPoint.Y)/5),
                        new Point(prevPoint.X+(currentPoint.X-prevPoint.X)/5,currentPoint.Y),
                        new Point(prevPoint.X+(currentPoint.X-prevPoint.X)/3,prevPoint.Y+(currentPoint.Y-prevPoint.Y)/3),
                        new Point(prevPoint.X,prevPoint.Y+(currentPoint.Y-prevPoint.Y)/2),
                        new Point(prevPoint.X+(currentPoint.X-prevPoint.X)/4,prevPoint.Y+(currentPoint.Y-prevPoint.Y)/4),
                    };
                    gPath.AddPolygon(arr6);
                    break;
                case Shape.hexagon2:
                    gPath = new GraphicsPath();
                    Point[] end =
                    {
                        new Point(prevPoint.X+(currentPoint.X-prevPoint.X)/2,prevPoint.Y),
                        new Point(currentPoint.X,prevPoint.Y+(currentPoint.Y-prevPoint.Y)/3),
                        new Point(currentPoint.X,currentPoint.Y-(currentPoint.Y - prevPoint.Y) / 3),
                        new Point(currentPoint.X-(currentPoint.X-prevPoint.X)/2,currentPoint.Y),
                        new Point(prevPoint.X,currentPoint.Y-(currentPoint.Y-prevPoint.Y)/3),
                        new Point(prevPoint.X,prevPoint.Y+(currentPoint.Y - prevPoint.Y) / 3),
                    };
                    gPath.AddPolygon(end);
                    break;
                case Shape.cube:
                    gPath = new GraphicsPath();
                    Point[] end1 =
                    {
                        new Point(prevPoint.X+(currentPoint.X-prevPoint.X)/4,prevPoint.Y),
                        new Point(currentPoint.X,prevPoint.Y),
                        new Point(currentPoint.X,currentPoint.Y-(currentPoint.Y - prevPoint.Y) / 4),
                        new Point(currentPoint.X-(currentPoint.X - prevPoint.X) / 4,currentPoint.Y),
                        new Point(prevPoint.X,currentPoint.Y),
                        new Point(prevPoint.X,prevPoint.Y+(currentPoint.Y-prevPoint.Y)/4),

                    };
                    gPath.AddPolygon(end1);

                    Point[] end2 =
                    {
                        new Point(prevPoint.X, prevPoint.Y+(currentPoint.Y-prevPoint.Y)/4),
                        new Point(currentPoint.X-(currentPoint.X-prevPoint.X)/4,prevPoint.Y+(currentPoint.Y-prevPoint.Y)/4),
                        new Point(currentPoint.X,prevPoint.Y),
                        new Point(currentPoint.X,currentPoint.Y-(currentPoint.Y - prevPoint.Y) / 4),
                        new Point(currentPoint.X-(currentPoint.X - prevPoint.X) / 4,currentPoint.Y),
                        new Point(currentPoint.X-(currentPoint.X-prevPoint.X)/4,prevPoint.Y+(currentPoint.Y-prevPoint.Y)/4),

                    };
                    gPath.AddPolygon(end2);
                    Point[] end3 =
                   {
                        new Point(prevPoint.X+(currentPoint.X-prevPoint.X)/4,prevPoint.Y),
                        new Point(prevPoint.X+(currentPoint.X-prevPoint.X)/4,currentPoint.Y-(currentPoint.Y-prevPoint.Y)/4),
                        new Point(currentPoint.X,currentPoint.Y-(currentPoint.Y - prevPoint.Y) / 4),
                        new Point(currentPoint.X-(currentPoint.X - prevPoint.X) / 4,currentPoint.Y),
                        new Point(prevPoint.X,currentPoint.Y),
                        new Point(prevPoint.X+(currentPoint.X-prevPoint.X)/4,currentPoint.Y-(currentPoint.Y-prevPoint.Y)/4),
                    };
                    gPath.AddPolygon(end3);

                    break;
            }

            pBox.Refresh();
        }

        public void Load(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                bmp = new Bitmap(pBox.Width, pBox.Height);
                g = Graphics.FromImage(bmp);

                g.Clear(Color.White);

            }
            else
            {
                bmp = new Bitmap(fileName);
                g = Graphics.FromImage(bmp);
            }
            pBox.Image = bmp;

        }

        public void Save(string fileName)
        {
            bmp.Save(fileName);

        }

    }
}
