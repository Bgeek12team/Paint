using System.Drawing;

namespace MPaintClassLib.Shares;

public class Square(ShapeInfo info)
    : Shape(info)
{
    public override void Draw(Graphics graphics, Point p)
    {
        int sideLength = Math.Min(ShapeInfo.Box.Width, ShapeInfo.Box.Height);
        System.Drawing.Rectangle squareRect = new System.Drawing.Rectangle(ShapeInfo.Box.Location, new Size(sideLength, sideLength));

        using (var outlinePen = new Pen(ShapeInfo.BorderColor))
        {
            graphics.DrawRectangle(outlinePen, squareRect);
        }

        if (ShapeInfo.FillColor != Color.Transparent)
        {
            using (var fillBrush = new SolidBrush(ShapeInfo.FillColor))
            {
                graphics.FillRectangle(fillBrush, squareRect);
            }
        }
    }

    public override bool InShape(Point p)
    {
        throw new NotImplementedException();
    }

    public override string ToString() =>
        "type : square" + base.ToString();

}
