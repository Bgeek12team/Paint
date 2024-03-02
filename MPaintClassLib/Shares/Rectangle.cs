using System.Drawing;
using MPaintClassLib.Drawers;

namespace MPaintClassLib.Shares;

public class Rectangle(Color borderColor, Color fillColor, System.Drawing.Rectangle box)
    : Shape(borderColor, fillColor, box)
{
    public override Drawer GetDrawer() =>
        RectangleDrawer.GetInstance(this);

    public override string ToString() =>
        "type : rectange" + base.ToString();

}
