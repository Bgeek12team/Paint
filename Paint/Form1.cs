using System.Drawing;

namespace Paint;

public partial class Form1 : Form
{
    private Controller controller;
    private SelectedShapes selectedShapes;
    private Colors colors;
    private Tools tools;
    private bool isMouse = false;
    public Form1()
    {
        InitializeComponent();
        controller = new Controller(this);
    }
    private enum SelectedShapes
    {
        Null, Circle, Ellipse, Line, Rectangle, Square, Triangle
    }
    private enum Colors
    {
        Black, Red, Orange, Yellow, Pink, Green, White, Blue, Purple, Lime, Custom
    }

    private enum Tools
    {
        Brush, Erase, Fill, Selection
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
        colors = Colors.Custom;
    }

    private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
    {
        isMouse = true;
        if (selectedShapes == SelectedShapes.Circle)
        {
            controller.DrawCircle(e.Location, Color.Black, Color.White, new Rectangle(e.Location, trackBar1.Size * 200));
        }
        if (selectedShapes == SelectedShapes.Ellipse)
        {
            controller.DrawEllipse(new Point(Cursor.Position.X, Cursor.Position.Y), Color.Black, Color.White, new Rectangle(Cursor.Position.X, Cursor.Position.Y, 200, 200));
        }
    }

    private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
    {
        if (!isMouse) { return; }
        controller.DrawByBrush(e.Location, trackBar1.Size, Color.Black);
    }

    private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
    {
        isMouse = false;
    }

    private void circle_button_Click(object sender, EventArgs e)
    {
        selectedShapes = SelectedShapes.Circle;

    }

    private void ellipse_button_Click(object sender, EventArgs e)
    {
        selectedShapes = SelectedShapes.Ellipse;
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
    }

    private void reactangle_button_Click(object sender, EventArgs e)
    {
        selectedShapes = SelectedShapes.Rectangle;
    }

    private void square_button_Click(object sender, EventArgs e)
    {
        selectedShapes = SelectedShapes.Square;
    }

    private void triangle_button_Click(object sender, EventArgs e)
    {
        selectedShapes = SelectedShapes.Triangle;
    }

    private void brush_button_Click(object sender, EventArgs e)
    {
        tools = Tools.Brush;
    }

    private void eraser_button_Click(object sender, EventArgs e)
    {
        tools = Tools.Erase;
    }

    private void fill_button_Click(object sender, EventArgs e)
    {
        tools = Tools.Fill;
    }

    private void selection_button_Click(object sender, EventArgs e)
    {
        tools = Tools.Selection;
    }

    private void Black_button_Click(object sender, EventArgs e)
    {
        colors = Colors.Black;
    }

    private void Red_button_Click(object sender, EventArgs e)
    {
        colors = Colors.Red;
    }

    private void Orange_button_Click(object sender, EventArgs e)
    {

    }

    private void yellow_button_Click(object sender, EventArgs e)
    {

    }

    private void Pink_button_Click(object sender, EventArgs e)
    {

    }

    private void Green_button_Click(object sender, EventArgs e)
    {

    }

    private void white_button_Click(object sender, EventArgs e)
    {

    }

    private void blue_button_Click(object sender, EventArgs e)
    {

    }

    private void purple_button_Click(object sender, EventArgs e)
    {

    }

    private void Lime_button_Click(object sender, EventArgs e)
    {

    }

    private void clear_button_Click(object sender, EventArgs e)
    {
        controller.ClearCanvas();
    }
}
