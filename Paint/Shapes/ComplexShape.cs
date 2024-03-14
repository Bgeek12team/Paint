
namespace MPaintClassLib.Shares;
public class ComplexShape
(IEnumerable<Shape> shapes, ShapeInfo info) : 
Shape(info)
{
    public IEnumerable<Shape> Shapes { get; set; } = shapes;

    public override void Draw(Graphics graphics, Point p)
    {
        foreach (var shape in shapes)
        {
            shape.Draw(graphics, p);
        }
    }

    public override bool InShape(Point p)
    {
        foreach(var sh in shapes)
        {
            if (sh.InShape(p))
                return true;
        }
        return false;
    }
}
