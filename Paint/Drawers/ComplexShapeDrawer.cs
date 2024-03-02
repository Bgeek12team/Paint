using MPaintClassLib.Shares;

namespace MPaintClassLib.Drawers;

public class ComplexShapeDrawer : Drawer
{
    private ComplexShapeDrawer
    (ComplexShape complex, IEnumerable<Shape> shapes) : base(complex)
    {
        this.shapes = shapes;
    }

    IEnumerable<Shape> shapes;

    private static ComplexShapeDrawer instance;

    public static ComplexShapeDrawer GetInstance
    (ComplexShape complex, IEnumerable<Shape> shapes) =>
        instance ??= new ComplexShapeDrawer(complex, shapes);


    public override void Draw(Graphics graphics, Point p)
    {
        foreach (var shape in shapes)
        {
            shape.GetDrawer().Draw(graphics, p);
        }
    }
}