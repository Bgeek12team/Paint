using MPaintClassLib.Shares;
using System.Text.Json;

namespace Paint;
internal class Controller(Form1 form)
{
    private readonly Form1 form = form;

    private readonly Dictionary<Point, Shape> canvasShapes = [];

    public List<ComplexShape> CustomShapes { get; set; } = [];

    private readonly Graphics graphics = form.CreateGraphics();
    public void DrawCircle(Point p, Color border, Color fill, System.Drawing.Rectangle rect)
    {
        Shape newCircle = new Circle(new(border, fill, rect));
        canvasShapes.Add(p, newCircle);
        newCircle.GetDrawer().Draw(graphics, p);
    }

    // аналогичные методы для эллипса, квадрата,
    // прямоугольника, треугольника и стрелки и
    // комплексной фигуры мне лень писать

    // можете единый Redraw создать и каждый раз его вызывать 
    // хуй знает мне похуй главное чтобы работало

    public void FillShape(Color fill, Point p)
    {
        var foundShape = FindShape(p);
        foundShape.ShapeInfo.FillColor = fill;
    }

    public void EraseShape(Point p)
    {
        throw new NotImplementedException();
    }

    public void DrawByBrush(Point p, Size size, Color color)
    {
        throw new NotImplementedException();
    }

    private Shape FindShape(Point p)
    {
        throw new NotImplementedException();
    }



    /// <summary>
    /// Сохранить фигуру в файл
    /// </summary>
    /// <param name="shapes"></param>
    public static void SaveShapeToFile(System.Drawing.Rectangle rect)
    {
        // определить какие фигуры выделены
        // составить по ним complex shape
        // сохранить собсна
        throw new NotImplementedException();
    }

    private static void SaveToFile(Shape shape, string file)
    {
        var json = JsonSerializer.Serialize(shape);
        using var writer = new StreamWriter(file);
        writer.Write(json);
    }

    private static Shape? ReadFromFile(string file)
    {
        var json = File.ReadAllText(file);
        return JsonSerializer.Deserialize<ComplexShape>(json);
    }

    public static void ReadShapeFromFile(FileInfo fileInfo)
    {
        throw new NotImplementedException();
        // CustomShapes.Add(newShape); и она должна появиться среди обычных фигур на форме
    }

    public void ClearCanvas()
    {
        throw new NotImplementedException();
    }
}
