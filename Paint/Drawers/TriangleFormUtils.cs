using MPaintClassLib.Shares;

namespace MPaintClassLib.Drawers;

public class TriangleFormUtils : FormUtils
{
    private TriangleFormUtils(Triangle triangle) : base(triangle) { }

    private static TriangleFormUtils instance;

    public static TriangleFormUtils GetInstance(Triangle triangle) =>
        instance ??= new TriangleFormUtils(triangle);


    public override void Draw(Graphics graphics, Point p)
    {
        System.Drawing.Rectangle triangleBox = Figure.ShapeInfo.Box;

        Point topVertex = new Point((triangleBox.Left + triangleBox.Right) / 2, triangleBox.Top);

        Point[] trianglePoints = { new Point(triangleBox.Left, triangleBox.Bottom),
                                           new Point(triangleBox.Right, triangleBox.Bottom),
                                           topVertex };

        using (var outlinePen = new Pen(Figure.ShapeInfo.BorderColor))
        {
            graphics.DrawPolygon(outlinePen, trianglePoints);
        }

        if (Figure.ShapeInfo.FillColor != Color.Transparent)
        {
            using (var fillBrush = new SolidBrush(Figure.ShapeInfo.FillColor))
            {
                graphics.FillPolygon(fillBrush, trianglePoints);
            }
        }
    }

    public override bool InShape(Point p)
    {
        throw new NotImplementedException();
    }
}
