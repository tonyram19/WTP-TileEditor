using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//e.Graphics.DrawString(gridTileSet[i, j].Rect.Location.ToString(), graphicsPanelTileSet.Font, Brushes.Red, gridTileSet[i, j].Rect.Location);

namespace TileEditor
{
    public partial class Form1 : Form
    {
        Tile[,] gridTileSet;
        Tile[,] gridMap;
        Bitmap tileSetBitmap;
        int tileSize;


        public Form1()
        {
            InitializeComponent();

            //Load default tileset bitmap
            tileSetBitmap = Properties.Resources.tileset1;
            
            //Set panel size depending on the tileset size
            graphicsPanelTileSet.Size = tileSetBitmap.Size;
            
            //Set default tile size
            tileSize = 0;

        }

        private void graphicsPanelTileSet_Paint(object sender, PaintEventArgs e)
        {
           
            //Draw the tileset
            e.Graphics.DrawImage(tileSetBitmap, graphicsPanelTileSet.ClientRectangle);

            //Loop through the array
            for (int i = 0; i < numericUpDownTilesetWidth.Value; i++)
            {
                for (int j = 0; j < numericUpDownTilesetHeight.Value; j++)
                {
                    //Draw tile border depending on selection
                    if (!gridTileSet[i, j].Selected)
                        e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Yellow), 2), gridTileSet[i, j].Rect);
                    else
                        e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Red), 6), gridTileSet[i, j].Rect);

                 }
            }

            graphicsPanelTileSet.Invalidate();
        
        }

        private void graphicsPanelMap_Paint(object sender, PaintEventArgs e)
        {

            //Draw map grid
            for (int i = 0; i < numericUpDownMapWidth.Value; i++)
            {
                for (int j = 0; j < numericUpDownMapHeight.Value; j++)
                {
                    if (gridTileSet != null && gridTileSet.Length != 0)
                    {
                        e.Graphics.DrawImage(tileSetBitmap, gridMap[i, j].Rect, gridTileSet[0, 0].Rect, GraphicsUnit.Pixel);
                        e.Graphics.DrawRectangle(Pens.Black, gridMap[i, j].Rect);
                    }
                        
                }
            }

//            graphicsPanelMap.Invalidate();

        }
        
        private void graphicsPanelTileSet_MouseClick(object sender, MouseEventArgs e)
        {
            //Loop through the array
            for (int i = 0; i < numericUpDownTilesetWidth.Value; i++)
            {
                for (int j = 0; j < numericUpDownTilesetHeight.Value; j++)
                {
                    
                    //Select tile if clicked on it and deselect any other selected tile
                    if (gridTileSet[i, j].Rect.Contains(graphicsPanelTileSet.PointToClient(MousePosition)))
                        gridTileSet[i, j].Selected = true;
                    else
                        gridTileSet[i, j].Selected = false;
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

        private void numericUpDownMapWidth_ValueChanged(object sender, EventArgs e)
        {
            gridMap = new Tile[(int)numericUpDownMapWidth.Value, (int)numericUpDownMapHeight.Value];

            for (int i = 0; i < numericUpDownMapWidth.Value; i++)
            {
                for (int j = 0; j < numericUpDownMapHeight.Value; j++)
                    gridMap[i, j].Rect = new Rectangle(tileSize * i, tileSize * j, tileSize, tileSize);
            }

            graphicsPanelMap.Invalidate();
        }

        private void comboBoxTileSize_SelectedIndexChanged(object sender, EventArgs e)
        {
     
            switch (comboBoxTileSize.SelectedIndex)
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

            gridMap = new Tile[(int)numericUpDownMapWidth.Value, (int)numericUpDownMapHeight.Value];

            for (int i = 0; i < numericUpDownMapWidth.Value; i++)
            {
                for (int j = 0; j < numericUpDownMapHeight.Value; j++)
                    gridMap[i, j].Rect = new Rectangle(tileSize * i, tileSize * j, tileSize, tileSize);
            }

            gridTileSet = new Tile[(int)numericUpDownTilesetWidth.Value, (int)numericUpDownTilesetHeight.Value];

            for (int i = 0; i < numericUpDownTilesetWidth.Value; i++)
            {
                for (int j = 0; j < numericUpDownTilesetHeight.Value; j++)
                    gridTileSet[i, j].Rect = new Rectangle(tileSize * i, tileSize * j, tileSize, tileSize);
            }

            graphicsPanelTileSet.Invalidate();
            graphicsPanelMap.Invalidate();
        }

        private void numericUpDownTilesetWidth_ValueChanged(object sender, EventArgs e)
        {
            gridTileSet = new Tile[(int)numericUpDownTilesetWidth.Value, (int)numericUpDownTilesetHeight.Value];
     
            for (int i = 0; i < numericUpDownTilesetWidth.Value; i++)       
            {
                for (int j = 0; j < numericUpDownTilesetHeight.Value; j++)
                    gridTileSet[i, j].Rect = new Rectangle(tileSize * i, tileSize * j, tileSize, tileSize);
            }

            graphicsPanelTileSet.Invalidate();
            graphicsPanelMap.Invalidate();
        }








    }
}