using MPaintClassLib.Shares;

namespace MPaintClassLib.Drawers;

public class TriangleDrawer : Drawer
{
    private TriangleDrawer(Triangle triangle) : base(triangle) { }

    private static TriangleDrawer instance;

    public static TriangleDrawer GetInstance(Triangle triangle) =>
        instance ??= new TriangleDrawer(triangle);


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
}
