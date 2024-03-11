using MPaintClassLib.Shares;

namespace MPaintClassLib.Drawers;

public class SquareDrawer : Drawer
{
    private SquareDrawer(Square square) : base(square) { }

    private static SquareDrawer instance;

    public static SquareDrawer GetInstance(Square square) =>
        instance ??= new SquareDrawer(square);


    public override void Draw(Graphics graphics, Point p)
    {
        int sideLength = Math.Min(Figure.ShapeInfo.Box.Width, Figure.ShapeInfo.Box.Height);
        System.Drawing.Rectangle squareRect = new System.Drawing.Rectangle(Figure.ShapeInfo.Box.Location, new Size(sideLength, sideLength));

        using (var outlinePen = new Pen(Figure.ShapeInfo.BorderColor))
        {
            graphics.DrawRectangle(outlinePen, squareRect);
        }

        if (Figure.ShapeInfo.FillColor != Color.Transparent)
        {
            using (var fillBrush = new SolidBrush(Figure.ShapeInfo.FillColor))
            {
                graphics.FillRectangle(fillBrush, squareRect);
            }
        }
    }
}
