using ShapesDrawing.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using лаба_1.Shapes;

namespace лаба_1
{
    public class ShapeList
    {
        private List<Shape> shapes = new List<Shape>();

        public void AddShape(Shape shape)
        {
            shapes.Add(shape);
            Console.WriteLine($"Добавлена фигура: {shape.GetInfo()}");
        }

        public void DrawAll(Graphics g)
        {
            foreach (Shape shape in shapes)
            {
                shape.Draw(g);
            }
        }

        public void ShowAllInfo()
        {
            Console.WriteLine($"\n=== Всего фигур: {shapes.Count} ===");
            for (int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {shapes[i].GetInfo()}");
            }
        }
    }
}