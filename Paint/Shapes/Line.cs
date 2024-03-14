using System.Drawing;

namespace MPaintClassLib.Shares;

public class Line(ShapeInfo info)
    : Shape(info)
{
    public Point StartPoint { get; set; }
    public Point EndPoint { get; set; }

    public override void Draw(Graphics graphics, Point p)
    {
        var outlinePen = new Pen(ShapeInfo.BorderColor)
        {
            StartCap = System.Drawing.Drawing2D.LineCap.Round,
            EndCap = System.Drawing.Drawing2D.LineCap.Round
        };

        var p1 = new Point(ShapeInfo.Box.Left, ShapeInfo.Box.Top);
        var p2 = new Point(ShapeInfo.Box.Right, ShapeInfo.Box.Bottom);
        p1.Offset(p);
        p2.Offset(p);
        graphics.DrawLine(outlinePen, p1, p2);
    }

    public void Draw(Graphics graphics, Point p1, Point p2)
    {
        StartPoint = p1;
        EndPoint = p2;
        var outlinePen = new Pen(ShapeInfo.BorderColor)
        {
            StartCap = System.Drawing.Drawing2D.LineCap.Round,
            EndCap = System.Drawing.Drawing2D.LineCap.Round
        };
        graphics.DrawLine(outlinePen, p1, p2);
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
