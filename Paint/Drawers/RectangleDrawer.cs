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
        throw new NotImplementedException();
    }
}
