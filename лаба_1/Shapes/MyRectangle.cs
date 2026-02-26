using ShapesDrawing.Shapes;
using System.Drawing;
using System.Xml.Linq;

namespace лаба_1.Shapes
{
    public class MyRectangle : Shape 
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public MyRectangle(int x, int y, int width, int height)
        {
            Name = "Прямоугольник";
            X = x; Y = y; Width = width; Height = height;
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(Color, 2))
            {
                g.DrawRectangle(pen, X, Y, Width, Height);
            }
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}: X={X}, Y={Y}, W={Width}, H={Height}";
        }
    }
}