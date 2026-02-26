using System.Drawing;

namespace ShapesDrawing.Shapes
{
    public class Ellipse : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Ellipse(int x, int y, int width, int height)
        {
            Name = "Эллипс";
            X = x; Y = y; Width = width; Height = height;
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(Color, 2))
            {
                g.DrawEllipse(pen, X, Y, Width, Height);
            }
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}: X={X}, Y={Y}, W={Width}, H={Height}";
        }
    }
}