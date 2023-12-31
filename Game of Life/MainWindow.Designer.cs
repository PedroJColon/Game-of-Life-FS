﻿
namespace Game_of_Life
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backColoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cellColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.viewMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHUDHeadsUpDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewNeighborCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeCellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromSeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.universeSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.finiteUniverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toroidalUniverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NextButton = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.StartButton = new System.Windows.Forms.ToolStripButton();
            this.Next = new System.Windows.Forms.ToolStripButton();
            this.PauseButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelGenerations = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCellCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimerIntervalStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cellColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gridColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHUDHeadsUpDisplayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewNeighborCountToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewGridToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.universeSettingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicsPanel1 = new Game_of_Life.GraphicsPanel();
            this.displayColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.NextButton.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.ContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(764, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(221, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backColoToolStripMenuItem,
            this.cellColorToolStripMenuItem,
            this.gridColorToolStripMenuItem,
            this.displayColorToolStripMenuItem,
            this.toolStripSeparator4,
            this.viewMenuToolStripMenuItem});
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // backColoToolStripMenuItem
            // 
            this.backColoToolStripMenuItem.Name = "backColoToolStripMenuItem";
            this.backColoToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.backColoToolStripMenuItem.Text = "Back Color";
            this.backColoToolStripMenuItem.Click += new System.EventHandler(this.backColoToolStripMenuItem_Click);
            // 
            // cellColorToolStripMenuItem
            // 
            this.cellColorToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.cellColorToolStripMenuItem.Name = "cellColorToolStripMenuItem";
            this.cellColorToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.cellColorToolStripMenuItem.Text = "Cell Color";
            this.cellColorToolStripMenuItem.Click += new System.EventHandler(this.cellColorToolStripMenuItem_Click);
            // 
            // gridColorToolStripMenuItem
            // 
            this.gridColorToolStripMenuItem.Name = "gridColorToolStripMenuItem";
            this.gridColorToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.gridColorToolStripMenuItem.Text = "Grid Color";
            this.gridColorToolStripMenuItem.Click += new System.EventHandler(this.gridColorToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(162, 6);
            // 
            // viewMenuToolStripMenuItem
            // 
            this.viewMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHUDHeadsUpDisplayToolStripMenuItem,
            this.viewNeighborCountToolStripMenuItem,
            this.viewGridToolStripMenuItem});
            this.viewMenuToolStripMenuItem.Name = "viewMenuToolStripMenuItem";
            this.viewMenuToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.viewMenuToolStripMenuItem.Text = "View Menu";
            // 
            // viewHUDHeadsUpDisplayToolStripMenuItem
            // 
            this.viewHUDHeadsUpDisplayToolStripMenuItem.Checked = true;
            this.viewHUDHeadsUpDisplayToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewHUDHeadsUpDisplayToolStripMenuItem.Name = "viewHUDHeadsUpDisplayToolStripMenuItem";
            this.viewHUDHeadsUpDisplayToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.viewHUDHeadsUpDisplayToolStripMenuItem.Text = "View HUD (Heads-Up-Display)";
            this.viewHUDHeadsUpDisplayToolStripMenuItem.Click += new System.EventHandler(this.viewHUDHeadsUpDisplayToolStripMenuItem_Click);
            // 
            // viewNeighborCountToolStripMenuItem
            // 
            this.viewNeighborCountToolStripMenuItem.Checked = true;
            this.viewNeighborCountToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewNeighborCountToolStripMenuItem.Name = "viewNeighborCountToolStripMenuItem";
            this.viewNeighborCountToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.viewNeighborCountToolStripMenuItem.Text = "View Neighbor Count";
            this.viewNeighborCountToolStripMenuItem.Click += new System.EventHandler(this.viewNeighborCountToolStripMenuItem_Click);
            // 
            // viewGridToolStripMenuItem
            // 
            this.viewGridToolStripMenuItem.Checked = true;
            this.viewGridToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewGridToolStripMenuItem.Name = "viewGridToolStripMenuItem";
            this.viewGridToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.viewGridToolStripMenuItem.Text = "View Grid";
            this.viewGridToolStripMenuItem.Click += new System.EventHandler(this.viewGridToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomizeCellsToolStripMenuItem,
            this.universeSettingsToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.reloadToolStripMenuItem,
            this.toolStripSeparator3,
            this.finiteUniverseToolStripMenuItem,
            this.toroidalUniverseToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // randomizeCellsToolStripMenuItem
            // 
            this.randomizeCellsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromSeedToolStripMenuItem,
            this.fromTimeToolStripMenuItem});
            this.randomizeCellsToolStripMenuItem.Name = "randomizeCellsToolStripMenuItem";
            this.randomizeCellsToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.randomizeCellsToolStripMenuItem.Text = "Randomize Cells";
            // 
            // fromSeedToolStripMenuItem
            // 
            this.fromSeedToolStripMenuItem.Name = "fromSeedToolStripMenuItem";
            this.fromSeedToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.fromSeedToolStripMenuItem.Text = "From Seed";
            this.fromSeedToolStripMenuItem.Click += new System.EventHandler(this.fromSeedToolStripMenuItem_Click);
            // 
            // fromTimeToolStripMenuItem
            // 
            this.fromTimeToolStripMenuItem.Name = "fromTimeToolStripMenuItem";
            this.fromTimeToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.fromTimeToolStripMenuItem.Text = "From Time";
            this.fromTimeToolStripMenuItem.Click += new System.EventHandler(this.fromTimeToolStripMenuItem_Click);
            // 
            // universeSettingsToolStripMenuItem
            // 
            this.universeSettingsToolStripMenuItem.Name = "universeSettingsToolStripMenuItem";
            this.universeSettingsToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.universeSettingsToolStripMenuItem.Text = "Universe Settings";
            this.universeSettingsToolStripMenuItem.Click += new System.EventHandler(this.universeSettingsToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(204, 6);
            // 
            // finiteUniverseToolStripMenuItem
            // 
            this.finiteUniverseToolStripMenuItem.Name = "finiteUniverseToolStripMenuItem";
            this.finiteUniverseToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.finiteUniverseToolStripMenuItem.Text = "Finite Universe";
            this.finiteUniverseToolStripMenuItem.Click += new System.EventHandler(this.finiteUniverseToolStripMenuItem_Click);
            // 
            // toroidalUniverseToolStripMenuItem
            // 
            this.toroidalUniverseToolStripMenuItem.Name = "toroidalUniverseToolStripMenuItem";
            this.toroidalUniverseToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.toroidalUniverseToolStripMenuItem.Text = "Toroidal Universe";
            this.toroidalUniverseToolStripMenuItem.Click += new System.EventHandler(this.toroidalUniverseToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(147, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // NextButton
            // 
            this.NextButton.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NextButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator6,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator7,
            this.helpToolStripButton,
            this.StartButton,
            this.Next,
            this.PauseButton});
            this.NextButton.Location = new System.Drawing.Point(0, 28);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(764, 27);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "toolStrip1";
            this.NextButton.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.NextButton_ItemClicked);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // StartButton
            // 
            this.StartButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StartButton.Image = global::Game_of_Life.Properties.Resources.StartButton;
            this.StartButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(29, 24);
            this.StartButton.Text = "Start";
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Next
            // 
            this.Next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Next.Image = global::Game_of_Life.Properties.Resources.NextButton;
            this.Next.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(29, 24);
            this.Next.Text = "Next";
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PauseButton.Image = global::Game_of_Life.Properties.Resources.PauseButton;
            this.PauseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(29, 24);
            this.PauseButton.Text = "Pause";
            this.PauseButton.ToolTipText = "Pause";
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelGenerations,
            this.toolStripStatusLabelCellCount,
            this.TimerIntervalStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 541);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(764, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelGenerations
            // 
            this.toolStripStatusLabelGenerations.Name = "toolStripStatusLabelGenerations";
            this.toolStripStatusLabelGenerations.Size = new System.Drawing.Size(114, 20);
            this.toolStripStatusLabelGenerations.Text = "Generations = 0";
            // 
            // toolStripStatusLabelCellCount
            // 
            this.toolStripStatusLabelCellCount.Name = "toolStripStatusLabelCellCount";
            this.toolStripStatusLabelCellCount.Size = new System.Drawing.Size(103, 20);
            this.toolStripStatusLabelCellCount.Text = "Cell Count = 0";
            // 
            // TimerIntervalStatus
            // 
            this.TimerIntervalStatus.Name = "TimerIntervalStatus";
            this.TimerIntervalStatus.Size = new System.Drawing.Size(137, 20);
            this.TimerIntervalStatus.Text = "Time Interval = 100";
            // 
            // ContextMenu
            // 
            this.ContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.universeSettingsToolStripMenuItem1});
            this.ContextMenu.Name = "contextMenuStrip1";
            this.ContextMenu.Size = new System.Drawing.Size(192, 76);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backColorToolStripMenuItem,
            this.cellColorToolStripMenuItem1,
            this.gridColorToolStripMenuItem1,
            this.displayColorToolStripMenuItem1});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // backColorToolStripMenuItem
            // 
            this.backColorToolStripMenuItem.Name = "backColorToolStripMenuItem";
            this.backColorToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.backColorToolStripMenuItem.Text = "Back Color";
            this.backColorToolStripMenuItem.Click += new System.EventHandler(this.backColorToolStripMenuItem_Click);
            // 
            // cellColorToolStripMenuItem1
            // 
            this.cellColorToolStripMenuItem1.Name = "cellColorToolStripMenuItem1";
            this.cellColorToolStripMenuItem1.Size = new System.Drawing.Size(163, 26);
            this.cellColorToolStripMenuItem1.Text = "Cell Color";
            this.cellColorToolStripMenuItem1.Click += new System.EventHandler(this.cellColorToolStripMenuItem1_Click);
            // 
            // gridColorToolStripMenuItem1
            // 
            this.gridColorToolStripMenuItem1.Name = "gridColorToolStripMenuItem1";
            this.gridColorToolStripMenuItem1.Size = new System.Drawing.Size(163, 26);
            this.gridColorToolStripMenuItem1.Text = "Grid Color";
            this.gridColorToolStripMenuItem1.Click += new System.EventHandler(this.gridColorToolStripMenuItem1_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHUDHeadsUpDisplayToolStripMenuItem1,
            this.viewNeighborCountToolStripMenuItem1,
            this.viewGridToolStripMenuItem1});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewHUDHeadsUpDisplayToolStripMenuItem1
            // 
            this.viewHUDHeadsUpDisplayToolStripMenuItem1.Checked = true;
            this.viewHUDHeadsUpDisplayToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewHUDHeadsUpDisplayToolStripMenuItem1.Name = "viewHUDHeadsUpDisplayToolStripMenuItem1";
            this.viewHUDHeadsUpDisplayToolStripMenuItem1.Size = new System.Drawing.Size(294, 26);
            this.viewHUDHeadsUpDisplayToolStripMenuItem1.Text = "View HUD (Heads-Up Display)";
            this.viewHUDHeadsUpDisplayToolStripMenuItem1.Click += new System.EventHandler(this.viewHUDHeadsUpDisplayToolStripMenuItem1_Click);
            // 
            // viewNeighborCountToolStripMenuItem1
            // 
            this.viewNeighborCountToolStripMenuItem1.Checked = true;
            this.viewNeighborCountToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewNeighborCountToolStripMenuItem1.Name = "viewNeighborCountToolStripMenuItem1";
            this.viewNeighborCountToolStripMenuItem1.Size = new System.Drawing.Size(294, 26);
            this.viewNeighborCountToolStripMenuItem1.Text = "View Neighbor Count";
            this.viewNeighborCountToolStripMenuItem1.Click += new System.EventHandler(this.viewNeighborCountToolStripMenuItem1_Click);
            // 
            // viewGridToolStripMenuItem1
            // 
            this.viewGridToolStripMenuItem1.Checked = true;
            this.viewGridToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.viewGridToolStripMenuItem1.Name = "viewGridToolStripMenuItem1";
            this.viewGridToolStripMenuItem1.Size = new System.Drawing.Size(294, 26);
            this.viewGridToolStripMenuItem1.Text = "View Grid";
            this.viewGridToolStripMenuItem1.Click += new System.EventHandler(this.viewGridToolStripMenuItem1_Click);
            // 
            // universeSettingsToolStripMenuItem1
            // 
            this.universeSettingsToolStripMenuItem1.Name = "universeSettingsToolStripMenuItem1";
            this.universeSettingsToolStripMenuItem1.Size = new System.Drawing.Size(191, 24);
            this.universeSettingsToolStripMenuItem1.Text = "Universe Settings";
            this.universeSettingsToolStripMenuItem1.Click += new System.EventHandler(this.universeSettingsToolStripMenuItem1_Click);
            // 
            // graphicsPanel1
            // 
            this.graphicsPanel1.BackColor = System.Drawing.Color.White;
            this.graphicsPanel1.ContextMenuStrip = this.ContextMenu;
            this.graphicsPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicsPanel1.Location = new System.Drawing.Point(0, 55);
            this.graphicsPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.graphicsPanel1.Name = "graphicsPanel1";
            this.graphicsPanel1.Size = new System.Drawing.Size(764, 486);
            this.graphicsPanel1.TabIndex = 3;
            this.graphicsPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsPanel1_Paint);
            this.graphicsPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel1_MouseClick);
            // 
            // displayColorToolStripMenuItem
            // 
            this.displayColorToolStripMenuItem.Name = "displayColorToolStripMenuItem";
            this.displayColorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.displayColorToolStripMenuItem.Text = "Display Color";
            this.displayColorToolStripMenuItem.Click += new System.EventHandler(this.displayColorToolStripMenuItem_Click);
            // 
            // displayColorToolStripMenuItem1
            // 
            this.displayColorToolStripMenuItem1.Name = "displayColorToolStripMenuItem1";
            this.displayColorToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.displayColorToolStripMenuItem1.Text = "Display Color";
            this.displayColorToolStripMenuItem1.Click += new System.EventHandler(this.displayColorToolStripMenuItem1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 567);
            this.Controls.Add(this.graphicsPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Text = "Game of Life";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.NextButton.ResumeLayout(false);
            this.NextButton.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip NextButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private GraphicsPanel graphicsPanel1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGenerations;
        private System.Windows.Forms.ToolStripButton StartButton;
        private System.Windows.Forms.ToolStripButton Next;
        private System.Windows.Forms.ToolStripButton PauseButton;
        private System.Windows.Forms.ToolStripMenuItem randomizeCellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem universeSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backColoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cellColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCellCount;
        private System.Windows.Forms.ToolStripMenuItem viewMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewNeighborCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHUDHeadsUpDisplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finiteUniverseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toroidalUniverseToolStripMenuItem;
        private new System.Windows.Forms.ContextMenuStrip ContextMenu;
        private System.Windows.Forms.ToolStripStatusLabel TimerIntervalStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem universeSettingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cellColorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gridColorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewHUDHeadsUpDisplayToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewNeighborCountToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewGridToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fromSeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayColorToolStripMenuItem1;
    }
}

