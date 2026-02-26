using System.Drawing;

namespace ShapesDrawing.Shapes
{
    /// Базовый абстрактный класс для всех фигур
    public abstract class Shape
    {
        public string Name { get; protected set; }
        public Color Color { get; set; } = Color.Black;

        // Виртуальный методы
        public abstract void Draw(Graphics g);

        public virtual string GetInfo()
        {
            return $"{Name}";
        }
    }
}