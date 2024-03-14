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
        var startPoint = ShapeInfo.Box.Location;
        var endPoint = new Point(ShapeInfo.Box.Right, ShapeInfo.Box.Bottom);

        double m = (double)(endPoint.Y - startPoint.Y) / (endPoint.X - startPoint.X); 
        double c = startPoint.Y - m * startPoint.X; 

        return Math.Abs(p.Y - (m * p.X + c)) < 0.1;
    }

    public override string ToString() =>
        "type : line" + base.ToString();

}
