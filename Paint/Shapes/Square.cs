using System.Drawing;
using MPaintClassLib.Drawers;

namespace MPaintClassLib.Shares;

public class Square(ShapeInfo info)
    : Shape(info)
{
    public override FormUtils GetDrawer() =>
        SquareFormUtils.GetInstance(this);

    public override string ToString() =>
        "type : square" + base.ToString();

}
