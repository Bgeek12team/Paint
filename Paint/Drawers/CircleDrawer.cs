using MPaintClassLib.Shares;
using System.Reflection;

namespace MPaintClassLib.Drawers;

public class CircleDrawer : Drawer
{
    private CircleDrawer(Circle circle) : base(circle) { }

    private static CircleDrawer instance;

    public static CircleDrawer GetInstance(Circle circle) =>
        instance ??= new CircleDrawer(circle);


    public override void Draw(Graphics graphics, Point p)
    {
        Point center = Figure.ShapeInfo.Box.Location;
        int radius = Figure.ShapeInfo.Box.Width / 2;

        var circleBox = new System.Drawing.Rectangle(center.X - radius, center.Y - radius, 2 * radius, 2 * radius);
        using (var outlinePen = new Pen(Figure.ShapeInfo.BorderColor))
        {
            graphics.DrawEllipse(outlinePen, circleBox);
        }

        if (Figure.ShapeInfo.FillColor != Color.Transparent)
        {
            using (var fillBrush = new SolidBrush(Figure.ShapeInfo.FillColor))
            {
                graphics.FillEllipse(fillBrush, circleBox);
            }
        }
    }
}
