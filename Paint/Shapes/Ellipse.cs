using System.Drawing;

namespace MPaintClassLib.Shares;

public class Ellipse(ShapeInfo info)
    : Shape(info)
{
    public override void Draw(Graphics graphics, Point p)
    {
        using var outlinePen = new Pen(ShapeInfo.BorderColor);
        graphics.DrawEllipse(outlinePen, ShapeInfo.Box);

        if (ShapeInfo.FillColor != Color.Transparent)
        {
            using var fillBrush = new SolidBrush(ShapeInfo.FillColor);
            graphics.FillEllipse(fillBrush, ShapeInfo.Box);
        }
    }

    public override bool InShape(Point p)
    {
        throw new NotImplementedException();
    }

    public override string ToString() =>
        "type : ellipse" + base.ToString();

}
