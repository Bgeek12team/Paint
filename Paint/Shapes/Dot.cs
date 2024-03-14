
namespace MPaintClassLib.Shares;


internal class Dot(ShapeInfo info) : Shape(info)
{
    public override void Draw(Graphics graphics, Point p)
    {
        Point center = ShapeInfo.Box.Location;
        int radius = ShapeInfo.Box.Width / 2;

        var circleBox = ShapeInfo.Box;
        circleBox.Offset(p);
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
        throw new NotImplementedException();
    }
}
