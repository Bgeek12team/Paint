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
        Shape newShape = new Circle(new(border, fill, rect));
        canvasShapes.Add(p, newShape);
        newShape.GetDrawer().Draw(graphics, p);
    }

    public void DrawLine(Point p, Color border, Color fill, System.Drawing.Rectangle rect)
    {
        Shape newShape = new Line(new(border, fill, rect));
        canvasShapes.Add(p, newShape);
        newShape.GetDrawer().Draw(graphics, p);
    }

    public void DrawEllipse(Point p, Color border, Color fill, System.Drawing.Rectangle rect)
    {
        Shape newShape = new Ellipse(new(border, fill, rect));
        canvasShapes.Add(p, newShape);
        newShape.GetDrawer().Draw(graphics, p);
    }

    public void DrawSquare(Point p, Color border, Color fill, System.Drawing.Rectangle rect)
    {
        Shape newShape = new Square(new(border, fill, rect));
        canvasShapes.Add(p, newShape);
        newShape.GetDrawer().Draw(graphics, p);
    }

    public void DrawRectangle(Point p, Color border, Color fill, System.Drawing.Rectangle rect)
    {
        Shape newShape = new MPaintClassLib.Shares.Rectangle(new(border, fill, rect));
        canvasShapes.Add(p, newShape);
        newShape.GetDrawer().Draw(graphics, p);
    }

    public void DrawTriangle(Point p, Color border, Color fill, System.Drawing.Rectangle rect)
    {
        Shape newShape = new Triangle(new(border, fill, rect));
        canvasShapes.Add(p, newShape);
        newShape.GetDrawer().Draw(graphics, p);
    }

    public void DrawComplexShape(Point p, IEnumerable<Shape> shapes, ShapeInfo info)
    {
        Shape newShape = new ComplexShape(shapes, info);
        canvasShapes.Add(p, newShape);
        newShape.GetDrawer().Draw(graphics, p);
    }

    /*
    public void Draw<T>(Point p, ShapeInfo info) where T : Shape, new()
    {
        Shape newShape = new T
        {
            ShapeInfo = info
        };
        canvasShapes.Add(p, newShape);
        newShape.GetDrawer().Draw(graphics, p);
    } */

    public void Redraw()
    {
        graphics.Clear(Color.White);
        foreach (var shape in canvasShapes)
        {
            shape.Value.GetDrawer().Draw(graphics, shape.Key);
        }
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
        Redraw();
    }

    public void EraseShape(Point p)
    {
        var foundShape = FindShape(p);
        canvasShapes.Remove(new Point(foundShape.ShapeInfo.Box.Left, foundShape.ShapeInfo.Box.Top));
        Redraw();
    }

    public void DrawByBrush(Point p, Size size, Color color)
    {
        Circle newDot = new Circle(new(color, color, new(p, size)));
        canvasShapes.Add(p, newDot);
        newDot.GetDrawer().Draw(graphics, p);
    }

    private Shape FindShape(Point p)
    {
        foreach (var shape in canvasShapes)
        {
            if ((shape.Value.ShapeInfo.Box.Left < p.X) && (shape.Value.ShapeInfo.Box.Right > p.X)
                && (shape.Value.ShapeInfo.Box.Top > p.Y) && (shape.Value.ShapeInfo.Box.Bottom > p.Y))
            {
                return shape.Value;
            }
        }
        return null;
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
        canvasShapes.Clear();
        Redraw();
    }
}
