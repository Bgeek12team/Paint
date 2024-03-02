using MPaintClassLib.Drawers;
namespace MPaintClassLib.Shares;
public class ComplexShape
(IEnumerable<Shape> shapes, ShapeInfo info) : 
Shape(info)
{
    public IEnumerable<Shape> Shapes { get; set; } = shapes;

    public override Drawer GetDrawer() =>
        ComplexShapeDrawer.GetInstance(this, Shapes);
}
