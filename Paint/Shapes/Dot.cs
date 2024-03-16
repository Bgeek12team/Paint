
namespace MPaintClassLib.Shares;


internal class Dot(ShapeInfo info) : Shape(info)
{
    public override void Draw(Graphics graphics, Point p)
    {
        int radius = ShapeInfo.Box.Width / 2;

        var circleBox = ShapeInfo.Box;
        circleBox.Offset(p.X - radius, p.Y - radius);
        var outlinePen = new Pen(ShapeInfo.BorderColor)
        {
            StartCap = System.Drawing.Drawing2D.LineCap.Round,
            EndCap = System.Drawing.Drawing2D.LineCap.Round
        };
        graphics.DrawEllipse(outlinePen, circleBox);

        if (ShapeInfo.FillColor != Color.Transparent)
        {
            using var fillBrush = new SolidBrush(ShapeInfo.FillColor);
            graphics.FillEllipse(fillBrush, circleBox);
        }
    }

    public override bool InShape(Point p)
    {
        Point center = new Point(ShapeInfo.Box.X + ShapeInfo.Box.Width / 2, ShapeInfo.Box.Y + ShapeInfo.Box.Height / 2);
        int radius = ShapeInfo.Box.Width / 2;

        int distanceSquared = (p.X - center.X) * (p.X - center.X) + (p.Y - center.Y) * (p.Y - center.Y);
        int radiusSquared = radius * radius;

        return distanceSquared <= radiusSquared;
    }
}
