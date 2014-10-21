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
        Tile[,] tilesTileset;
        Tile[,] tilesMap;
        Bitmap tileSetBitmap;


        public Form1()
        {
            InitializeComponent();
            tileSetBitmap = Properties.Resources.tileset1;
            graphicsPanelTileSet.Size = tileSetBitmap.Size;

        }

        private void graphicsPanelTileSet_Paint(object sender, PaintEventArgs e)
        {
            //Set panel size depending on the tileset size
           
            //Draw the tileset
            //e.Graphics.DrawImage(Properties.Resources.tileset1, graphicsPanelTileSet.ClientRectangle);
            e.Graphics.DrawImage(tileSetBitmap, graphicsPanelTileSet.ClientRectangle);

            //Set the size of individual tiles
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

            //Initialize tiles array
            tilesTileset = new Tile[(int)numericUpDownTilesetWidth.Value, (int)numericUpDownTilesetHeight.Value];

            //Loop through the array
            for (int i = 0; i < numericUpDownTilesetWidth.Value; i++)
            {
                for (int j = 0; j < numericUpDownTilesetHeight.Value; j++)
                {
                    //Initialize tile
                    tilesTileset[i, j].Rect = new Rectangle(tileSize * i, tileSize * j, tileSize, tileSize);
                  
                    //Draw tile border depending on selection
                    if (tilesTileset[i, j].Selected)
                        e.Graphics.DrawRectangle(Pens.Red, tilesTileset[i, j].Rect); 
                    else
                        e.Graphics.DrawRectangle(Pens.Black, tilesTileset[i, j].Rect);
                  //  e.Graphics.DrawString(tiles[i, j].Rect.Location.ToString(), graphicsPanelTileSet.Font, Brushes.Red, tiles[i, j].Rect.Location);

                }
            }


            Point pos = graphicsPanelTileSet.PointToClient(MousePosition);

            e.Graphics.DrawString(pos.ToString(), graphicsPanelTileSet.Font, Brushes.Red, new Point(0, 0));

             graphicsPanelTileSet.Invalidate();
        }

        private void graphicsPanelMap_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void graphicsPanelTileSet_MouseClick(object sender, MouseEventArgs e)
        {
            //Loop through the array
            for (int i = 0; i < numericUpDownTilesetWidth.Value; i++)
            {
                for (int j = 0; j < numericUpDownTilesetHeight.Value; j++)
                {
                    //Select tile if clicked on it and deselect any other selected tile
                    if (tilesTileset[i, j].Rect.Contains(graphicsPanelTileSet.PointToClient(MousePosition)))
                        tilesTileset[i, j].Selected = true;
                    else
                        tilesTileset[i, j].Selected = false;
                }
            }

            graphicsPanelTileSet.Invalidate();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (DialogResult.OK == dlg.ShowDialog())
            {
                tileSetBitmap = new Bitmap(dlg.FileName);
                graphicsPanelTileSet.Size = tileSetBitmap.Size;

                graphicsPanelTileSet.Invalidate();
            }
        }

    }
}