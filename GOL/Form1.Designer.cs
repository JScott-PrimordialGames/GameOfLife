namespace GOL
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelGenerations = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLivingCells = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextGenerationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newUniverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomUniverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveUniverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadUniverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.universeSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timescaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neighborCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hUDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.graphicsPanel1 = new GOL.GraphicsPanel();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelGenerations,
            this.toolStripStatusLabelLivingCells});
            this.statusStrip1.Location = new System.Drawing.Point(0, 462);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(573, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelGenerations
            // 
            this.toolStripStatusLabelGenerations.Name = "toolStripStatusLabelGenerations";
            this.toolStripStatusLabelGenerations.Size = new System.Drawing.Size(90, 17);
            this.toolStripStatusLabelGenerations.Text = "Generations = 0";
            // 
            // toolStripStatusLabelLivingCells
            // 
            this.toolStripStatusLabelLivingCells.Name = "toolStripStatusLabelLivingCells";
            this.toolStripStatusLabelLivingCells.Size = new System.Drawing.Size(87, 17);
            this.toolStripStatusLabelLivingCells.Text = "Living Cells = 0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.nextGenerationToolStripMenuItem1,
            this.newUniverseToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(573, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Image = global::GOL.Properties.Resources.StartWithoutDebug_16x;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.startToolStripMenuItem.ToolTipText = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Image = global::GOL.Properties.Resources.Pause_16x;
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.pauseToolStripMenuItem.ToolTipText = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem1_Click);
            // 
            // nextGenerationToolStripMenuItem1
            // 
            this.nextGenerationToolStripMenuItem1.Image = global::GOL.Properties.Resources.PlayStep_16x;
            this.nextGenerationToolStripMenuItem1.Name = "nextGenerationToolStripMenuItem1";
            this.nextGenerationToolStripMenuItem1.Size = new System.Drawing.Size(28, 20);
            this.nextGenerationToolStripMenuItem1.ToolTipText = "Next Generation";
            this.nextGenerationToolStripMenuItem1.Click += new System.EventHandler(this.nextGenerationToolStripMenuItem1_Click);
            // 
            // newUniverseToolStripMenuItem
            // 
            this.newUniverseToolStripMenuItem.Image = global::GOL.Properties.Resources.Refresh_16x;
            this.newUniverseToolStripMenuItem.Name = "newUniverseToolStripMenuItem";
            this.newUniverseToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.newUniverseToolStripMenuItem.ToolTipText = "New Universe";
            this.newUniverseToolStripMenuItem.Click += new System.EventHandler(this.newUniverseToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomUniverseToolStripMenuItem,
            this.saveLoadToolStripMenuItem,
            this.universeSizeToolStripMenuItem,
            this.timescaleToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // randomUniverseToolStripMenuItem
            // 
            this.randomUniverseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seedToolStripMenuItem,
            this.timeToolStripMenuItem});
            this.randomUniverseToolStripMenuItem.Name = "randomUniverseToolStripMenuItem";
            this.randomUniverseToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.randomUniverseToolStripMenuItem.Text = "Random Universe";
            // 
            // seedToolStripMenuItem
            // 
            this.seedToolStripMenuItem.Name = "seedToolStripMenuItem";
            this.seedToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.seedToolStripMenuItem.Text = "Seed";
            // 
            // timeToolStripMenuItem
            // 
            this.timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            this.timeToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.timeToolStripMenuItem.Text = "Time";
            // 
            // saveLoadToolStripMenuItem
            // 
            this.saveLoadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveUniverseToolStripMenuItem,
            this.loadUniverseToolStripMenuItem});
            this.saveLoadToolStripMenuItem.Name = "saveLoadToolStripMenuItem";
            this.saveLoadToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.saveLoadToolStripMenuItem.Text = "Save/Load";
            // 
            // saveUniverseToolStripMenuItem
            // 
            this.saveUniverseToolStripMenuItem.Name = "saveUniverseToolStripMenuItem";
            this.saveUniverseToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.saveUniverseToolStripMenuItem.Text = "Save Universe";
            // 
            // loadUniverseToolStripMenuItem
            // 
            this.loadUniverseToolStripMenuItem.Name = "loadUniverseToolStripMenuItem";
            this.loadUniverseToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.loadUniverseToolStripMenuItem.Text = "Load Universe";
            // 
            // universeSizeToolStripMenuItem
            // 
            this.universeSizeToolStripMenuItem.Name = "universeSizeToolStripMenuItem";
            this.universeSizeToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.universeSizeToolStripMenuItem.Text = "Universe Size";
            // 
            // timescaleToolStripMenuItem
            // 
            this.timescaleToolStripMenuItem.Name = "timescaleToolStripMenuItem";
            this.timescaleToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.timescaleToolStripMenuItem.Text = "Timescale";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gridToolStripMenuItem,
            this.neighborCountToolStripMenuItem,
            this.hUDToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // gridToolStripMenuItem
            // 
            this.gridToolStripMenuItem.Checked = true;
            this.gridToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
            this.gridToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.gridToolStripMenuItem.Text = "Grid";
            // 
            // neighborCountToolStripMenuItem
            // 
            this.neighborCountToolStripMenuItem.Checked = true;
            this.neighborCountToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.neighborCountToolStripMenuItem.Name = "neighborCountToolStripMenuItem";
            this.neighborCountToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.neighborCountToolStripMenuItem.Text = "Neighbor Count";
            // 
            // hUDToolStripMenuItem
            // 
            this.hUDToolStripMenuItem.Checked = true;
            this.hUDToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hUDToolStripMenuItem.Name = "hUDToolStripMenuItem";
            this.hUDToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.hUDToolStripMenuItem.Text = "HUD";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.graphicsPanel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(573, 438);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(573, 462);
            this.toolStripContainer1.TabIndex = 4;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // graphicsPanel1
            // 
            this.graphicsPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.graphicsPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicsPanel1.Location = new System.Drawing.Point(0, 0);
            this.graphicsPanel1.Name = "graphicsPanel1";
            this.graphicsPanel1.Size = new System.Drawing.Size(573, 438);
            this.graphicsPanel1.TabIndex = 3;
            this.graphicsPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsPanel1_Paint);
            this.graphicsPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 484);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private GraphicsPanel graphicsPanel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGenerations;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newUniverseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextGenerationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomUniverseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveUniverseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadUniverseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem universeSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timescaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neighborCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hUDToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLivingCells;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    }
}

