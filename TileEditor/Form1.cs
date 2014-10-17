using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TileEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void graphicsPanelTileSet_Paint(object sender, PaintEventArgs e)
        {
            graphicsPanelTileSet.Size = Properties.Resources.tileset3.Size;
            e.Graphics.DrawImage(Properties.Resources.tileset3, graphicsPanelTileSet.ClientRectangle);

            int tileSize = 0;
            switch(comboBoxTileSize.SelectedIndex)
            {
                case 0:
                    tileSize = 16;
                    break;
                case 1:
                    tileSize = 32;
                    break;
                case 2:
                    tileSize = 64;
                    break;
            }

            for (int i = 0; i < numericUpDownTilesetWidth.Value; i++)
            {
                for (int j = 0; j < numericUpDownTilesetHeight.Value; j++)
                {
                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(tileSize * i, tileSize * j, tileSize, tileSize)); 
                }
            }

            graphicsPanelTileSet.Invalidate();
        }
    }
}