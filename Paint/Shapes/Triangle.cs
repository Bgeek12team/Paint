using System.Drawing;

namespace MPaintClassLib.Shares;

public class Triangle(ShapeInfo info)
    : Shape(info)
{
    public override void Draw(Graphics graphics, Point p)
    {
        System.Drawing.Rectangle triangleBox = ShapeInfo.Box;

        Point topVertex = new Point((triangleBox.Left + triangleBox.Right) / 2, triangleBox.Top);

        Point[] trianglePoints = { new Point(triangleBox.Left, triangleBox.Bottom),
                                   new Point(triangleBox.Right, triangleBox.Bottom),
                                    topVertex };

        var outlinePen = new Pen(ShapeInfo.BorderColor)
        {
            StartCap = System.Drawing.Drawing2D.LineCap.Round,
            EndCap = System.Drawing.Drawing2D.LineCap.Round
        };
        graphics.DrawPolygon(outlinePen, trianglePoints);

        if (ShapeInfo.FillColor != Color.Transparent)
        {

            using var fillBrush = new SolidBrush(ShapeInfo.FillColor);
            trianglePoints[0].Offset(FILL_MARGIN, -FILL_MARGIN);
            trianglePoints[1].Offset(-FILL_MARGIN, -FILL_MARGIN);
            trianglePoints[2].Offset(0, FILL_MARGIN);
            graphics.FillPolygon(fillBrush, trianglePoints);
            
        }
    }

    public override bool InShape(Point p)
    {
        throw new NotImplementedException();
    }

    public override string ToString() =>
        "type : triange" + base.ToString();

}
