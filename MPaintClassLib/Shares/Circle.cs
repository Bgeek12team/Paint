using System.Drawing;
using MPaintClassLib.Drawers;

namespace MPaintClassLib.Shares;

public class Circle(Color borderColor, Color fillColor, System.Drawing.Rectangle box)
    : Ellipse(borderColor, fillColor, box)
{
    public override Drawer GetDrawer() =>
        CircleDrawer.GetInstance(this);

    public override string ToString() =>
        "type : circle" + base.ToString();

}
