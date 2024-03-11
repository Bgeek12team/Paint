using MPaintClassLib.Shares;

namespace MPaintClassLib.Drawers;

public class LineFormUtils : FormUtils
{
    private LineFormUtils(Line line) : base(line) { }

    private static LineFormUtils instance;

    public static LineFormUtils GetInstance(Line line) =>
        instance ??= new LineFormUtils(line);


    public override void Draw(Graphics graphics, Point p)
    {
        using var linePen = new Pen(Figure.ShapeInfo.BorderColor);
        graphics.DrawLine(linePen, Figure.ShapeInfo.Box.Location, new Point(Figure.ShapeInfo.Box.Right, Figure.ShapeInfo.Box.Bottom));
    }

    public override bool InShape(Point p)
    {
        throw new NotImplementedException();
    }
}

