using System.Drawing;

namespace MPaintClassLib.Shares;

public class Ellipse(ShapeInfo info)
    : Shape(info)
{
    public override void Draw(Graphics graphics, Point p)
    {
        var outlinePen = new Pen(ShapeInfo.BorderColor)
        {
            StartCap = System.Drawing.Drawing2D.LineCap.Round,
            EndCap = System.Drawing.Drawing2D.LineCap.Round
        };
        graphics.DrawEllipse(outlinePen, ShapeInfo.Box);

        if (ShapeInfo.FillColor != Color.Transparent)
        {
            using var fillBrush = new SolidBrush(ShapeInfo.FillColor);
            var rect = ShapeInfo.Box;
            rect.Inflate(-FILL_MARGIN, -FILL_MARGIN);
            graphics.FillEllipse(fillBrush, rect);
        }
    }

    public override bool InShape(Point p)
    {
        throw new NotImplementedException();
    }

    public override string ToString() =>
        "type : ellipse" + base.ToString();

}
