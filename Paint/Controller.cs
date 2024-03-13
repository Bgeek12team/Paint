using MPaintClassLib.Shares;
using System.Text.Json;

namespace Paint;
internal class Controller
{
    public Controller(Form1 form)
    {
        this.form = form;
        this.graphics = form.GetGraphics();
    }

    private readonly Form1 form;

    private readonly Dictionary<Point, Shape> canvasShapes = [];

    public List<ComplexShape> CustomShapes { get; set; } = [];

    private readonly Graphics graphics;
    public void DrawCircle(Point p, Color border, Color fill, System.Drawing.Rectangle rect)
    {
        var newShape = new Circle(new(border, fill, rect));
        canvasShapes.TryAdd(p, newShape);
        newShape.Draw(graphics, p);
    }

    public void DrawLine(Point p, Color border, Color fill, System.Drawing.Rectangle rect)
    {
        Shape newShape = new Line(new(border, fill, rect));
        canvasShapes.TryAdd(p, newShape);
        newShape.Draw(graphics, p);
    }

    public void DrawEllipse(Point p, Color border, Color fill, System.Drawing.Rectangle rect)
    {
        Ellipse newShape = new Ellipse(new(border, fill, rect));
        canvasShapes.TryAdd(p, newShape);
        newShape.Draw(graphics, p);
    }

    public void DrawSquare(Point p, Color border, Color fill, System.Drawing.Rectangle rect)
    {
        Shape newShape = new Square(new(border, fill, rect));
        canvasShapes.TryAdd(p, newShape);
        newShape.Draw(graphics, p);
    }

    public void DrawRectangle(Point p, Color border, Color fill, System.Drawing.Rectangle rect)
    {
        Shape newShape = new MPaintClassLib.Shares.Rectangle(new(border, fill, rect));
        canvasShapes.TryAdd(p, newShape);
        newShape.Draw(graphics, p);
    }

    public void DrawTriangle(Point p, Color border, Color fill, System.Drawing.Rectangle rect)
    {
        Shape newShape = new Triangle(new(border, fill, rect));
        canvasShapes.TryAdd(p, newShape);
        newShape.Draw(graphics, p);
    }

    public void DrawComplexShape(Point p, IEnumerable<Shape> shapes, ShapeInfo info)
    {
        Shape newShape = new ComplexShape(shapes, info);
        canvasShapes.TryAdd(p, newShape);
        newShape.Draw(graphics, p);
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

    public void DrawCustomShape(int index, Point p)
    {
        canvasShapes.TryAdd(p, CustomShapes[index]);
        CustomShapes[index].Draw(graphics, p);
    }

    public void Redraw()
    {
        graphics.Clear(Color.White);
        foreach (var shape in canvasShapes)
        {
            shape.Value.Draw(graphics, shape.Key);
        }
    }


    public void FillShape(Color fill, Point p)
    {
        var foundShape = FindShape(p, out _);
        foundShape.ShapeInfo.FillColor = fill;
        Redraw();
    }

    public void EraseShape(Point p)
    {
        var foundShape = FindShape(p, out var point);
        if (point != null)
        {
            canvasShapes.Remove((Point)point);
            Redraw();
        }
    }

    public void DrawByBrush(Point p, Size size, Color color)
    {
        var newDot = new Dot(new(color, color, new(p, size)));
        canvasShapes.TryAdd(p, newDot);
        newDot.Draw(graphics, p);
    }

    private Shape FindShape(Point p, out Point? adjPoint)
    {
        foreach (var shape in canvasShapes)
        {
            // кодга будет реализовано: 
            //if (shape.Value.GetUtils().InShape(shape.Key))
            //    return shape.Value;
            
            if ((shape.Value.ShapeInfo.Box.Left < p.X) && (shape.Value.ShapeInfo.Box.Right > p.X)
                && (shape.Value.ShapeInfo.Box.Top > p.Y) && (shape.Value.ShapeInfo.Box.Bottom > p.Y))
            {
                adjPoint = shape.Key;
                return shape.Value;
            }
        }
        adjPoint = null;
        return null;
    }

    static System.Drawing.Rectangle CombineRectangles
    (System.Drawing.Rectangle rect1, System.Drawing.Rectangle rect2)
    {
        int minX = Math.Min(rect1.X, rect2.X);
        int minY = Math.Min(rect1.Y, rect2.Y);
        int maxX = Math.Max(rect1.X + rect1.Width, rect2.X + rect2.Width);
        int maxY = Math.Max(rect1.Y + rect1.Height, rect2.Y + rect2.Height);

        return new(minX, minY, maxX - minX, maxY - minY);
    }

    /// <summary>
    /// Сохранить фигуру в файл
    /// </summary>
    /// <param name="shapes"></param>
    public void SaveShapeToFile(System.Drawing.Rectangle rect, FileInfo file)
    {
        // определить какие фигуры выделены
        // сука переделать по людски 
        System.Drawing.Rectangle? rectangle = new();
        foreach (var shape in canvasShapes.Values)
        {
            if (shape.ShapeInfo.Box.IntersectsWith(rect))
            {
                if (rectangle == null)
                {
                    rectangle = shape.ShapeInfo.Box;
                    continue;
                }
                rectangle = CombineRectangles((System.Drawing.Rectangle)rectangle, shape.ShapeInfo.Box);
            }
        }
        if (rectangle == null)
        {
            return;
        }
        // составить complex shape
        var newShape = new ComplexShape(
            canvasShapes.Values.Where(shape => shape.ShapeInfo.Box.IntersectsWith(rect)),
            new ShapeInfo(Color.Black, Color.Black, (System.Drawing.Rectangle)rectangle)
            );
        // сохранить собсна
        SaveToFile(newShape, file.DirectoryName);
        throw new NotImplementedException();
    }

    private static void SaveToFile(ComplexShape shape, string file)
    {
        var json = JsonSerializer.Serialize(shape);
        using var writer = new StreamWriter(file);
        writer.Write(json);
    }

    private static ComplexShape? ReadFromFile(string file)
    {
        var json = File.ReadAllText(file);
        return JsonSerializer.Deserialize<ComplexShape>(json);
    }

    public bool ReadShapeFromFile(FileInfo fileInfo)
    {
        var shape = ReadFromFile(fileInfo.DirectoryName);
        if (shape == null)
            return false;

        CustomShapes.Add(shape);
        return true;
    }

    public void ClearCanvas()
    {
        canvasShapes.Clear();
        Redraw();
    }
}
