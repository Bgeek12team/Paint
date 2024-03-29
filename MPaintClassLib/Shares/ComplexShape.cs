﻿
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
