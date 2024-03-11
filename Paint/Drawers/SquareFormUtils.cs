using MPaintClassLib.Shares;

namespace MPaintClassLib.Drawers;

public class SquareFormUtils : FormUtils
{
    private SquareFormUtils(Square square) : base(square) { }

    private static SquareFormUtils instance;

    public static SquareFormUtils GetInstance(Square square) =>
        instance ??= new SquareFormUtils(square);


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

    public override bool InShape(Point p)
    {
        throw new NotImplementedException();
    }
}
