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
        int angle;

        bool curserMoving = false;
        bool painting = true;
        int screenCnt;
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
            angle = int.Parse(ConfigurationSettings.AppSettings["Angle"]);
            screenCnt = 0;
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

                foreach (Block blk in blocks){
                    if (isOverlap(blk.r,current))
                    {
                        MessageBox.Show("Can not add this rectangle as it overlap with drawn one!!");
                        
                        updateScreen();
                        return;
                    }
                }

                if (curser.Color == Color.Yellow )
                {
                    if (screenCnt == 0) { 
                        screenCnt++;
                        blocks.Add(new Block(current, curser.Color, 0, 0, 0,true));
                    }
                    else
                    {
                        MessageBox.Show("Can not add this Screen as it has been drawn!!");
                        
                        updateScreen();
                        return;
                    }
                }
                else
                {
                    blocks.Add(new Block(current, curser.Color, current.Width / size, current.Height / size, 0,false));

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
                    drawRect(gg, blk,blk.c);
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
                
                if (!painting)
                {
                    if(isOverlap(blk))
                    {
                        MessageBox.Show("can't to rotate as it will make overlap");
                        if (blk.a > 0) blk.a -= angle;
                        else if (blk.a < 0) blk.a += angle;
                    }
                    drawRect(g, blk, blk.c);
                    
                }
                    
                else
                    drawRect(g, blk, blk.c);

            }
            if (selected != null)
            {
                string tmp;
                if (selected.sc) tmp = "Screen";
                else tmp = $"Cols:{selected.w},Rows:{selected.h}";
                drawRect(g, selected, Color.Red);
                TextRenderer.DrawText(g, tmp, new Font("Arial", 12, FontStyle.Bold), selected.r, Color.Red);
            }

        }


        private void drawRect(Graphics graph,Block blk,Color c)
        {

            Point lb = new Point(blk.r.Left, blk.r.Bottom),
                          rb = new Point(blk.r.Right, blk.r.Bottom),
                          lt = new Point(blk.r.Left + blk.a, blk.r.Top),
                          rt = new Point(blk.r.Right + blk.a, blk.r.Top);
            graph.DrawPolygon(new Pen(c, 5), new PointF[] { lb, rb, rt, lt });

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!painting && selected != null)
            {
                selected.a -= angle;
                updateScreen();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!painting && selected != null)
            {

                selected.a += angle;
                updateScreen();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!painting && selected != null)
            {
                blocks.Remove(selected);
                if (selected.c == Color.Yellow) screenCnt--;
                selected = null;
                updateScreen();
            }
        }

        private bool isOverlap(Block blk)
        {
            bool flg = false;
            Rectangle r = new Rectangle();
            r.X = blk.r.Left + blk.a;
            r.Y = blk.r.Top;
            r.Height = blk.r.Bottom - blk.r.Top;
            r.Width = blk.r.Right + blk.a - r.X;

            foreach (Block b in blocks)
            {
                if(b != blk)
                {
                    Rectangle r2 = new Rectangle();
                    r2.X = b.r.Left + b.a;
                    r2.Y = b.r.Top;
                    r2.Height = b.r.Bottom - b.r.Top;
                    r2.Width = b.r.Right + b.a - r.X;

                    flg = isOverlap(r2,r);
                    if (flg) break;
                }
            }
            return flg;
            
        }

        private bool isOverlap(Rectangle r, Rectangle c)
        {
            Point r1A = new Point(r.X, r.Y),
                r2A = new Point(c.X, c.Y),
                r1B = new Point(r.Right, r.Bottom),
                r2B = new Point(c.Right, c.Bottom);

            return (Math.Max(r1A.X, r2A.X) < Math.Min(r1B.X, r2B.X) && // width > 0
                     Math.Max(r1A.Y, r2A.Y) < Math.Min(r1B.Y, r2B.Y));  // height > 0
        }
    }
}
