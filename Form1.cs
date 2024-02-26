using System.Security.Cryptography.Pkcs;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace Paint
{
    public partial class Form1 : Form
    {
        // Used for manual Drawing
        private bool isDrawing = false;
        private Point lastPoint;
        private Panel drawingPanel;

        // Used to capture the shapes with all details
        int x, y;
        int height, width;
        Pen p1 = new Pen(Color.Black, 5);
        ColorDialog colorDialog = new ColorDialog();
        ColorDialog cd = new ColorDialog();
        Color new_color;
        Pen p = new Pen(Color.Black, 5);

        //click a radio button for whatever shape you want, then click and drag anywhere on screen to draw that shape
        public Form1()
        {
            InitializeComponent();
            this.MouseDown += Form1_MouseDown;
            this.MouseUp += Form1_MouseUp;
            this.MouseMove += Form1_MouseMove;
            btnColor.Click += btnColor_Click;
            ColorDialog cd = new ColorDialog();
            new_color = Color.Black;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)       //saves coordinates for wherever the user clicks (width and height)
        {

            if (freedraw.Checked) // Only start drawing if free draw mode is selected.
            {
                isDrawing = true;
                lastPoint = e.Location; // Capture the starting point.
            }
            else
            {
                x = e.X;
                y = e.Y;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && freedraw.Checked) // Make sure we're in free draw mode and currently drawing.
            {
                using (Graphics g = this.CreateGraphics())
                {
                    p1.Color = new_color;
                    g.DrawLine(p1, lastPoint, e.Location); // Draw line from the last point to the current mouse position.
                    lastPoint = e.Location; // Update the last point.
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)        //saves wherever the user ends the click or releases click button and maps width and height
        {
            if (freedraw.Checked) // Ensure this is part of the freedraw logic
            {
                isDrawing = false;
            }
            else
            {

                width = e.X - x;
                height = e.Y - y;

                Rectangle shapes = new Rectangle(x, y, width, height);       //if statements that check to see which radio button is selected and draws specific shape based on that information
                                                                             // Determine the color of the shape based on the selected color
                Color shapeColor = colorDialog.Color;


                Graphics gfx = CreateGraphics();
                if (circButton.Checked)                                        //circle
                {
                    gfx.DrawEllipse(p1, shapes);
                }
                else if (rectButton.Checked)                                //rectangle/square
                {
                    gfx.DrawRectangle(p1, shapes);
                }
                else if (triButton.Checked)                                 //triangle
                {
                    Point[] triPoints = new Point[]
                    {
                        new Point(x, y + height),
                        new Point(x + width, y + height),
                        new Point(x + width / 2, y)
                    };
                    gfx.DrawPolygon(p1, triPoints);
                }

            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                new_color = colorDialog.Color; // Update the color
                p1.Color = new_color; // Set the new color to the main pen used for drawing
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            {
                // Clear the form by filling it with a solid color, e.g., White
                g.Clear(Color.White);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(100, 100);
            this.Size = new System.Drawing.Size(1000, 500);
        }


        private void rectButton_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void circButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnColor_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}