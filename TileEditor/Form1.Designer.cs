namespace TileEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxTileSetSize = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownTilesetWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTilesetHeight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxTileSize = new System.Windows.Forms.ComboBox();
            this.groupBoxMapSize = new System.Windows.Forms.GroupBox();
            this.labelMapHeight = new System.Windows.Forms.Label();
            this.numericUpDownMapHeight = new System.Windows.Forms.NumericUpDown();
            this.labelMapWidth = new System.Windows.Forms.Label();
            this.numericUpDownMapWidth = new System.Windows.Forms.NumericUpDown();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicsPanelMap = new TileEditor.GraphicsPanel();
            this.graphicsPanelTileSet = new TileEditor.GraphicsPanel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxTileSetSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTilesetWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTilesetHeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxMapSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMapHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMapWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1216, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.importToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxTileSetSize);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxMapSize);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1216, 722);
            this.splitContainer1.SplitterDistance = 148;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBoxTileSetSize
            // 
            this.groupBoxTileSetSize.Controls.Add(this.label3);
            this.groupBoxTileSetSize.Controls.Add(this.numericUpDownTilesetWidth);
            this.groupBoxTileSetSize.Controls.Add(this.numericUpDownTilesetHeight);
            this.groupBoxTileSetSize.Controls.Add(this.label4);
            this.groupBoxTileSetSize.Location = new System.Drawing.Point(3, 218);
            this.groupBoxTileSetSize.Name = "groupBoxTileSetSize";
            this.groupBoxTileSetSize.Size = new System.Drawing.Size(140, 81);
            this.groupBoxTileSetSize.TabIndex = 1;
            this.groupBoxTileSetSize.TabStop = false;
            this.groupBoxTileSetSize.Text = "Tileset Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Height";
            // 
            // numericUpDownTilesetWidth
            // 
            this.numericUpDownTilesetWidth.Location = new System.Drawing.Point(49, 23);
            this.numericUpDownTilesetWidth.Name = "numericUpDownTilesetWidth";
            this.numericUpDownTilesetWidth.Size = new System.Drawing.Size(83, 20);
            this.numericUpDownTilesetWidth.TabIndex = 8;
            this.numericUpDownTilesetWidth.ValueChanged += new System.EventHandler(this.numericUpDownTilesetWidth_ValueChanged);
            // 
            // numericUpDownTilesetHeight
            // 
            this.numericUpDownTilesetHeight.Location = new System.Drawing.Point(49, 49);
            this.numericUpDownTilesetHeight.Name = "numericUpDownTilesetHeight";
            this.numericUpDownTilesetHeight.Size = new System.Drawing.Size(83, 20);
            this.numericUpDownTilesetHeight.TabIndex = 10;
            this.numericUpDownTilesetHeight.ValueChanged += new System.EventHandler(this.numericUpDownTilesetWidth_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Width";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxTileSize);
            this.groupBox1.Location = new System.Drawing.Point(3, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tile Size";
            // 
            // comboBoxTileSize
            // 
            this.comboBoxTileSize.FormattingEnabled = true;
            this.comboBoxTileSize.Items.AddRange(new object[] {
            "16x16",
            "32x32",
            "64x64"});
            this.comboBoxTileSize.Location = new System.Drawing.Point(11, 29);
            this.comboBoxTileSize.Name = "comboBoxTileSize";
            this.comboBoxTileSize.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTileSize.TabIndex = 0;
            this.comboBoxTileSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxTileSize_SelectedIndexChanged);
            // 
            // groupBoxMapSize
            // 
            this.groupBoxMapSize.Controls.Add(this.labelMapHeight);
            this.groupBoxMapSize.Controls.Add(this.numericUpDownMapHeight);
            this.groupBoxMapSize.Controls.Add(this.labelMapWidth);
            this.groupBoxMapSize.Controls.Add(this.numericUpDownMapWidth);
            this.groupBoxMapSize.Location = new System.Drawing.Point(3, 16);
            this.groupBoxMapSize.Name = "groupBoxMapSize";
            this.groupBoxMapSize.Size = new System.Drawing.Size(140, 90);
            this.groupBoxMapSize.TabIndex = 0;
            this.groupBoxMapSize.TabStop = false;
            this.groupBoxMapSize.Text = "Map Size";
            // 
            // labelMapHeight
            // 
            this.labelMapHeight.AutoSize = true;
            this.labelMapHeight.Location = new System.Drawing.Point(8, 51);
            this.labelMapHeight.Name = "labelMapHeight";
            this.labelMapHeight.Size = new System.Drawing.Size(38, 13);
            this.labelMapHeight.TabIndex = 3;
            this.labelMapHeight.Text = "Height";
            // 
            // numericUpDownMapHeight
            // 
            this.numericUpDownMapHeight.Location = new System.Drawing.Point(49, 49);
            this.numericUpDownMapHeight.Name = "numericUpDownMapHeight";
            this.numericUpDownMapHeight.Size = new System.Drawing.Size(83, 20);
            this.numericUpDownMapHeight.TabIndex = 2;
            this.numericUpDownMapHeight.ValueChanged += new System.EventHandler(this.numericUpDownMapWidth_ValueChanged);
            // 
            // labelMapWidth
            // 
            this.labelMapWidth.AutoSize = true;
            this.labelMapWidth.Location = new System.Drawing.Point(8, 25);
            this.labelMapWidth.Name = "labelMapWidth";
            this.labelMapWidth.Size = new System.Drawing.Size(35, 13);
            this.labelMapWidth.TabIndex = 1;
            this.labelMapWidth.Text = "Width";
            // 
            // numericUpDownMapWidth
            // 
            this.numericUpDownMapWidth.Location = new System.Drawing.Point(49, 23);
            this.numericUpDownMapWidth.Name = "numericUpDownMapWidth";
            this.numericUpDownMapWidth.Size = new System.Drawing.Size(83, 20);
            this.numericUpDownMapWidth.TabIndex = 0;
            this.numericUpDownMapWidth.ValueChanged += new System.EventHandler(this.numericUpDownMapWidth_ValueChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.graphicsPanelMap);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.graphicsPanelTileSet);
            this.splitContainer2.Size = new System.Drawing.Size(1064, 722);
            this.splitContainer2.SplitterDistance = 773;
            this.splitContainer2.TabIndex = 0;
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.importToolStripMenuItem.Text = "Import...";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // graphicsPanelMap
            // 
            this.graphicsPanelMap.BackColor = System.Drawing.Color.White;
            this.graphicsPanelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicsPanelMap.Location = new System.Drawing.Point(0, 0);
            this.graphicsPanelMap.Name = "graphicsPanelMap";
            this.graphicsPanelMap.Size = new System.Drawing.Size(771, 720);
            this.graphicsPanelMap.TabIndex = 0;
            this.graphicsPanelMap.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsPanelMap_Paint);
            // 
            // graphicsPanelTileSet
            // 
            this.graphicsPanelTileSet.BackColor = System.Drawing.Color.White;
            this.graphicsPanelTileSet.Location = new System.Drawing.Point(3, 3);
            this.graphicsPanelTileSet.Name = "graphicsPanelTileSet";
            this.graphicsPanelTileSet.Size = new System.Drawing.Size(280, 199);
            this.graphicsPanelTileSet.TabIndex = 0;
            this.graphicsPanelTileSet.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsPanelTileSet_Paint);
            this.graphicsPanelTileSet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphicsPanelTileSet_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 746);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxTileSetSize.ResumeLayout(false);
            this.groupBoxTileSetSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTilesetWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTilesetHeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxMapSize.ResumeLayout(false);
            this.groupBoxMapSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMapHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMapWidth)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxTileSetSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownTilesetWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownTilesetHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxMapSize;
        private System.Windows.Forms.Label labelMapHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMapHeight;
        private System.Windows.Forms.Label labelMapWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownMapWidth;
        private GraphicsPanel graphicsPanelMap;
        private GraphicsPanel graphicsPanelTileSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxTileSize;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
    }
}

