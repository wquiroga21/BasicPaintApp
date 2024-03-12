using System.Drawing;

namespace BasicPaintApp.Src.Models
{
    public abstract class Shape
    {
        // Properties for the starting point, ending point, color, and pen width of the shape
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public Color ShapeColor { get; set; }
        public float PenWidth { get; set; } = 2; // Default pen width

        // Constructor for the Shape class
        protected Shape(Point startPoint, Point endPoint, Color color, float penWidth)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            ShapeColor = color;
            PenWidth = penWidth;
        }

        // Abstract method to draw the shape on a Graphics object
        public abstract void Draw(Graphics g);
    }
}
