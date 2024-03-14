using System.Drawing;

namespace MPaintClassLib.Shares;

public class Line(ShapeInfo info)
    : Shape(info)
{
    public override void Draw(Graphics graphics, Point p)
    {
        var outlinePen = new Pen(ShapeInfo.BorderColor)
        {
            StartCap = System.Drawing.Drawing2D.LineCap.Round,
            EndCap = System.Drawing.Drawing2D.LineCap.Round
        };
        graphics.DrawLine(outlinePen, ShapeInfo.Box.Location, new Point(ShapeInfo.Box.Right, ShapeInfo.Box.Bottom));
    }

    public override bool InShape(Point p)
    {
        throw new NotImplementedException();
    }

    public override string ToString() =>
        "type : line" + base.ToString();

}
