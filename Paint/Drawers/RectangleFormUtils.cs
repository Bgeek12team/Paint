using MPaintClassLib.Shares;
using Rectangle = MPaintClassLib.Shares.Rectangle;

namespace MPaintClassLib.Drawers;

public class RectangleFormUtils : FormUtils
{
    private RectangleFormUtils(Rectangle rectangle) : base(rectangle) { }

    private static RectangleFormUtils instance;

    public static RectangleFormUtils GetInstance(Rectangle rectangle) =>
        instance ??= new RectangleFormUtils(rectangle);


    public override void Draw(Graphics graphics, Point p)
    {
        using (var outlinePen = new Pen(Figure.ShapeInfo.BorderColor))
        {
            graphics.DrawRectangle(outlinePen, Figure.ShapeInfo.Box);
        }

        if (Figure.ShapeInfo.FillColor != Color.Transparent)
        {
            using (var fillBrush = new SolidBrush(Figure.ShapeInfo.FillColor))
            {
                graphics.FillRectangle(fillBrush, Figure.ShapeInfo.Box);
            }
        }
    }

    public override bool InShape(Point p)
    {
        throw new NotImplementedException();
    }
}
