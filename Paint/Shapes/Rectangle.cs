using System.Drawing;

namespace MPaintClassLib.Shares;

public class Rectangle(ShapeInfo info)
    : Shape(info)
{
    public override void Draw(Graphics graphics, Point p)
    {
        var outlinePen = new Pen(ShapeInfo.BorderColor)
        {
            StartCap = System.Drawing.Drawing2D.LineCap.Round,
            EndCap = System.Drawing.Drawing2D.LineCap.Round
        };
        var rect = ShapeInfo.Box;
        rect.Offset(p);
        graphics.DrawRectangle(outlinePen, rect);
        

        if (ShapeInfo.FillColor != Color.Transparent)
        {
            using var fillBrush = new SolidBrush(ShapeInfo.FillColor);
            rect.Inflate(-FILL_MARGIN, -FILL_MARGIN);
            graphics.FillRectangle(fillBrush, rect);
        }
    }

    public override bool InShape(Point p)
    {
        var rect = new System.Drawing.Rectangle(ShapeInfo.Box.Location, ShapeInfo.Box.Size);
        return rect.Contains(p);
    }

    public override string ToString() =>
        "type : rectange" + base.ToString();

}
