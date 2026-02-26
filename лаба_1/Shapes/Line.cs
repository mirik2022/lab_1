using System.Drawing;

namespace ShapesDrawing.Shapes
{
    public class Line : Shape
    {
        public Point Start { get; set; }
        public Point End { get; set; }

        public Line(Point start, Point end)
        {
            Name = "Отрезок";
            Start = start;
            End = end;
        }

        public Line(int x1, int y1, int x2, int y2)
            : this(new Point(x1, y1), new Point(x2, y2))
        {
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(Color, 2))
            {
                g.DrawLine(pen, Start, End);
            }
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()} от ({Start.X},{Start.Y}) до ({End.X},{End.Y})";
        }
    }
}