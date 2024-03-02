using System.Drawing;
using MPaintClassLib.Drawers;

namespace MPaintClassLib.Shares;

public class Square(Color borderColor, Color fillColor, System.Drawing.Rectangle box)
    : Shape(borderColor, fillColor, box)
{
    public override Drawer GetDrawer() =>
        SquareDrawer.GetInstance(this);

    public override string ToString() =>
        "type : square" + base.ToString();

}
