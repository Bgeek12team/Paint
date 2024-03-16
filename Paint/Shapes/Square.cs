using System.Drawing;

namespace MPaintClassLib.Shares;

public class Square(ShapeInfo info)
    : Rectangle(info)
{
    public override void Draw(Graphics graphics, Point p)
    {
        int sideLength = Math.Min(ShapeInfo.Box.Width, ShapeInfo.Box.Height);
        System.Drawing.Rectangle squareRect = new System.Drawing.Rectangle(ShapeInfo.Box.Location, new Size(sideLength, sideLength));
        squareRect.Offset(p);
        var outlinePen = new Pen(ShapeInfo.BorderColor)
        {
            StartCap = System.Drawing.Drawing2D.LineCap.Round,
            EndCap = System.Drawing.Drawing2D.LineCap.Round
        };
        graphics.DrawRectangle(outlinePen, squareRect);

        if (ShapeInfo.FillColor != Color.Transparent)
        {
            
            using var fillBrush = new SolidBrush(ShapeInfo.FillColor);
            var rect = squareRect;
            rect.Inflate(-FILL_MARGIN, -FILL_MARGIN);
            graphics.FillRectangle(fillBrush, rect);
        }
    }

    public override bool InShape(Point p)
    {
        var squareRect = new System.Drawing.Rectangle(ShapeInfo.Box.Location, new Size(Math.Min(ShapeInfo.Box.Width, ShapeInfo.Box.Height), Math.Min(ShapeInfo.Box.Width, ShapeInfo.Box.Height)));

        return squareRect.Contains(p);
    }

    public override string ToString() =>
        "type : square" + base.ToString();

}
