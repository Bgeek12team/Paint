using System.Drawing;
using MPaintClassLib.Drawers;

namespace MPaintClassLib.Shares;

public abstract class Shape(Color borderColor, Color fillColor, System.Drawing.Rectangle box)
{

    public Color BorderColor { get; set; } = borderColor;

    public Color FillColor { get; set; } = fillColor;

    public System.Drawing.Rectangle Box { get; set; } = box;
    public abstract Drawer GetDrawer();
    public override int GetHashCode() =>
        HashCode.Combine(BorderColor, FillColor, Box);

    public override string ToString() =>
        $"border color : {BorderColor};" +
        $"fill color : {FillColor};" +
        $"box : {Box.ToString()}";
}
