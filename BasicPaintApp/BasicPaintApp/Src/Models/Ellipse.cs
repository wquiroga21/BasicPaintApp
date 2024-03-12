using System.Drawing;

namespace BasicPaintApp.Src.Models
{
    public class Ellipse : Shape
    {
        public Ellipse(Point startPoint, Point endPoint, Color color, float penWidth)
            : base(startPoint, endPoint, color, penWidth)
        {
        }

        public override void Draw(Graphics g)
        {
            using (var pen = new Pen(ShapeColor, PenWidth))
            {
                g.DrawEllipse(pen, Math.Min(StartPoint.X, EndPoint.X), Math.Min(StartPoint.Y, EndPoint.Y),
                              Math.Abs(EndPoint.X - StartPoint.X), Math.Abs(EndPoint.Y - StartPoint.Y));
            }
        }
    }
}
