using System.Drawing;
using MPaintClassLib.Drawers;

namespace MPaintClassLib.Shares;

public class Line(Color borderColor, Color fillColor, System.Drawing.Rectangle box)
    : Shape(borderColor, fillColor, box)
{
    public override Drawer GetDrawer() =>
        LineDrawer.GetInstance(this);

    public override string ToString() =>
        "type : line" + base.ToString();

}
