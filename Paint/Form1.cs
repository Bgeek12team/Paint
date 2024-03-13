using System.Drawing;

namespace Paint;

public partial class Form1 : Form
{
    private Controller controller;
    private selectedShapes sS;
    private bool isMouse = false;
    public Form1()
    {
        InitializeComponent();
        controller = new Controller(this);
    }

    private enum selectedShapes
    {
        Null, Circle, Ellipse, Line, Rectangle, Square, Triangle
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void toolStripComboBox1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (colorDialog1.ShowDialog() == DialogResult.OK)
        {
            ((Button)sender).BackColor = colorDialog1.Color;
        }
    }

    private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
    {

    }

    private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
    {

    }

    private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
    {

    }
}
