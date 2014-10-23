using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileEditor
{
     public struct Tile
    {
        int x;
        int y;
        Rectangle rect;
        bool selected;
        Rectangle paintOver;

        public Rectangle PaintOver
        {
            get { return paintOver; }
            set { paintOver = value; }
        }

        public Tile(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.selected = false;
            this.rect = Rectangle.Empty;
            this.paintOver = Rectangle.Empty;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Rectangle Rect
        {
            get { return rect; }
            set { rect = value; }
        }

        public bool Selected
        {
            get { return selected; }
            set { selected = value; }
        }
  
    }
}
