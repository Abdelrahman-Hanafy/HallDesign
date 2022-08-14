using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace HallDesign
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen curser;
        DataBase db;

        bool curserMoving = false;
        bool painting = true;

        Point st;
      
        Rectangle current;
        Rectangle selected;

        Block toRotate;
        List<Block> blocks;

        Bitmap bmp;

        public Form1()
        {
            InitializeComponent();

            g = canvas.CreateGraphics();
            
            curser = new Pen(Color.Black,5);

            blocks = new List<Block>();
            
            bmp = new Bitmap(canvas.Width,canvas.Height);
            canvas.DrawToBitmap(bmp, new Rectangle(0, 0, canvas.Width, canvas.Height));

            

            db = DataBase.ConnectDB();
            
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
            if (painting)
            {
                try
                {
                    //width = int.Parse(cols.Text);
                    //height = int.Parse(rows.Text);

                    if (painting)
                    {
                        foreach (Block rect in blocks)
                        {
                            if (isOverlap(rect.r))
                            {
                                MessageBox.Show("Can not add this rectangle as it overlap with drawn one!!");
                                updateScreen();
                                return;
                            }
                        }

                        blocks.Add(new Block(current, curser.Color, current.Width/20, current.Height/20, 0));                     
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("Provide the full data about the block!!");
                    updateScreen();
                }
            }
            

        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (curserMoving && painting)
            {

                Rectangle r = new Rectangle();
                r.X = Math.Min(st.X, e.X);
                r.Y = Math.Min(st.Y, e.Y);
                r.Width = (Math.Abs(st.X - e.X) / 20) * 20;
                r.Height = (Math.Abs(st.Y - e.Y) / 20) * 20;

                current = r;
                updateScreen();
                drawRect(r, 0);
                
            }
        }

        private void finish_Click(object sender, EventArgs e)
        {
            foreach (Block blk in blocks)
            {
                using (Graphics gg = Graphics.FromImage(bmp))
                {
                    drawRect(gg, blk.r, blk.a);
                }
            }
            painting = !painting;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            blocks.Clear();
            painting = true;
        }

        

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (!painting)
            {
                Point click = e.Location;
                foreach (Block blk in blocks)
                {
                    if (blk.r.Contains(click))
                    {
                        selected = blk.r;
                        toRotate = blk;
                        updateScreen();
                        //g.DrawRectangle(Pens.Blue, Rectangle.Round(selected));
                        drawRect(selected,blk.a);
                        TextRenderer.DrawText(g, $"X:{blk.w},Y:{blk.h}", new Font("Arial", 12, FontStyle.Bold), selected, Color.Red);
                        return;
                    }
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                string n = name.Text;
                if (n.Length < 1) throw new Exception(); 
                if (!painting)
                {
                    DataTable tb = db.addHall(n);
                    string id = tb.Rows[0]["ID"].ToString();
                    foreach (Block blk in blocks)
                    {
                        db.addBlock(id, blk);
                    }

                    bmp.Save(@"E:\Work\Bibliotheca\FormProjects\POS\POS\Image\"+n+".jpg", ImageFormat.Png);
                    
                    MessageBox.Show("Saved Without errors");
                    clear_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("You should finish your work first");
                }
                
            }
            catch (Exception E)
            {
                MessageBox.Show("Error will saving" + E.ToString());

            }
        }


        private void updateScreen()
        {
            g.Clear(Color.White);
           
            foreach (Block blk in blocks)
            {
                curser.Color = blk.c;
                drawRect(blk.r, blk.a);
                
            }

        }


        private void drawRect(Graphics graph,Rectangle r, float angle)
        {
            using (Matrix m = new Matrix())
            {
                m.RotateAt(angle, new PointF(r.Left + (r.Width / 2),
                                          r.Top + (r.Height / 2)));
                graph.Transform = m;
                graph.DrawRectangle(curser, r);
                graph.ResetTransform();
            }

        }

        private void drawRect(Rectangle r, float angle)
        {
            using (Matrix m = new Matrix())
            {
                m.RotateAt(angle, new PointF(r.Left + (r.Width / 2),
                                          r.Top + (r.Height / 2)));
                g.Transform = m;
                g.DrawRectangle(curser, r);
                g.ResetTransform();
            }

        }

        private bool isOverlap(Rectangle r)
        {
            Point r1A = new Point(r.X, r.Y),
                r2A = new Point(current.X, current.Y),
                r1B = new Point(r.Right, r.Bottom),
                r2B = new Point(current.Right, current.Bottom);

            return (Math.Max(r1A.X, r2A.X) < Math.Min(r1B.X, r2B.X) && // width > 0
                     Math.Max(r1A.Y, r2A.Y) < Math.Min(r1B.Y, r2B.Y));  // height > 0
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rotate_Click(object sender, EventArgs e)
        {
            if (!painting && selected != null)
            {
                try
                {
                    int Angle = int.Parse(ang.Text);
                    //toRotate.a = Angle;
                    updateScreen();
                    int shift = 5 * toRotate.h;
                    if (Angle < 0)
                    {
                        shift *= -1;
                    }

                    
                    Point lb = new Point(selected.Left,selected.Bottom),
                          rb = new Point(selected.Right,selected.Bottom),
                          lt = new Point(selected.Left + shift, selected.Top),
                          rt = new Point(selected.Right + shift, selected.Top);
                    g.DrawPolygon(curser,new PointF[] { lb,rb , rt ,lt });
                }
                catch (Exception)
                {
                    MessageBox.Show("Provide an Angle to rotate!");
                }
                finally
                {
                    ang.Text = "Angle";
                }
            }
            
        }
    }
}
