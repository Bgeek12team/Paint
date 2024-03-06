using MPaintClassLib.Shares;

namespace MPaintClassLib.Drawers;

public class LineDrawer : Drawer
{
    private LineDrawer(Line line) : base(line) { }

    private static LineDrawer instance;

    public static LineDrawer GetInstance(Line line) =>
        instance ??= new LineDrawer(line);


    public override void Draw(Graphics graphics, Point p)
    {
        
        throw new NotImplementedException();
    }
}
