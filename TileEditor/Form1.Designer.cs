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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBoxMapSize = new System.Windows.Forms.GroupBox();
            this.groupBoxTileSize = new System.Windows.Forms.GroupBox();
            this.groupBoxTileSetSize = new System.Windows.Forms.GroupBox();
            this.numericUpDownMapWidth = new System.Windows.Forms.NumericUpDown();
            this.labelMapWidth = new System.Windows.Forms.Label();
            this.labelMapHeight = new System.Windows.Forms.Label();
            this.numericUpDownMapHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.SuspendLayout();
            this.groupBoxMapSize.SuspendLayout();
            this.groupBoxTileSize.SuspendLayout();
            this.groupBoxTileSetSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMapWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMapHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1065, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxTileSize);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxMapSize);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1065, 722);
            this.splitContainer1.SplitterDistance = 225;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Size = new System.Drawing.Size(836, 722);
            this.splitContainer2.SplitterDistance = 564;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBoxMapSize
            // 
            this.groupBoxMapSize.Controls.Add(this.labelMapHeight);
            this.groupBoxMapSize.Controls.Add(this.numericUpDownMapHeight);
            this.groupBoxMapSize.Controls.Add(this.labelMapWidth);
            this.groupBoxMapSize.Controls.Add(this.numericUpDownMapWidth);
            this.groupBoxMapSize.Location = new System.Drawing.Point(11, 16);
            this.groupBoxMapSize.Name = "groupBoxMapSize";
            this.groupBoxMapSize.Size = new System.Drawing.Size(163, 90);
            this.groupBoxMapSize.TabIndex = 0;
            this.groupBoxMapSize.TabStop = false;
            this.groupBoxMapSize.Text = "Map Size";
            // 
            // groupBoxTileSize
            // 
            this.groupBoxTileSize.Controls.Add(this.label1);
            this.groupBoxTileSize.Controls.Add(this.numericUpDown2);
            this.groupBoxTileSize.Controls.Add(this.numericUpDown1);
            this.groupBoxTileSize.Controls.Add(this.label2);
            this.groupBoxTileSize.Location = new System.Drawing.Point(11, 121);
            this.groupBoxTileSize.Name = "groupBoxTileSize";
            this.groupBoxTileSize.Size = new System.Drawing.Size(163, 81);
            this.groupBoxTileSize.TabIndex = 1;
            this.groupBoxTileSize.TabStop = false;
            this.groupBoxTileSize.Text = "Tile Size";
            // 
            // groupBoxTileSetSize
            // 
            this.groupBoxTileSetSize.Controls.Add(this.label3);
            this.groupBoxTileSetSize.Controls.Add(this.numericUpDown4);
            this.groupBoxTileSetSize.Controls.Add(this.numericUpDown3);
            this.groupBoxTileSetSize.Controls.Add(this.label4);
            this.groupBoxTileSetSize.Location = new System.Drawing.Point(11, 218);
            this.groupBoxTileSetSize.Name = "groupBoxTileSetSize";
            this.groupBoxTileSetSize.Size = new System.Drawing.Size(163, 81);
            this.groupBoxTileSetSize.TabIndex = 1;
            this.groupBoxTileSetSize.TabStop = false;
            this.groupBoxTileSetSize.Text = "Tileset Size";
            // 
            // numericUpDownMapWidth
            // 
            this.numericUpDownMapWidth.Location = new System.Drawing.Point(57, 23);
            this.numericUpDownMapWidth.Name = "numericUpDownMapWidth";
            this.numericUpDownMapWidth.Size = new System.Drawing.Size(83, 20);
            this.numericUpDownMapWidth.TabIndex = 0;
            // 
            // labelMapWidth
            // 
            this.labelMapWidth.AutoSize = true;
            this.labelMapWidth.Location = new System.Drawing.Point(16, 25);
            this.labelMapWidth.Name = "labelMapWidth";
            this.labelMapWidth.Size = new System.Drawing.Size(35, 13);
            this.labelMapWidth.TabIndex = 1;
            this.labelMapWidth.Text = "Width";
            // 
            // labelMapHeight
            // 
            this.labelMapHeight.AutoSize = true;
            this.labelMapHeight.Location = new System.Drawing.Point(16, 51);
            this.labelMapHeight.Name = "labelMapHeight";
            this.labelMapHeight.Size = new System.Drawing.Size(38, 13);
            this.labelMapHeight.TabIndex = 3;
            this.labelMapHeight.Text = "Height";
            // 
            // numericUpDownMapHeight
            // 
            this.numericUpDownMapHeight.Location = new System.Drawing.Point(57, 49);
            this.numericUpDownMapHeight.Name = "numericUpDownMapHeight";
            this.numericUpDownMapHeight.Size = new System.Drawing.Size(83, 20);
            this.numericUpDownMapHeight.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Height";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(57, 45);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Width";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(57, 19);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Height";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(57, 45);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Width";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(57, 19);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown4.TabIndex = 8;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
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
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 746);
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBoxMapSize.ResumeLayout(false);
            this.groupBoxMapSize.PerformLayout();
            this.groupBoxTileSize.ResumeLayout(false);
            this.groupBoxTileSize.PerformLayout();
            this.groupBoxTileSetSize.ResumeLayout(false);
            this.groupBoxTileSetSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMapWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMapHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxTileSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxMapSize;
        private System.Windows.Forms.Label labelMapHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMapHeight;
        private System.Windows.Forms.Label labelMapWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownMapWidth;
    }
}

