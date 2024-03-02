using System.Drawing;
using MPaintClassLib.Drawers;

namespace MPaintClassLib.Shares;

public class Ellipse(Color borderColor, Color fillColor, System.Drawing.Rectangle box)
    : Shape(borderColor, fillColor, box)
{
    public override Drawer GetDrawer() =>
        EllipseDrawer.GetInstance(this);

    public override string ToString() =>
        "type : ellipse" + base.ToString();

}
