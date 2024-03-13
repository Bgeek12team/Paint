using System.Drawing;

namespace Paint;

public partial class Form1 : Form
{
    private Controller controller;
    private SelectedShapes selectedShapes;
    private Tools tools;
    private bool isMouse = false;
    private enum SelectedShapes
    {
        Null, Circle, Ellipse, Line, Rectangle, Square, Triangle
    }
    public Form1()
    {
        InitializeComponent();
        controller = new Controller(this);
        tools = Tools.Brush;
        selectedShapes = SelectedShapes.Null;

    }

    public Graphics GetGraphics() =>
        this.pictureBox1.CreateGraphics();
    

    private enum Tools
    {
       Null, Brush, Erase, Fill, Selection
    }
    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }
    Color customColor = Color.Black;

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
        if (selectedShapes == SelectedShapes.Circle)
        {
            var rect = new Rectangle(e.Location, new(trackBar1.Value * 5, trackBar1.Value * 5));
            controller.DrawCircle(e.Location, customColor, Color.White, rect);
            return;
        }
        if (selectedShapes == SelectedShapes.Ellipse)
        {
            var rect = new Rectangle(e.Location, new(trackBar1.Value * 10, trackBar1.Value * 5));
            controller.DrawEllipse(e.Location, customColor, Color.White, rect);
            return;
        }
        if (selectedShapes == SelectedShapes.Line)
        {
            var rect = new Rectangle(e.Location, new(trackBar1.Value * 5, trackBar1.Value * 5));
            controller.DrawLine(e.Location, customColor, Color.White, rect);
            return;
        }
        if (selectedShapes == SelectedShapes.Rectangle)
        {
            var rect = new Rectangle(e.Location, new(trackBar1.Value * 10, trackBar1.Value * 5));
            controller.DrawRectangle(e.Location, customColor, Color.White, rect);
            return;
        }
        if (selectedShapes == SelectedShapes.Square)
        {
            var rect = new Rectangle(e.Location, new(trackBar1.Value * 5, trackBar1.Value * 5));
            controller.DrawSquare(e.Location, customColor, Color.White, rect);
            return;
        }
        if (selectedShapes == SelectedShapes.Triangle)
        {
            var rect = new Rectangle(e.Location, new(trackBar1.Value * 5, trackBar1.Value * 5));
            controller.DrawTriangle(e.Location, customColor, Color.White, rect);
            return;
        }
        if (tools == Tools.Brush)
        {
            controller.DrawByBrush(e.Location, new(trackBar1.Value, trackBar1.Value), Color.Black);
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
            return;
        }
    }

    private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
    {
        if (!isMouse) { return; }
        controller.DrawByBrush(e.Location, new(trackBar1.Value, trackBar1.Value), customColor);
    }

    private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
    {
        isMouse = false;
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
            controller.ReadShapeFromFile(new FileInfo(openFileDialog1.FileName));
        }
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
}
