using System.Drawing;

namespace BasicPaintApp.Src.Models
{
    public class Line : Shape
    {
        public Line(Point startPoint, Point endPoint, Color color, float penWidth)
            : base(startPoint, endPoint, color, penWidth)
        {
        }

        public override void Draw(Graphics g)
        {
            using (var pen = new Pen(ShapeColor, PenWidth))
            {
                g.DrawLine(pen, StartPoint, EndPoint);
            }
        }
    }
}
