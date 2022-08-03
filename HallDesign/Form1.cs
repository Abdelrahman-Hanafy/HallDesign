using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HallDesign
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen curser;

        bool curserMoving = false;
        bool painting = true;

        Point st;

        Rectangle current;
        Rectangle selected;
        List<KeyValuePair<Color,Rectangle>> rectangles;

        public Form1()
        {
            InitializeComponent();
            g = canvas.CreateGraphics();
            curser = new Pen(Color.Black,5);
            rectangles = new List<KeyValuePair<Color, Rectangle>>();
        }

        private void color_Click(object sender, EventArgs e)
        {
            PictureBox color = (PictureBox)sender;
            curser.Color = color.BackColor;
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            curserMoving = true;
            st = e.Location;

        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            curserMoving = false;
            
            foreach (KeyValuePair<Color, Rectangle> rect in rectangles)
            {
                if (isOverlap(rect.Value))
                {
                    MessageBox.Show("Can not add this rectangle as it overlap with drawn one!!");
                    updateScreen();
                    return;
                }
            }
            rectangles.Add(new KeyValuePair<Color, Rectangle>(curser.Color,current));

        }

        private bool isOverlap(Rectangle r)
        {

            //bool flg = r.Contains(current.Top,current.Left) || r.Contains(current.Top, current.Right) || r.Contains(current.Bottom, current.Left) || r.Contains(current.Bottom, current.Right);
            //bool flg =  r.Contains(current.Bottom, current.Left) ;

            return !(Math.Min(r.Left, current.Left) > Math.Max(r.Right, current.Right) && // width > 0
                    Math.Min(r.Top, current.Top) > Math.Max(r.Bottom,current.Bottom));  // height > 0
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (curserMoving && painting)
            {

                Rectangle r = new Rectangle();
                r.X = Math.Min(st.X, e.X);
                r.Y = Math.Min(st.Y, e.Y);
                r.Width = Math.Abs(st.X - e.X);
                r.Height = Math.Abs(st.Y - e.Y);

                current = r;
                drawRect(r);

            }
        }

        private void finish_Click(object sender, EventArgs e)
        {
            updateScreen();
            painting = false;
            rows.Enabled = true;
            cols.Enabled = true;
        }

        private void updateScreen()
        {
            g.Clear(Color.White);
            foreach (KeyValuePair<Color, Rectangle> rect in rectangles)
            {
                curser.Color = rect.Key;
                drawRect(rect.Value);

            }

        }

        private void clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            rectangles.Clear();
            painting = true;
        }

        private void drawRect(Rectangle r)
        {
            g.DrawRectangle(curser,r);

        }

        private void cols_Enter(object sender, EventArgs e)
        {
            if(cols.Text == "Num of Columns")
            {
                cols.ForeColor = Color.Black;
                cols.Text = "";
            }

        }

        private void rows_Enter(object sender, EventArgs e)
        {

            if (rows.Text == "Num of Rows")
            {
                rows.ForeColor = Color.Black;
                rows.Text = "";
            }
        }

        private void cols_Leave(object sender, EventArgs e)
        {
            if (cols.Text == "")
            {
                cols.ForeColor = Color.Silver;
                cols.Text = "Num of Columns";
            }

        }
        private void rows_Leave(object sender, EventArgs e)
        {

            if (rows.Text == "")
            {
                rows.ForeColor = Color.Silver;
                rows.Text = "Num of Rows";
            }
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (!painting)
            {
                drawChairs.Enabled = true;
                Point click = e.Location;
                foreach (KeyValuePair<Color, Rectangle> rect in rectangles)
                {
                    if (rect.Value.Contains(click))
                    {
                        selected = rect.Value;
                        finish_Click(sender,e);
                        g.DrawRectangle(Pens.Blue, Rectangle.Round(selected));
                        return;
                    }
                }
            }
        }

        private void drawChairs_Click(object sender, EventArgs e)
        {
            TextRenderer.DrawText(g, $"X:{cols.Text},Y:{rows.Text}", new Font("Arial", 12, FontStyle.Bold), selected, Color.Red);
        }
    }
}
