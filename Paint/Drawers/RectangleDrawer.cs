using MPaintClassLib.Shares;
using Rectangle = MPaintClassLib.Shares.Rectangle;

namespace MPaintClassLib.Drawers;

public class RectangleDrawer : Drawer
{
    private RectangleDrawer(Rectangle rectangle) : base(rectangle) { }

    private static RectangleDrawer instance;

    public static RectangleDrawer GetInstance(Rectangle rectangle) =>
        instance ??= new RectangleDrawer(rectangle);


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
}
