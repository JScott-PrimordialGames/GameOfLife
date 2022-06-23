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
            this.components = new System.ComponentModel.Container();
            this.statusHUD = new System.Windows.Forms.StatusStrip();
            this.lb_Generations = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_LivingCells = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_UniverseSize = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.chb_ShowGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.chb_ShowNeiborCount = new System.Windows.Forms.ToolStripMenuItem();
            this.chb_ShowHUD = new System.Windows.Forms.ToolStripMenuItem();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.lb_BoundaryRules = new System.Windows.Forms.ToolStripStatusLabel();
            this.chb_universeRules = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicsPanel1 = new GOL.GraphicsPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusHUD.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusHUD
            // 
            this.statusHUD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lb_Generations,
            this.lb_LivingCells,
            this.lb_UniverseSize,
            this.lb_BoundaryRules});
            this.statusHUD.Location = new System.Drawing.Point(0, 462);
            this.statusHUD.Name = "statusHUD";
            this.statusHUD.Size = new System.Drawing.Size(573, 22);
            this.statusHUD.TabIndex = 2;
            this.statusHUD.Text = "statusStrip1";
            // 
            // lb_Generations
            // 
            this.lb_Generations.Name = "lb_Generations";
            this.lb_Generations.Size = new System.Drawing.Size(90, 17);
            this.lb_Generations.Text = "Generations = 0";
            // 
            // lb_LivingCells
            // 
            this.lb_LivingCells.Name = "lb_LivingCells";
            this.lb_LivingCells.Size = new System.Drawing.Size(87, 17);
            this.lb_LivingCells.Text = "Living Cells = 0";
            // 
            // lb_UniverseSize
            // 
            this.lb_UniverseSize.Name = "lb_UniverseSize";
            this.lb_UniverseSize.Size = new System.Drawing.Size(81, 17);
            this.lb_UniverseSize.Text = "Universe Size: ";
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
            this.timescaleToolStripMenuItem,
            this.chb_universeRules});
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
            this.randomUniverseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.randomUniverseToolStripMenuItem.Text = "Random Universe";
            // 
            // seedToolStripMenuItem
            // 
            this.seedToolStripMenuItem.Name = "seedToolStripMenuItem";
            this.seedToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.seedToolStripMenuItem.Text = "Seed";
            this.seedToolStripMenuItem.Click += new System.EventHandler(this.seedToolStripMenuItem_Click);
            // 
            // timeToolStripMenuItem
            // 
            this.timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            this.timeToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.timeToolStripMenuItem.Text = "Time";
            this.timeToolStripMenuItem.Click += new System.EventHandler(this.timeToolStripMenuItem_Click);
            // 
            // saveLoadToolStripMenuItem
            // 
            this.saveLoadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveUniverseToolStripMenuItem,
            this.loadUniverseToolStripMenuItem});
            this.saveLoadToolStripMenuItem.Name = "saveLoadToolStripMenuItem";
            this.saveLoadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveLoadToolStripMenuItem.Text = "Save/Load";
            // 
            // saveUniverseToolStripMenuItem
            // 
            this.saveUniverseToolStripMenuItem.Name = "saveUniverseToolStripMenuItem";
            this.saveUniverseToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.saveUniverseToolStripMenuItem.Text = "Save Universe";
            this.saveUniverseToolStripMenuItem.Click += new System.EventHandler(this.saveUniverseToolStripMenuItem_Click);
            // 
            // loadUniverseToolStripMenuItem
            // 
            this.loadUniverseToolStripMenuItem.Name = "loadUniverseToolStripMenuItem";
            this.loadUniverseToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.loadUniverseToolStripMenuItem.Text = "Load Universe";
            this.loadUniverseToolStripMenuItem.Click += new System.EventHandler(this.loadUniverseToolStripMenuItem_Click);
            // 
            // universeSizeToolStripMenuItem
            // 
            this.universeSizeToolStripMenuItem.Name = "universeSizeToolStripMenuItem";
            this.universeSizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.universeSizeToolStripMenuItem.Text = "Universe Size";
            this.universeSizeToolStripMenuItem.Click += new System.EventHandler(this.universeSizeToolStripMenuItem_Click);
            // 
            // timescaleToolStripMenuItem
            // 
            this.timescaleToolStripMenuItem.Name = "timescaleToolStripMenuItem";
            this.timescaleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.timescaleToolStripMenuItem.Text = "Timescale";
            this.timescaleToolStripMenuItem.Click += new System.EventHandler(this.timescaleToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chb_ShowGrid,
            this.chb_ShowNeiborCount,
            this.chb_ShowHUD,
            this.colorsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // chb_ShowGrid
            // 
            this.chb_ShowGrid.Checked = true;
            this.chb_ShowGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_ShowGrid.Name = "chb_ShowGrid";
            this.chb_ShowGrid.Size = new System.Drawing.Size(180, 22);
            this.chb_ShowGrid.Text = "Grid";
            this.chb_ShowGrid.Click += new System.EventHandler(this.chb_ShowGrid_Click);
            // 
            // chb_ShowNeiborCount
            // 
            this.chb_ShowNeiborCount.Checked = true;
            this.chb_ShowNeiborCount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_ShowNeiborCount.Name = "chb_ShowNeiborCount";
            this.chb_ShowNeiborCount.Size = new System.Drawing.Size(180, 22);
            this.chb_ShowNeiborCount.Text = "Neighbor Count";
            this.chb_ShowNeiborCount.Click += new System.EventHandler(this.neighborCountToolStripMenuItem_Click);
            // 
            // chb_ShowHUD
            // 
            this.chb_ShowHUD.Checked = true;
            this.chb_ShowHUD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_ShowHUD.Name = "chb_ShowHUD";
            this.chb_ShowHUD.Size = new System.Drawing.Size(180, 22);
            this.chb_ShowHUD.Text = "HUD";
            this.chb_ShowHUD.Click += new System.EventHandler(this.chb_ShowHUD_Click);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorsToolStripMenuItem.Text = "Colors";
            this.colorsToolStripMenuItem.Click += new System.EventHandler(this.colorsToolStripMenuItem_Click);
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
            // lb_BoundaryRules
            // 
            this.lb_BoundaryRules.Name = "lb_BoundaryRules";
            this.lb_BoundaryRules.Size = new System.Drawing.Size(95, 17);
            this.lb_BoundaryRules.Text = "Boundary Rules: ";
            // 
            // chb_universeRules
            // 
            this.chb_universeRules.Name = "chb_universeRules";
            this.chb_universeRules.Size = new System.Drawing.Size(180, 22);
            this.chb_universeRules.Text = "Infinite Universe";
            this.chb_universeRules.Click += new System.EventHandler(this.finiteUniverseToolStripMenuItem_Click);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 484);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.statusHUD);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusHUD.ResumeLayout(false);
            this.statusHUD.PerformLayout();
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
        private System.Windows.Forms.StatusStrip statusHUD;
        private GraphicsPanel graphicsPanel1;
        private System.Windows.Forms.ToolStripStatusLabel lb_Generations;
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
        private System.Windows.Forms.ToolStripMenuItem chb_ShowGrid;
        private System.Windows.Forms.ToolStripMenuItem chb_ShowNeiborCount;
        private System.Windows.Forms.ToolStripMenuItem chb_ShowHUD;
        private System.Windows.Forms.ToolStripStatusLabel lb_LivingCells;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lb_UniverseSize;
        private System.Windows.Forms.ToolStripStatusLabel lb_BoundaryRules;
        private System.Windows.Forms.ToolStripMenuItem chb_universeRules;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}

