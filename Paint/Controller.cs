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
        rect.Offset(-rect.Location.X, -rect.Location.Y);
        var newShape = new Circle(new(border, fill, rect));
        canvasShapes.TryAdd(p, newShape);
        newShape.Draw(graphics, p);
    }

    public void DrawLine(Point p, Color border, Color fill, System.Drawing.Rectangle rect)
    {
        rect.Offset(-rect.Location.X, -rect.Location.Y);
        Shape newShape = new Line(new(border, fill, rect));
        canvasShapes.TryAdd(p, newShape);
        newShape.Draw(graphics, p);
    }

    public void DrawEllipse(Point p, Color border, Color fill, System.Drawing.Rectangle rect)
    {
        rect.Offset(-rect.Location.X, -rect.Location.Y);
        Ellipse newShape = new Ellipse(new(border, fill, rect));
        canvasShapes.TryAdd(p, newShape);
        newShape.Draw(graphics, p);
    }

    public void DrawSquare(Point p, Color border, Color fill, System.Drawing.Rectangle rect)
    {
        rect.Offset(-rect.Location.X, -rect.Location.Y);
        Shape newShape = new Square(new(border, fill, rect));
        canvasShapes.TryAdd(p, newShape);
        newShape.Draw(graphics, p);
    }

    public void DrawRectangle(Point p, Color border, Color fill, System.Drawing.Rectangle rect)
    {
        rect.Offset(-rect.Location.X, -rect.Location.Y);
        Shape newShape = new MPaintClassLib.Shares.Rectangle(new(border, fill, rect));
        canvasShapes.TryAdd(p, newShape);
        newShape.Draw(graphics, p);
    }

    public void DrawTriangle(Point p, Color border, Color fill, System.Drawing.Rectangle rect)
    {
        rect.Offset(-rect.Location.X, -rect.Location.Y);
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
        var foundShape = FindShape(p, out var point);
        if (point != null)
        {
            foundShape.ShapeInfo.FillColor = fill;
            Redraw();
        }
    }

    public void EraseShape(Point p)
    {
        FindShape(p, out var point);
        if (point != null)
        {
            canvasShapes.Remove((Point)point);
            Redraw();
        }
    }

    public void DrawByBrush(Point p, Size size, Color color)
    {
        var rect = new System.Drawing.Rectangle(p, size);
        rect.Offset(-rect.Location.X, -rect.Location.Y);
        var newDot = new Dot(new(color, color, rect));
        canvasShapes.TryAdd(p, newDot);
        newDot.Draw(graphics, p);
        rect.Offset(rect.Location.X, rect.Location.Y);
    }

    private Shape FindShape(Point p, out Point? adjPoint)
    {
        foreach (var shape in canvasShapes)
        {
            // кодга будет реализовано: 
            //if (shape.Value.GetUtils().InShape(shape.Key))
            //    return shape.Value;
            var rect = shape.Value.ShapeInfo.Box;
            rect.Offset(shape.Key);
            if ((rect.Left < p.X) && (rect.Right > p.X)
                && (rect.Top < p.Y) && (rect.Bottom > p.Y))
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
        //  переделать по людски 
        System.Drawing.Rectangle? rectangle = new();
        var shapes = new List<Shape>();
        foreach (var shape in canvasShapes)
        {
            var rectang = shape.Value.ShapeInfo.Box;
            rectang.Offset(shape.Key);
            if (rectang.IntersectsWith(rect))
            {
                if (rectangle == null)
                {
                    rectangle = rectang;
                    continue;
                }
                rectangle = CombineRectangles((System.Drawing.Rectangle)rectangle, rectang);
                shapes.Add(shape.Value);
            }
        }
        if (rectangle == null)
        {
            return;
        }
        // составить complex shape
        var newShape = new ComplexShape(
            shapes,
            new ShapeInfo(Color.Black, Color.Black, (System.Drawing.Rectangle)rectangle)
            );
        // сохранить пол собаки
        SaveToFile(newShape, file.FullName);
    }

    private static void SaveToFile(ComplexShape shape, string file)
    {
        var json = JsonSerializer.Serialize(shape);
        using var writer = new StreamWriter(file);
        writer.Write(json);
    }

    private ComplexShape? ReadFromFile(string file)
    {
        var json = File.ReadAllText(file);

        Shape ts = new Circle(new(Color.Black, Color.Black, new(10, 100, 10, 10)));
        Shape ts2 = new Triangle(new(Color.Black, Color.Black, new(100, 10, 10, 10)));
        var testShape = new ComplexShape(
            [ts,ts2],
            new(Color.Black, Color.Black, new(10, 10, 10, 10)));

        return testShape;
    }

    public bool ReadShapeFromFile(FileInfo fileInfo)
    {
        var shape = ReadFromFile(fileInfo.FullName);
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
