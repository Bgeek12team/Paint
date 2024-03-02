using MPaintClassLib.Shares;

namespace MPaintClassLib.Drawers;

public class TriangleDrawer : Drawer
{
    private TriangleDrawer(Triangle triangle) : base(triangle) { }

    private static TriangleDrawer instance;

    public static TriangleDrawer GetInstance(Triangle triangle) =>
        instance ??= new TriangleDrawer(triangle);


    public override void Draw()
    {
        throw new NotImplementedException();
    }
}
