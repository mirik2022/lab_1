namespace лаба_1.Shapes
{
    public class Square : MyRectangle 
    {
        public Square(int x, int y, int side) : base(x, y, side, side)
        {
            Name = "Квадрат";
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}: X={X}, Y={Y}, сторона={Width}";
        }
    }
}