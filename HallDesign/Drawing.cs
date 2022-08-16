using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace HallDesign
{
    public partial class Drawing : Form
    {
        Graphics g;
        Pen curser;
        DataBase db;

        int size;

        bool curserMoving = false;
        bool painting = true;

        Point st;
      
        Rectangle current;

        Block selected;
        List<Block> blocks;

        Bitmap bmp;

        [Obsolete]
        public Drawing()
        {
            InitializeComponent();

            g = canvas.CreateGraphics();
            
            curser = new Pen(Color.Black,5);

            blocks = new List<Block>();

            db = DataBase.ConnectDB();
            
            size = int.Parse(ConfigurationSettings.AppSettings["SIZE"]);
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

                        blocks.Add(new Block(current, curser.Color, current.Width/ size, current.Height/ size, 0));                     
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
                r.Width = (Math.Abs(st.X - e.X) / size) * size;
                r.Height = (Math.Abs(st.Y - e.Y) / size) * size;

                current = r;
                updateScreen();
                g.DrawRectangle(curser,r);
                
            }
        }

        private void finish_Click(object sender, EventArgs e)
        {
            
            painting = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            painting = true;
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
                        selected = blk;
                        updateScreen();
                        TextRenderer.DrawText(g, $"X:{blk.w},Y:{blk.h}", new Font("Arial", 12, FontStyle.Bold), blk.r, Color.Red);
                        return;
                    }
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(canvas.Width, canvas.Height);
            canvas.DrawToBitmap(bmp, new Rectangle(0, 0, canvas.Width, canvas.Height));

            foreach (Block blk in blocks)
            {
                using (Graphics gg = Graphics.FromImage(bmp))
                {
                    curser.Color = blk.c;

                        drawRect(gg, blk);
                }
            }

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
                if (blk.a == 0)
                {
                    drawRect(blk);
                }
                else
                {
                    drawRect(g,blk);

                }
            }

        }


        private void drawRect(Graphics graph,Block blk)
        {

            Point lb = new Point(blk.r.Left, blk.r.Bottom),
                          rb = new Point(blk.r.Right, blk.r.Bottom),
                          lt = new Point(blk.r.Left + blk.a, blk.r.Top),
                          rt = new Point(blk.r.Right + blk.a, blk.r.Top);
            graph.DrawPolygon(curser, new PointF[] { lb, rb, rt, lt });

        }

        private void drawRect(Block blk)
        {

                g.DrawRectangle(curser, blk.r);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (!painting && selected != null)
            {
                try
                {
                    int Angle = -1;
                    selected.a += Angle;
                    updateScreen();

                }
                catch (Exception)
                {
                    MessageBox.Show("Provide an Angle to rotate!");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!painting && selected != null)
            {
                try
                {
                    int Angle = 1;
                    selected.a += Angle;
                    updateScreen();

                }
                catch (Exception)
                {
                    MessageBox.Show("Provide an Angle to rotate!");
                }

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


    }
}
