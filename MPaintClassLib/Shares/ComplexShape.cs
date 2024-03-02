using MPaintClassLib.Drawers;
using System.Drawing;
using System.Numerics;

namespace MPaintClassLib.Shares;
public class ComplexShape
(IEnumerable<Shape> shapes, Color borderColor, Color fillColor, System.Drawing.Rectangle box) : 
Shape(borderColor, fillColor, box)
{
    public IEnumerable<Shape> Shapes { get; set; } = shapes;

    public override Drawer GetDrawer() =>
        ComplexShapeDrawer.GetInstance(this, Shapes);
}

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


    public override void Draw()
    {
        foreach(var shape in shapes)
        {
            shape.GetDrawer().Draw();
        }
    }
}