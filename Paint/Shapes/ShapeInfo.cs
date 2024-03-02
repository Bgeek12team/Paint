namespace MPaintClassLib.Shares;

public class ShapeInfo
    (Color borderColor, Color fillColor, System.Drawing.Rectangle box)
{
    public Color BorderColor { get; set; } = borderColor;

    public Color FillColor { get; set; } = fillColor;

    public System.Drawing.Rectangle Box { get; set; } = box;

    public override int GetHashCode() =>
        HashCode.Combine(BorderColor, FillColor, Box);

    public override string ToString() =>
        $"border color: {BorderColor};" +
        $"filling color: {FillColor};" +
        $"rect: {Box};";
}
