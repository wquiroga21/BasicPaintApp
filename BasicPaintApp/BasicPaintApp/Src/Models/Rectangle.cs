using System.Drawing;

namespace BasicPaintApp.Src.Models
{
    public class Rectangle : Shape
    {
        public Rectangle(Point startPoint, Point endPoint, Color color, float penWidth)
            : base(startPoint, endPoint, color, penWidth)
        {
        }

        public override void Draw(Graphics g)
        {
            using (var pen = new Pen(ShapeColor, PenWidth))
            {
                g.DrawRectangle(pen, Math.Min(StartPoint.X, EndPoint.X), Math.Min(StartPoint.Y, EndPoint.Y),
                                Math.Abs(EndPoint.X - StartPoint.X), Math.Abs(EndPoint.Y - StartPoint.Y));
            }
        }
    }
}
