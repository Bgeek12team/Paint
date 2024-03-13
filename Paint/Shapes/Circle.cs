using System.Drawing;

namespace MPaintClassLib.Shares;

public class Circle(ShapeInfo info)
    : Shape(info)
{

    public override string ToString() =>
        "type : circle" + base.ToString();
    public override void Draw(Graphics graphics, Point p)
    {
        Point center = ShapeInfo.Box.Location;
        int radius = ShapeInfo.Box.Width / 2;

        var circleBox = new System.Drawing.Rectangle(center.X - radius, center.Y - radius, 2 * radius, 2 * radius);
        using (var outlinePen = new Pen(ShapeInfo.BorderColor))
        {
            graphics.DrawEllipse(outlinePen, circleBox);
        }

        if (ShapeInfo.FillColor != Color.Transparent)
        {
            using (var fillBrush = new SolidBrush(ShapeInfo.FillColor))
            {
                graphics.FillEllipse(fillBrush, circleBox);
            }
        }
    }

    public override bool InShape(Point p)
    {
        throw new NotImplementedException();
    }
}
