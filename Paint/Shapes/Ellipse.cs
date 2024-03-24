using System.Drawing;

namespace MPaintClassLib.Shares;

public class Ellipse(ShapeInfo info)
    : Shape(info)
{
    public override void Draw(Graphics graphics, Point p)
    {
        var outlinePen = new Pen(ShapeInfo.BorderColor,4)
        {
            StartCap = System.Drawing.Drawing2D.LineCap.Round,
            EndCap = System.Drawing.Drawing2D.LineCap.Round
        };
        var rect = ShapeInfo.Box;
        rect.Offset(p);
        graphics.DrawEllipse(outlinePen, rect);

        if (ShapeInfo.FillColor != Color.Transparent)
        {
            using var fillBrush = new SolidBrush(ShapeInfo.FillColor);
            rect.Inflate(-FILL_MARGIN, -FILL_MARGIN);
            graphics.FillEllipse(fillBrush, rect);
        }
    }

    public override bool InShape(Point p)
    {
        Point center = new Point(ShapeInfo.Box.X + ShapeInfo.Box.Width / 2, ShapeInfo.Box.Y + ShapeInfo.Box.Height / 2);
        int a = ShapeInfo.Box.Width / 2;
        int b = ShapeInfo.Box.Height / 2;

        double distanceSquared = Math.Pow(p.X - center.X, 2) / Math.Pow(a, 2) + Math.Pow(p.Y - center.Y, 2) / Math.Pow(b, 2);

        return distanceSquared <= 1;
    }

    public override string ToString() =>
        "type : ellipse" + base.ToString();

}
