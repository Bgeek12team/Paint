using MPaintClassLib.Shares;

namespace MPaintClassLib.Drawers;

public class EllipseDrawer : Drawer
{
    private EllipseDrawer(Ellipse ellipse) : base(ellipse) { }

    private static EllipseDrawer instance;

    public static EllipseDrawer GetInstance(Ellipse ellipse) =>
        instance ??= new EllipseDrawer(ellipse);


    public override void Draw()
    {

    }
}
