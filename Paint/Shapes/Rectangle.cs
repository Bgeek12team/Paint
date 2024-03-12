using System.Drawing;
using MPaintClassLib.Drawers;

namespace MPaintClassLib.Shares;

public class Rectangle(ShapeInfo info)
    : Shape(info)
{
    public override FormUtils GetUtils() =>
        RectangleFormUtils.GetInstance(this);

    public override string ToString() =>
        "type : rectange" + base.ToString();

}
