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

        var p1 = new Point(ShapeInfo.Box.Left, ShapeInfo.Box.Top); ;
        var p2 = new Point(ShapeInfo.Box.Right, ShapeInfo.Box.Bottom);
        p1.Offset(p);
        p2.Offset(p);
        graphics.DrawLine(outlinePen, p1, p2);
    }

    public override bool InShape(Point p)
    {
        throw new NotImplementedException();
    }

    public override string ToString() =>
        "type : line" + base.ToString();

}
