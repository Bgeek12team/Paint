using System.Drawing;

namespace MPaintClassLib.Shares;

public class Line(ShapeInfo info)
    : Shape(info)
{
    public override void Draw(Graphics graphics, Point p)
    {
        using var linePen = new Pen(ShapeInfo.BorderColor);
        graphics.DrawLine(linePen, ShapeInfo.Box.Location, new Point(ShapeInfo.Box.Right, ShapeInfo.Box.Bottom));
    }

    public override bool InShape(Point p)
    {
        throw new NotImplementedException();
    }

    public override string ToString() =>
        "type : line" + base.ToString();

}
