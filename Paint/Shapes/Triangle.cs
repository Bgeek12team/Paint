using System.Drawing;
using MPaintClassLib.Drawers;

namespace MPaintClassLib.Shares;

public class Triangle(ShapeInfo info)
    : Shape(info)
{
    public override FormUtils GetUtils() =>
        TriangleFormUtils.GetInstance(this);

    public override string ToString() =>
        "type : triange" + base.ToString();

}
