using MPaintClassLib.Shares;
namespace MPaintClassLib.Drawers;

// ДОЛЖНА БЫТЬ СЕРИАЛИЗУЕМАЯ
public class ComplexShapeDrawer : Drawer
{
    private IEnumerable<Shape> shapes;

    private static ComplexShapeDrawer instance;

    private ComplexShapeDrawer
    (ComplexShape complex, IEnumerable<Shape> shapes) : base(complex)
    {
        this.shapes = shapes;
    }


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