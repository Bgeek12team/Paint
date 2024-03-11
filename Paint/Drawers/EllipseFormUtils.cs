using MPaintClassLib.Shares;

namespace MPaintClassLib.Drawers;

public class EllipseFormUtils : FormUtils
{
    private EllipseFormUtils(Ellipse ellipse) : base(ellipse) { }

    private static EllipseFormUtils instance;

    public static EllipseFormUtils GetInstance(Ellipse ellipse) =>
        instance ??= new EllipseFormUtils(ellipse);


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

    public override bool InShape(Point p)
    {
        throw new NotImplementedException();
    }
}
