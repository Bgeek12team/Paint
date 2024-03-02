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
        throw new NotImplementedException();
    }
}
