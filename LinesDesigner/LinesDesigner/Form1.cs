using System;
using System.Drawing;
using System.Windows.Forms;

namespace LinesDesigner
{
    public partial class Form1 : Form
    {
        Pen myPen = new Pen(Color.White);
        Graphics graph = null;

        static int start_x, start_y;
        static int end_x, end_y;

        static int my_angle = 0;
        static int my_length = 0;
        static int my_increment = 0;

        public Form1()
        {
            InitializeComponent();

            ///make the center of canvas as the start of drawing

            start_x = canvas.Width / 2;
            start_y = canvas.Height / 2;
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            
            ///using the Pen set its width & do the graphics object
            ///reading #Lines textbox

            my_length = Int32.Parse(textbox_length.Text);
            myPen.Width = 1;
            graph = canvas.CreateGraphics();
            for (int i = 0; i < Int32.Parse(textbox_num_lines.Text); i++)
            drawLine();
        }

        private void drawLine()
        {
            ///calculating of a degree angle

            my_angle = my_angle + Int32.Parse(textbox_angle.Text);
            my_length = my_length + Int32.Parse(textbox_increment.Text);

            end_x = (int)(start_x + Math.Cos(my_angle * Math.PI / 180) * my_length);
            end_y = (int)(start_y + Math.Sin(my_angle * Math.PI / 180) * my_length);

            ///make the drawing from points calculating position 
            ///of the first & the last points
            ///then go to the Paint method

            Point[] points =
            {
                new Point (start_x, start_y),
                new Point (end_x, end_y)
            };

            start_x = end_x;
            start_y = end_y;

            graph.DrawLines(myPen, points);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            my_angle = Int32.Parse(textbox_angle.Text);
            my_length = Int32.Parse(textbox_length.Text);
            my_increment = Int32.Parse(textbox_increment.Text);

            ///continue using the center of canvas as the start of drawing 
            ///as the "Go" button has been pressed

            start_x = canvas.Width / 2;
            start_y = canvas.Height / 2;

            canvas.Refresh();
        }

        private void textbox_KeyDown(object sender, KeyEventArgs e)
        {
            ///make ENTER button attached to the "Go" button

            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ///allows just number keys

            if (e.KeyChar != 8)
            {
                e.Handled = !char.IsNumber(e.KeyChar);
            }
        }
    }
}
