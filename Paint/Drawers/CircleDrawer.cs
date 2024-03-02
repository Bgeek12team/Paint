using MPaintClassLib.Shares;

namespace MPaintClassLib.Drawers;

public class CircleDrawer : Drawer
{
    private CircleDrawer(Circle circle) : base(circle) { }

    private static CircleDrawer instance;

    public static CircleDrawer GetInstance(Circle circle) =>
        instance ??= new CircleDrawer(circle);


    public override void Draw(Graphics graphics, Point p)
    {
        throw new NotImplementedException();
    }
}
