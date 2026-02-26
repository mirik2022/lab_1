using ShapesDrawing.Shapes;
using System;
using System.Drawing;
using System.Windows.Forms;
using лаба_1.Shapes; 

namespace лаба_1
{
    public partial class Form1 : Form
    {
        private ShapeList shapeList;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Рисование фигур";
            this.Size = new Size(800, 600);
            this.Paint += Form1_Paint;

            shapeList = new ShapeList();
            InitializeShapes();
            shapeList.ShowAllInfo();
        }

        private void InitializeShapes()
        {
            shapeList.AddShape(new Line(50, 50, 200, 50) );
            shapeList.AddShape(new MyRectangle(50, 100, 150, 80) { Color = Color.Blue });
            shapeList.AddShape(new Square(250, 100, 80) { Color = Color.Green });
            shapeList.AddShape(new Ellipse(50, 250, 120, 60) { Color = Color.Orange });
            shapeList.AddShape(new Circle(250, 280, 50) { Color = Color.Purple });
            shapeList.AddShape(new Triangle(400, 100, 500, 50, 550, 150) { Color = Color.Brown });
            shapeList.AddShape(new MyRectangle(400, 200, 150, 80) { Color = Color.Cyan });
            shapeList.AddShape(new Circle(500, 400, 40) { Color = Color.Magenta });
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            shapeList.DrawAll(g);
        }
    }
}