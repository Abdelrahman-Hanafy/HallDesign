using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallDesign
{
    class Block
    {
        public Rectangle r { get; }
        public Color c { get; set; }
        public int w { get; set; }
        public int h {get; set;}
        public float a { get; set; }

        public Block(Rectangle rect,Color color, int width, int height, float angle)
        {
            r = rect;
            c = color;
            w = width;
            h = height;
            a = angle;
        }


    }
}
