
using System.Text.Json.Serialization;
using System.Windows.Markup;
namespace MPaintClassLib.Shares;

public  class Shape(ShapeInfo info)
{
    protected const int FILL_MARGIN = 2;
    public ShapeInfo ShapeInfo { get; set; } = info;
    public virtual void Draw(Graphics graphics, Point p) { }
    public virtual bool InShape(Point p) { return false; }
    public override int GetHashCode() =>
        HashCode.Combine(ShapeInfo);

    public override string ToString() =>
        ShapeInfo.ToString();
}
