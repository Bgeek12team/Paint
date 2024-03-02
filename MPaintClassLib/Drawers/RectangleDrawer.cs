using MPaintClassLib.Shares;

namespace MPaintClassLib.Drawers;

public class RectangleDrawer : Drawer
{
    private RectangleDrawer(Rectangle rectangle) : base(rectangle) { }

    private static RectangleDrawer instance;

    public static RectangleDrawer GetInstance(Rectangle rectangle) =>
        instance ??= new RectangleDrawer(rectangle);


    public override void Draw()
    {
        throw new NotImplementedException();
    }
}
