using System.Drawing;
using MPaintClassLib.Drawers;

namespace MPaintClassLib.Shares;

public class Triangle(Color borderColor, Color fillColor, System.Drawing.Rectangle box)
    : Shape(borderColor, fillColor, box)
{
    public override Drawer GetDrawer() =>
        TriangleDrawer.GetInstance(this);

    public override string ToString() =>
        "type : triange" + base.ToString();

}
