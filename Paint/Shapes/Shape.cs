using MPaintClassLib.Drawers;
using System.Text.Json.Serialization;
using System.Windows.Markup;
namespace MPaintClassLib.Shares;

public abstract class Shape(ShapeInfo info)
{
    public ShapeInfo ShapeInfo { get; set; } = info;
    public abstract FormUtils GetUtils();
    public override int GetHashCode() =>
        HashCode.Combine(ShapeInfo);

    public override string ToString() =>
        ShapeInfo.ToString();
}
