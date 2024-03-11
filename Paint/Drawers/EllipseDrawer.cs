using MPaintClassLib.Shares;

namespace MPaintClassLib.Drawers;

public class EllipseDrawer : Drawer
{
    private EllipseDrawer(Ellipse ellipse) : base(ellipse) { }

    private static EllipseDrawer instance;

    public static EllipseDrawer GetInstance(Ellipse ellipse) =>
        instance ??= new EllipseDrawer(ellipse);


    public override void Draw(Graphics graphics, Point p)
    {
        using var outlinePen = new Pen(Figure.ShapeInfo.BorderColor);
        graphics.DrawEllipse(outlinePen, Figure.ShapeInfo.Box);

        if (Figure.ShapeInfo.FillColor != Color.Transparent)
        {
            using var fillBrush = new SolidBrush(Figure.ShapeInfo.FillColor);
            graphics.FillEllipse(fillBrush, Figure.ShapeInfo.Box);
        }
    }
}
