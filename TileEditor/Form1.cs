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
        Rectangle selectedRect;
        int tileSize;
        Size mapSize;
        MinimapTool minimapTool;

        public Form1()
        {
            InitializeComponent();
            minimapTool = null;
            newToolStripMenuItem_Click(this, new EventArgs());

        }

        private void graphicsPanelTileSet_Paint(object sender, PaintEventArgs e)
        {
           
            //Draw the tileset
            e.Graphics.DrawImage(tileSetBitmap, graphicsPanelTileSet.ClientRectangle);

            //Loop through the array
            for (int i = 0; i < gridTileSet.GetLength(0); i++)
            {
                for (int j = 0; j < gridTileSet.GetLength(1); j++)
                {
                    //Draw tile border depending on selection
                    if (!gridTileSet[i, j].Selected)
                        e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Yellow), 2), gridTileSet[i, j].Rect);
                    else
                        e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Red), 6), gridTileSet[i, j].Rect);

                 }
            }

           // graphicsPanelTileSet.Invalidate();
        
        }

        private void graphicsPanelMap_Paint(object sender, PaintEventArgs e)
        {

            //Draw map grid
            for (int i = 0; i < gridMap.GetLength(0); i++)
            {
                for (int j = 0; j < gridMap.GetLength(1); j++)
                {
                    if (gridTileSet != null && gridTileSet.Length != 0)
                    {
                        e.Graphics.DrawImage(tileSetBitmap, gridMap[i, j].Rect, gridMap[i, j].PaintOver, GraphicsUnit.Pixel);
                    }

                    e.Graphics.DrawRectangle(Pens.Black, gridMap[i, j].Rect);
                        
                }
            }

        }

        private void graphicsPanelMap_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < numericUpDownMapWidth.Value; i++)
            {
                for (int j = 0; j < numericUpDownMapHeight.Value; j++)
                {
                    if (gridMap[i, j].Rect.Contains(graphicsPanelMap.PointToClient(MousePosition)))
                    {
                        gridMap[i, j].PaintOver = selectedRect;
                    }
                }
            }

            graphicsPanelMap.Invalidate();
            if (minimapTool != null)
                minimapTool.Invalidate();

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
                    {
                        gridTileSet[i, j].Selected = true;
                        selectedRect = gridTileSet[i, j].Rect;
                    }
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
                splitContainer2.Panel2.AutoScrollMinSize = tileSetBitmap.Size;

                numericUpDownMapWidth_ValueChanged(this, e);
                numericUpDownTilesetWidth_ValueChanged(this, e);
                graphicsPanelTileSet.Invalidate();

                comboBoxTileSize.SelectedIndex = 2;
                numericUpDownTilesetWidth.Value = 4;
                numericUpDownTilesetHeight.Value = 2;
                numericUpDownMapWidth.Value = 5;
                numericUpDownMapHeight.Value = 5;


                for (int i = 0; i < gridMap.GetLength(0); i++)
                {
                    for (int j = 0; j < gridMap.GetLength(1); j++)
                    {
                        gridMap[i, j].Rect = new Rectangle(tileSize * i, tileSize * j, tileSize, tileSize);
                        gridMap[i, j].PaintOver = gridTileSet[0, 0].Rect;

                    }
                }

                graphicsPanelMap.Invalidate();
            }
        }

        private void numericUpDownMapWidth_ValueChanged(object sender, EventArgs e)
        {
            int x = mapSize.Width;
            int y = mapSize.Height;

            Tile[,] temp = new Tile[(int)numericUpDownMapWidth.Value, (int)numericUpDownMapHeight.Value];


            for (int i = 0; i < (int)numericUpDownMapWidth.Value; i++)
            {
                for (int j = 0; j < (int)numericUpDownMapHeight.Value; j++)
                {

                    temp[i, j] = new Tile();
                    temp[i, j].PaintOver = gridTileSet[0, 0].Rect;
                    if (i < gridMap.GetLength(0) && j < gridMap.GetLength(1))
                    {
                        temp[i, j].Rect = gridMap[i, j].Rect;
                        temp[i, j].PaintOver = gridMap[i, j].PaintOver;
                        temp[i, j].X = gridMap[i, j].X;
                        temp[i, j].Y = gridMap[i, j].Y; 
                    }
                }
            }

            gridMap = new Tile[(int)numericUpDownMapWidth.Value, (int)numericUpDownMapHeight.Value]; 

            for (int i = 0; i < (int)numericUpDownMapWidth.Value; i++)
            {
                for (int j = 0; j < (int)numericUpDownMapHeight.Value; j++)
                {
                    gridMap[i, j] = new Tile();
                    gridMap[i, j].Rect = temp[i, j].Rect;
                    gridMap[i, j].PaintOver = temp[i, j].PaintOver;
                    gridMap[i, j].X = temp[i, j].X;
                    gridMap[i, j].Y = temp[i, j].Y;
                }
            }

            mapSize.Width = (int)numericUpDownMapWidth.Value;
            mapSize.Height = (int)numericUpDownMapHeight.Value;

            splitContainer2.Panel1.AutoScrollMinSize = new Size(gridMap.GetLength(0) * tileSize, gridMap.GetLength(1) * tileSize);
            comboBoxTileSize_SelectedIndexChanged(this, new EventArgs());
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

            for (int i = 0; i < mapSize.Width; i++)
            {
                for (int j = 0; j < mapSize.Height; j++)
                {
                    gridMap[i, j].Rect = new Rectangle(tileSize * i, tileSize * j, tileSize, tileSize);
                }
            }
            numericUpDownTilesetWidth_ValueChanged(this, e);
            graphicsPanelTileSet.Invalidate();
            graphicsPanelMap.Invalidate();
        }

        private void numericUpDownTilesetWidth_ValueChanged(object sender, EventArgs e)
        {
            gridTileSet = new Tile[(int)numericUpDownTilesetWidth.Value, (int)numericUpDownTilesetHeight.Value];
     
            for (int i = 0; i < numericUpDownTilesetWidth.Value; i++)       
            {
                for (int j = 0; j < numericUpDownTilesetHeight.Value; j++)
                {
                    gridTileSet[i, j].Rect = new Rectangle(tileSize * i, tileSize * j, tileSize, tileSize);
                }
            }

            graphicsPanelTileSet.Invalidate();
            graphicsPanelMap.Invalidate();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Load default tileset bitmap
            tileSetBitmap = Properties.Resources.tileset1;

            //Set panel size depending on the tileset size
            graphicsPanelTileSet.Size = tileSetBitmap.Size;
            splitContainer2.Panel2.AutoScrollMinSize = tileSetBitmap.Size;

            //Set default tile size
            tileSize = 64;

            //Set selected rectangle
            selectedRect = new Rectangle();

            //Initialize grids
            gridMap = new Tile[5, 5];
            gridTileSet = new Tile[4, 2];
            mapSize = new Size(5, 5);

            comboBoxTileSize.SelectedIndex = 2;
            numericUpDownTilesetWidth.Value = 4;
            numericUpDownTilesetHeight.Value = 2;
            numericUpDownMapWidth.Value = 5;
            numericUpDownMapHeight.Value = 5;

           // gridMap = (Tile[,])ResizeArray(gridMap, new int[] { (int)numericUpDownMapWidth.Value, (int)numericUpDownMapHeight.Value });

            for (int i = 0; i < mapSize.Width; i++)
            {
                for (int j = 0; j < mapSize.Height; j++)
                {
                    gridMap[i, j].Rect = new Rectangle(tileSize * i, tileSize * j, tileSize, tileSize);
                    gridMap[i, j].PaintOver = gridTileSet[0, 0].Rect;

                }
            }

            graphicsPanelTileSet.Invalidate();
            graphicsPanelMap.Invalidate();

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a size file dialog
            SaveFileDialog dlg = new SaveFileDialog();
            // Set the filter strings
            dlg.Filter = "All Files(*.*)|*.*|Text(*.txt)|*.txt";
            dlg.DefaultExt = "txt";
 
            if (DialogResult.OK == dlg.ShowDialog())
            {
                // Open a stream for writing
                System.IO.StreamWriter writer = new System.IO.StreamWriter(dlg.FileName);

                writer.WriteLine(mapSize.Width.ToString() + ',' + mapSize.Height.ToString() + ','
                    + tileSize.ToString() + ',' + numericUpDownTilesetWidth.Value.ToString() + ','
                    + numericUpDownTilesetHeight.Value.ToString() + ',');
                
                for (int i = 0; i < mapSize.Width; i++)
                {
                    for (int j = 0; j < mapSize.Height; j++)
                    {
                        writer.WriteLine( gridMap[i,j].Rect.X.ToString() + ',' + gridMap[i,j].Rect.Y.ToString() + ','
                            + (gridMap[i, j].PaintOver.X / tileSize).ToString() + ',' + (gridMap[i, j].PaintOver.Y / tileSize).ToString() + ',');
                    }
                }
                    // Close the stream
                    writer.Close();
            }


        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an open file dialog
            OpenFileDialog dlg = new OpenFileDialog();
            // Set the filter strings
            dlg.Filter = "All Files(*.*)|*.*|My Files(*.myf)|*.myf";
            // Display the dialog to the user
            if (DialogResult.OK == dlg.ShowDialog())
            {
                // Open a stream for reading
                System.IO.StreamReader reader = new System.IO.StreamReader(dlg.FileName);
                
                string buffer = reader.ReadToEnd();
                string[] data = buffer.Split(',');

                numericUpDownMapWidth.Value = mapSize.Width = Int32.Parse(data[0]);
                numericUpDownMapHeight.Value =mapSize.Height = Int32.Parse(data[1]);

                switch (Int32.Parse(data[2]))
                {
                    case 16:
                        comboBoxTileSize.SelectedIndex = 0;
                        break;
                    case 32:
                        comboBoxTileSize.SelectedIndex = 1;
                        break;
                    case 64:
                        comboBoxTileSize.SelectedIndex = 2;
                        break;
                }
                numericUpDownTilesetWidth.Value = Decimal.Parse(data[3]);
                numericUpDownTilesetHeight.Value = Decimal.Parse(data[4]); 
       

               // mapSize
                int count = 0;
                for (int i = 0; i < mapSize.Width; i++)
                {
                    for (int j = 0; j < mapSize.Height; j++)
                    {
                        gridMap[i, j].Rect = new Rectangle(tileSize * i, tileSize * j, tileSize, tileSize);
                        int a = Int32.Parse(data[7 + 4* count].ToString().Trim());
                        int b = Int32.Parse(data[8 + 4* count].ToString().Trim());
                        gridMap[i, j].PaintOver = gridTileSet[a, b].Rect;
                        count++;
                    }
                }

                // Close the stream
                reader.Close();
            }

            graphicsPanelMap.Invalidate();
        }

        private void minimapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (minimapTool == null)
            {
                minimapTool = new MinimapTool();
                minimapTool.FormClosed += minimapTool_FormClosed;
                minimapTool.Paint += panel_Paint;

                minimapTool.Panel.Dock = DockStyle.Fill;
                

                minimapTool.Show(this);
            }
        }

        void minimapTool_FormClosed(object sender, FormClosedEventArgs e)
        {
            minimapTool = null;
            
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.ScaleTransform(0.2F, 0.2F);
            //Draw map grid
            for (int i = 0; i < gridMap.GetLength(0); i++)
            {
                for (int j = 0; j < gridMap.GetLength(1); j++)
                {
                    if (gridTileSet != null && gridTileSet.Length != 0)
                    {
                        e.Graphics.DrawImage(tileSetBitmap, gridMap[i, j].Rect, gridMap[i, j].PaintOver, GraphicsUnit.Pixel);
                    }

                    e.Graphics.DrawRectangle(Pens.Black, gridMap[i, j].Rect);

                }
            }


        }


    }
}