namespace Paint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            groupBox6 = new GroupBox();
            clear_button = new Button();
            fileopen_button = new Button();
            filesave_button = new Button();
            groupBox5 = new GroupBox();
            trackBar1 = new TrackBar();
            groupBox4 = new GroupBox();
            square_button = new Button();
            reactangle_button = new Button();
            triangle_button = new Button();
            line_button = new Button();
            ellipse_button = new Button();
            circle_button = new Button();
            groupBox3 = new GroupBox();
            fill_button = new Button();
            selection_button = new Button();
            eraser_button = new Button();
            brush_button = new Button();
            groupBox2 = new GroupBox();
            button1 = new Button();
            Lime_button = new Button();
            Pink_button = new Button();
            purple_button = new Button();
            blue_button = new Button();
            white_button = new Button();
            Green_button = new Button();
            yellow_button = new Button();
            Orange_button = new Button();
            Black_button = new Button();
            Red_button = new Button();
            colorDialog1 = new ColorDialog();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1218, 706);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Bookman Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(916, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(302, 706);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(clear_button);
            groupBox6.Controls.Add(fileopen_button);
            groupBox6.Controls.Add(filesave_button);
            groupBox6.Font = new Font("Bookman Old Style", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox6.ForeColor = SystemColors.ActiveCaptionText;
            groupBox6.Location = new Point(13, 530);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(222, 170);
            groupBox6.TabIndex = 9;
            groupBox6.TabStop = false;
            groupBox6.Text = "Возможности";
            // 
            // clear_button
            // 
            clear_button.Location = new Point(23, 124);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(157, 39);
            clear_button.TabIndex = 9;
            clear_button.Text = "Очистить";
            clear_button.UseVisualStyleBackColor = true;
            clear_button.Click += clear_button_Click;
            // 
            // fileopen_button
            // 
            fileopen_button.Location = new Point(23, 31);
            fileopen_button.Name = "fileopen_button";
            fileopen_button.Size = new Size(157, 42);
            fileopen_button.TabIndex = 7;
            fileopen_button.Text = "Загрузить";
            fileopen_button.UseVisualStyleBackColor = true;
            fileopen_button.Click += fileopen_button_Click;
            // 
            // filesave_button
            // 
            filesave_button.Location = new Point(23, 79);
            filesave_button.Name = "filesave_button";
            filesave_button.Size = new Size(157, 39);
            filesave_button.TabIndex = 8;
            filesave_button.Text = "Сохранить";
            filesave_button.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(trackBar1);
            groupBox5.Font = new Font("Bookman Old Style", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox5.ForeColor = SystemColors.ActiveCaptionText;
            groupBox5.Location = new Point(12, 436);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(223, 93);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "Размер";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(0, 31);
            trackBar1.Maximum = 100;
            trackBar1.Minimum = 2;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(221, 56);
            trackBar1.TabIndex = 5;
            trackBar1.Value = 10;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(square_button);
            groupBox4.Controls.Add(reactangle_button);
            groupBox4.Controls.Add(triangle_button);
            groupBox4.Controls.Add(line_button);
            groupBox4.Controls.Add(ellipse_button);
            groupBox4.Controls.Add(circle_button);
            groupBox4.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox4.ForeColor = SystemColors.ActiveCaptionText;
            groupBox4.Location = new Point(12, 300);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(223, 130);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Фигуры";
            // 
            // square_button
            // 
            square_button.Image = (Image)resources.GetObject("square_button.Image");
            square_button.Location = new Point(84, 72);
            square_button.Name = "square_button";
            square_button.Size = new Size(42, 33);
            square_button.TabIndex = 6;
            square_button.UseVisualStyleBackColor = true;
            square_button.Click += square_button_Click;
            // 
            // reactangle_button
            // 
            reactangle_button.Image = (Image)resources.GetObject("reactangle_button.Image");
            reactangle_button.Location = new Point(6, 72);
            reactangle_button.Name = "reactangle_button";
            reactangle_button.Size = new Size(42, 33);
            reactangle_button.TabIndex = 5;
            reactangle_button.UseVisualStyleBackColor = true;
            reactangle_button.Click += reactangle_button_Click;
            // 
            // triangle_button
            // 
            triangle_button.Image = (Image)resources.GetObject("triangle_button.Image");
            triangle_button.Location = new Point(152, 72);
            triangle_button.Name = "triangle_button";
            triangle_button.Size = new Size(42, 33);
            triangle_button.TabIndex = 4;
            triangle_button.UseVisualStyleBackColor = true;
            triangle_button.Click += triangle_button_Click;
            // 
            // line_button
            // 
            line_button.Image = (Image)resources.GetObject("line_button.Image");
            line_button.Location = new Point(152, 33);
            line_button.Name = "line_button";
            line_button.Size = new Size(42, 33);
            line_button.TabIndex = 3;
            line_button.UseVisualStyleBackColor = true;
            line_button.Click += line_button_Click;
            // 
            // ellipse_button
            // 
            ellipse_button.Image = (Image)resources.GetObject("ellipse_button.Image");
            ellipse_button.Location = new Point(84, 33);
            ellipse_button.Name = "ellipse_button";
            ellipse_button.Size = new Size(42, 33);
            ellipse_button.TabIndex = 2;
            ellipse_button.UseVisualStyleBackColor = true;
            ellipse_button.Click += ellipse_button_Click;
            // 
            // circle_button
            // 
            circle_button.Image = (Image)resources.GetObject("circle_button.Image");
            circle_button.Location = new Point(6, 33);
            circle_button.Name = "circle_button";
            circle_button.Size = new Size(42, 33);
            circle_button.TabIndex = 1;
            circle_button.UseVisualStyleBackColor = true;
            circle_button.Click += circle_button_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(fill_button);
            groupBox3.Controls.Add(selection_button);
            groupBox3.Controls.Add(eraser_button);
            groupBox3.Controls.Add(brush_button);
            groupBox3.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox3.ForeColor = SystemColors.ActiveCaptionText;
            groupBox3.Location = new Point(13, 208);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(222, 86);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Инструменты";
            // 
            // fill_button
            // 
            fill_button.Image = (Image)resources.GetObject("fill_button.Image");
            fill_button.Location = new Point(101, 33);
            fill_button.Name = "fill_button";
            fill_button.Size = new Size(41, 41);
            fill_button.TabIndex = 4;
            fill_button.UseVisualStyleBackColor = true;
            fill_button.Click += fill_button_Click;
            // 
            // selection_button
            // 
            selection_button.Image = (Image)resources.GetObject("selection_button.Image");
            selection_button.Location = new Point(148, 33);
            selection_button.Name = "selection_button";
            selection_button.Size = new Size(41, 41);
            selection_button.TabIndex = 3;
            selection_button.UseVisualStyleBackColor = true;
            selection_button.Click += selection_button_Click;
            // 
            // eraser_button
            // 
            eraser_button.Image = (Image)resources.GetObject("eraser_button.Image");
            eraser_button.Location = new Point(54, 33);
            eraser_button.Name = "eraser_button";
            eraser_button.Size = new Size(41, 41);
            eraser_button.TabIndex = 2;
            eraser_button.UseVisualStyleBackColor = true;
            eraser_button.Click += eraser_button_Click;
            // 
            // brush_button
            // 
            brush_button.Image = (Image)resources.GetObject("brush_button.Image");
            brush_button.Location = new Point(6, 33);
            brush_button.Name = "brush_button";
            brush_button.Size = new Size(41, 41);
            brush_button.TabIndex = 1;
            brush_button.UseVisualStyleBackColor = true;
            brush_button.Click += brush_button_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(Lime_button);
            groupBox2.Controls.Add(Pink_button);
            groupBox2.Controls.Add(purple_button);
            groupBox2.Controls.Add(blue_button);
            groupBox2.Controls.Add(white_button);
            groupBox2.Controls.Add(Green_button);
            groupBox2.Controls.Add(yellow_button);
            groupBox2.Controls.Add(Orange_button);
            groupBox2.Controls.Add(Black_button);
            groupBox2.Controls.Add(Red_button);
            groupBox2.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(13, 49);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(222, 153);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Цвета";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(82, 105);
            button1.Name = "button1";
            button1.Size = new Size(32, 30);
            button1.TabIndex = 12;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Lime_button
            // 
            Lime_button.BackColor = Color.Lime;
            Lime_button.Location = new Point(158, 69);
            Lime_button.Name = "Lime_button";
            Lime_button.Size = new Size(32, 30);
            Lime_button.TabIndex = 9;
            Lime_button.UseVisualStyleBackColor = false;
            Lime_button.Click += Lime_button_Click;
            // 
            // Pink_button
            // 
            Pink_button.BackColor = Color.Pink;
            Pink_button.Location = new Point(158, 33);
            Pink_button.Name = "Pink_button";
            Pink_button.Size = new Size(32, 30);
            Pink_button.TabIndex = 8;
            Pink_button.UseVisualStyleBackColor = false;
            Pink_button.Click += Pink_button_Click;
            // 
            // purple_button
            // 
            purple_button.BackColor = Color.Purple;
            purple_button.Location = new Point(120, 69);
            purple_button.Name = "purple_button";
            purple_button.Size = new Size(32, 30);
            purple_button.TabIndex = 7;
            purple_button.UseVisualStyleBackColor = false;
            purple_button.Click += purple_button_Click;
            // 
            // blue_button
            // 
            blue_button.BackColor = Color.Blue;
            blue_button.Location = new Point(82, 69);
            blue_button.Name = "blue_button";
            blue_button.Size = new Size(32, 30);
            blue_button.TabIndex = 6;
            blue_button.UseVisualStyleBackColor = false;
            blue_button.Click += blue_button_Click;
            // 
            // white_button
            // 
            white_button.BackColor = Color.White;
            white_button.Location = new Point(44, 69);
            white_button.Name = "white_button";
            white_button.Size = new Size(32, 30);
            white_button.TabIndex = 5;
            white_button.UseVisualStyleBackColor = false;
            white_button.Click += white_button_Click;
            // 
            // Green_button
            // 
            Green_button.BackColor = Color.Green;
            Green_button.Location = new Point(6, 69);
            Green_button.Name = "Green_button";
            Green_button.Size = new Size(32, 30);
            Green_button.TabIndex = 4;
            Green_button.UseVisualStyleBackColor = false;
            Green_button.Click += Green_button_Click;
            // 
            // yellow_button
            // 
            yellow_button.BackColor = Color.Yellow;
            yellow_button.Location = new Point(120, 33);
            yellow_button.Name = "yellow_button";
            yellow_button.Size = new Size(32, 30);
            yellow_button.TabIndex = 3;
            yellow_button.UseVisualStyleBackColor = false;
            yellow_button.Click += yellow_button_Click;
            // 
            // Orange_button
            // 
            Orange_button.BackColor = Color.Orange;
            Orange_button.Location = new Point(82, 33);
            Orange_button.Name = "Orange_button";
            Orange_button.Size = new Size(32, 30);
            Orange_button.TabIndex = 2;
            Orange_button.UseVisualStyleBackColor = false;
            Orange_button.Click += Orange_button_Click;
            // 
            // Black_button
            // 
            Black_button.BackColor = Color.Black;
            Black_button.Location = new Point(6, 33);
            Black_button.Name = "Black_button";
            Black_button.Size = new Size(32, 30);
            Black_button.TabIndex = 1;
            Black_button.UseVisualStyleBackColor = false;
            Black_button.Click += Black_button_Click;
            // 
            // Red_button
            // 
            Red_button.BackColor = Color.Red;
            Red_button.Location = new Point(44, 33);
            Red_button.Name = "Red_button";
            Red_button.Size = new Size(32, 30);
            Red_button.TabIndex = 0;
            Red_button.UseVisualStyleBackColor = false;
            Red_button.Click += Red_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1218, 706);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "PAINt";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button purple_button;
        private Button blue_button;
        private Button white_button;
        private Button Green_button;
        private Button yellow_button;
        private Button Orange_button;
        private Button Black_button;
        private Button Red_button;
        private Button Lime_button;
        private Button Pink_button;
        private GroupBox groupBox3;
        private Button brush_button;
        private GroupBox groupBox4;
        private Button triangle_button;
        private Button line_button;
        private Button ellipse_button;
        private Button circle_button;
        private Button fill_button;
        private Button selection_button;
        private Button eraser_button;
        private Button reactangle_button;
        private Button square_button;
        private TrackBar trackBar1;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private Button fileopen_button;
        private Button filesave_button;
        private Button clear_button;
        private Button button1;
        private ColorDialog colorDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
