namespace ShapesDrawing.Shapes
{
    public class Circle : Ellipse
    {
        public Circle(int x, int y, int radius) : base(x, y, radius, radius)
        {
            Name = "Круг";
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}: центр=({X + Width / 2},{Y + Height / 2}), радиус={Width / 2}";
        }
    }
}