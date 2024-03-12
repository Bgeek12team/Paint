using System.Drawing;
using MPaintClassLib.Drawers;

namespace MPaintClassLib.Shares;

public class Ellipse(ShapeInfo info)
    : Shape(info)
{
    public override FormUtils GetUtils() =>
        EllipseFormUtils.GetInstance(this);

    public override string ToString() =>
        "type : ellipse" + base.ToString();

}
