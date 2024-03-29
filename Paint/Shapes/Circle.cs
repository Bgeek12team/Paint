﻿using System.Drawing;
using MPaintClassLib.Drawers;

namespace MPaintClassLib.Shares;

public class Circle(ShapeInfo info)
    : Ellipse(info)
{
    public override FormUtils GetUtils() =>
        CircleFormUtils.GetInstance(this);

    public override string ToString() =>
        "type : circle" + base.ToString();

}
