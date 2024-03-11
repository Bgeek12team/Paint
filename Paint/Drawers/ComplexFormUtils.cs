using MPaintClassLib.Shares;
namespace MPaintClassLib.Drawers;

// ДОЛЖНА БЫТЬ СЕРИАЛИЗУЕМАЯ
public class ComplexFormUtils : FormUtils
{
    private IEnumerable<Shape> shapes;

    private static ComplexFormUtils instance;

    private ComplexFormUtils
    (ComplexShape complex, IEnumerable<Shape> shapes) : base(complex)
    {
        this.shapes = shapes;
    }


    public static ComplexFormUtils GetInstance
    (ComplexShape complex, IEnumerable<Shape> shapes) =>
        instance ??= new ComplexFormUtils(complex, shapes);


    public override void Draw(Graphics graphics, Point p)
    {
        foreach (var shape in shapes)
        {
            shape.GetDrawer().Draw(graphics, p);
        }
    }

    public override bool InShape(Point p)
    {
        throw new NotImplementedException();
    }
}