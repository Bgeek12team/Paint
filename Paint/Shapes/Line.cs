﻿using System.Drawing;
using MPaintClassLib.Drawers;

namespace MPaintClassLib.Shares;

public class Line(ShapeInfo info)
    : Shape(info)
{
    public override FormUtils GetUtils() =>
        LineFormUtils.GetInstance(this);

    public override string ToString() =>
        "type : line" + base.ToString();

}
