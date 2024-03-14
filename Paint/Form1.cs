using MPaintClassLib.Shares;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace Paint;

public partial class Form1 : Form
{
    private Point startPoint;
    private Point endPoint;
    private Controller controller;
    private SelectedShapes selectedShapes;
    private Tools tools;
    private bool isMouse = false;
    private bool isDrawing = false;
    private bool selecting = false;
    Graphics g;
    Color customColor = Color.Black;

    private int loadedShapeIndex = -1;
    private enum SelectedShapes
    {
        Null, Circle, Ellipse, Line, Rectangle, Square, Triangle, Loaded
    }
    public Graphics GetGraphics() =>
        g ??= this.pictureBox1.CreateGraphics();


    Point DefineLeftUpperPoint(Point a, Point b) =>
        new Point(Math.Min(a.X, b.X), Math.Min(a.Y, b.Y));

    Point DefineRigthDownPoint(Point a, Point b) =>
        new Point(Math.Max(a.X, b.X), Math.Max(a.Y, b.Y));

    private enum Tools
    {
        Null, Brush, Erase, Fill, Selection
    }
    public Form1()
    {
        InitializeComponent();
        controller = new Controller(this);
        tools = Tools.Brush;
        selectedShapes = SelectedShapes.Null;
        this.Controls.Add(pictureBox1);

        this.DoubleBuffered = true;
        pictureBox1.MouseDown += pictureBox1_MouseDown;
        pictureBox1.MouseMove += pictureBox1_MouseMove;
        pictureBox1.MouseUp += pictureBox1_MouseUp;

    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (colorDialog1.ShowDialog() == DialogResult.OK)
        {
            ((Button)sender).BackColor = colorDialog1.Color;
        }
        button1.Image = null;
        customColor = colorDialog1.Color;
    }

    private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
    {
        isMouse = true;
        isDrawing = true;
        startPoint = e.Location;
        //if (selectedShapes == SelectedShapes.Circle)
        //{
        //    var rect = new Rectangle(e.Location, new(trackBar1.Value * 5, trackBar1.Value * 5));
        //    controller.DrawCircle(e.Location, customColor, Color.White, rect);
        //    return;
        //}
        //if (selectedShapes == SelectedShapes.Ellipse)
        //{
        //    var rect = new Rectangle(e.Location, new(trackBar1.Value * 10, trackBar1.Value * 5));
        //    controller.DrawEllipse(e.Location, customColor, Color.White, rect);
        //    return;
        //}
        //if (selectedShapes == SelectedShapes.Line)
        //{
        //    var rect = new Rectangle(e.Location, new(trackBar1.Value * 5, trackBar1.Value * 5));
        //    controller.DrawLine(e.Location, customColor, Color.White, rect);
        //    return;
        //}
        //if (selectedShapes == SelectedShapes.Rectangle)
        //{
        //    var rect = new Rectangle(e.Location, new(trackBar1.Value * 10, trackBar1.Value * 5));
        //    controller.DrawRectangle(e.Location, customColor, Color.White, rect);
        //    return;
        //}
        //if (selectedShapes == SelectedShapes.Square)
        //{
        //    var rect = new Rectangle(e.Location, new(trackBar1.Value * 5, trackBar1.Value * 5));
        //    controller.DrawSquare(e.Location, customColor, Color.White, rect);
        //    return;
        //}
        //if (selectedShapes == SelectedShapes.Triangle)
        //{
        //    var rect = new Rectangle(e.Location, new(trackBar1.Value * 5, trackBar1.Value * 5));
        //    controller.DrawTriangle(e.Location, customColor, Color.White, rect);
        //    return;
        //}
        if (tools == Tools.Brush)
        {
            controller.DrawByBrush(e.Location, new(trackBar1.Value, trackBar1.Value), customColor);
            return;
        }
        if (tools == Tools.Erase)
        {
            controller.EraseShape(e.Location);
            return;
        }
        if (tools == Tools.Fill)
        {
            controller.FillShape(customColor, e.Location);
            return;
        }
        if (tools == Tools.Selection)
        {
            isDrawing = false;
            startPoint = e.Location;
        }
    }

    private System.Drawing.Rectangle GetRectangle(Point startPoint, Point endPoint)
    {
        var lu = DefineLeftUpperPoint(startPoint, endPoint);
        var rd = DefineRigthDownPoint(startPoint, endPoint);
        var size = new Size(rd.X - lu.X, rd.Y - lu.Y);
        return new(lu, size);

    }
    private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
    {
        if (!isMouse) { return; }
        if (tools == Tools.Brush)
        {
            controller.DrawByBrush(e.Location, new(trackBar1.Value, trackBar1.Value), customColor);
            return;
        }
        if (selectedShapes == SelectedShapes.Circle)
        {
            isDrawing = true;
            endPoint = e.Location;
            GetGraphics().DrawEllipse(new(customColor, 5), startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);
            pictureBox1.Invalidate();
        }
    }

    private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
    {
        isMouse = false;
        endPoint = e.Location;
        if (isDrawing)
        {
            if (selectedShapes == SelectedShapes.Ellipse)
                controller.DrawEllipse(DefineLeftUpperPoint(startPoint, endPoint), Color.Transparent, customColor, GetRectangle(startPoint, endPoint));
            
            if (selectedShapes == SelectedShapes.Loaded)
                controller.DrawCustomShape(loadedShapeIndex, startPoint);

            controller.Redraw();
            isDrawing = false;
        }
        if (selecting)
        {
            endPoint = e.Location;
            selecting = false;
        }

    }

    private void circle_button_Click(object sender, EventArgs e)
    {
        selectedShapes = SelectedShapes.Circle;
        tools = Tools.Null;
    }

    private void ellipse_button_Click(object sender, EventArgs e)
    {
        selectedShapes = SelectedShapes.Ellipse;
        tools = Tools.Null;
    }

    private void fileopen_button_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            if(controller.ReadShapeFromFile(new FileInfo(openFileDialog1.FileName)))
                FillGroupBox(groupBox7, controller.CustomShapes, openFileDialog1.SafeFileName);
        }
    }

    
     void FillGroupBox(GroupBox gb, List<ComplexShape> shapes, string name)
     {
        var button = new Button
        {
            Size = new(100, 50),
            Left = shapes.Count * 100 + 10,
            Top = 33,
            Text = name
        };
        button.Click += (s, e) =>
        {
            selectedShapes = SelectedShapes.Loaded;
            tools = Tools.Null;
            loadedShapeIndex = gb.Controls.IndexOf(button);
        };
        gb.Controls.Add(button);
        button.Show();
        gb.Refresh();
     }

    private void line_button_Click(object sender, EventArgs e)
    {
        selectedShapes = SelectedShapes.Line;
        tools = Tools.Null;
    }

    private void reactangle_button_Click(object sender, EventArgs e)
    {
        selectedShapes = SelectedShapes.Rectangle;
        tools = Tools.Null;
    }

    private void square_button_Click(object sender, EventArgs e)
    {
        selectedShapes = SelectedShapes.Square;
        tools = Tools.Null;
    }

    private void triangle_button_Click(object sender, EventArgs e)
    {
        selectedShapes = SelectedShapes.Triangle;
        tools = Tools.Null;
    }

    private void brush_button_Click(object sender, EventArgs e)
    {
        tools = Tools.Brush;
        selectedShapes = SelectedShapes.Null;
    }

    private void eraser_button_Click(object sender, EventArgs e)
    {
        tools = Tools.Erase;
        selectedShapes = SelectedShapes.Null;
    }

    private void fill_button_Click(object sender, EventArgs e)
    {
        tools = Tools.Fill;
        selectedShapes = SelectedShapes.Null;
    }

    private void selection_button_Click(object sender, EventArgs e)
    {
        tools = Tools.Selection;
        selecting = true;
        selectedShapes = SelectedShapes.Null;
    }

    private void Black_button_Click(object sender, EventArgs e)
    {
        customColor = Color.Black;
    }

    private void Red_button_Click(object sender, EventArgs e)
    {
        customColor = Color.Red;
    }

    private void Orange_button_Click(object sender, EventArgs e)
    {
        customColor = Color.Orange;
    }

    private void yellow_button_Click(object sender, EventArgs e)
    {
        customColor = Color.Yellow;
    }

    private void Pink_button_Click(object sender, EventArgs e)
    {
        customColor = Color.Pink;
    }

    private void Green_button_Click(object sender, EventArgs e)
    {
        customColor = Color.Green;
    }

    private void white_button_Click(object sender, EventArgs e)
    {
        customColor = Color.White;
    }

    private void blue_button_Click(object sender, EventArgs e)
    {
        customColor = Color.Blue;
    }

    private void purple_button_Click(object sender, EventArgs e)
    {
        customColor = Color.Purple;
    }

    private void Lime_button_Click(object sender, EventArgs e)
    {
        customColor = Color.Lime;
    }

    private void clear_button_Click(object sender, EventArgs e)
    {
        controller.ClearCanvas();
    }

    private void pictureBox1_Paint(object sender, PaintEventArgs e)
    {
        if (selectedShapes == SelectedShapes.Circle)
        {
            e.Graphics.DrawRectangle(Pens.Black, Math.Min(startPoint.X, endPoint.X), Math.Min(startPoint.Y, endPoint.Y), Math.Abs(startPoint.X - endPoint.X), Math.Abs(startPoint.Y - endPoint.Y));
        }
    }

    private void Form1_MouseDown(object sender, MouseEventArgs e)
    {

    }

    private void Form1_MouseMove(object sender, MouseEventArgs e)
    {

    }

    private void Form1_MouseUp(object sender, MouseEventArgs e)
    {

    }


    private void filesave_button_Click(object sender, EventArgs e)
    {
        if (!selecting)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JSON|*.json";
            saveFileDialog1.Title = "Save an shape";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
                controller.SaveShapeToFile(GetRectangle(startPoint, endPoint), new FileInfo(saveFileDialog1.FileName));

            selecting = false;
        }
    }
}
