using System.Drawing;

namespace ShapesDrawing.Shapes
{
    public class Triangle : Shape
    {
        public Point[] Points { get; set; }

        public Triangle(Point p1, Point p2, Point p3)
        {
            Name = "Треугольник";
            Points = new Point[] { p1, p2, p3 };
        }

        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
            : this(new Point(x1, y1), new Point(x2, y2), new Point(x3, y3))
        {
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(Color, 2))
            {
                g.DrawPolygon(pen, Points);
            }
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}: ({Points[0].X},{Points[0].Y}), ({Points[1].X},{Points[1].Y}), ({Points[2].X},{Points[2].Y})";
        }
    }
}