namespace BannerEdge
{
    partial class MainForm
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
            this._mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextPanel = new System.Windows.Forms.Panel();
            this._modulePathBtn = new System.Windows.Forms.Button();
            this._modulePathTxt = new System.Windows.Forms.TextBox();
            this._modulePathLbl = new System.Windows.Forms.Label();
            this._loadImageBtn = new System.Windows.Forms.Button();
            this._spritesheetXMLBtn = new System.Windows.Forms.Button();
            this._atlasImageBtn = new System.Windows.Forms.Button();
            this._spritesheetXMLPathTxt = new System.Windows.Forms.TextBox();
            this._atlasImagePathTxt = new System.Windows.Forms.TextBox();
            this._spritesheetXMLPathLbl = new System.Windows.Forms.Label();
            this._atlasImagePathLbl = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ResultsPanel = new System.Windows.Forms.Panel();
            this._resultsListBox = new System.Windows.Forms.ListBox();
            this.ExportPanel = new System.Windows.Forms.Panel();
            this._clearSelectionBtn = new System.Windows.Forms.Button();
            this._exportAllBtn = new System.Windows.Forms.Button();
            this._exportSingleBtn = new System.Windows.Forms.Button();
            this.FoundPanel = new System.Windows.Forms.Panel();
            this._partsFoundLbl = new System.Windows.Forms.Label();
            this._searchBoxTxt = new System.Windows.Forms.TextBox();
            this.MainPicturePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.selectSpriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._packAtlasBtn = new System.Windows.Forms.Button();
            this._mainMenuStrip.SuspendLayout();
            this.ContextPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.ResultsPanel.SuspendLayout();
            this.ExportPanel.SuspendLayout();
            this.FoundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainMenuStrip
            // 
            this._mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this._mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this._mainMenuStrip.Name = "_mainMenuStrip";
            this._mainMenuStrip.Size = new System.Drawing.Size(1236, 24);
            this._mainMenuStrip.TabIndex = 0;
            this._mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectSpriteToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // ContextPanel
            // 
            this.ContextPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ContextPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextPanel.Controls.Add(this._packAtlasBtn);
            this.ContextPanel.Controls.Add(this._modulePathBtn);
            this.ContextPanel.Controls.Add(this._modulePathTxt);
            this.ContextPanel.Controls.Add(this._modulePathLbl);
            this.ContextPanel.Controls.Add(this._loadImageBtn);
            this.ContextPanel.Controls.Add(this._spritesheetXMLBtn);
            this.ContextPanel.Controls.Add(this._atlasImageBtn);
            this.ContextPanel.Controls.Add(this._spritesheetXMLPathTxt);
            this.ContextPanel.Controls.Add(this._atlasImagePathTxt);
            this.ContextPanel.Controls.Add(this._spritesheetXMLPathLbl);
            this.ContextPanel.Controls.Add(this._atlasImagePathLbl);
            this.ContextPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContextPanel.Location = new System.Drawing.Point(0, 24);
            this.ContextPanel.Name = "ContextPanel";
            this.ContextPanel.Size = new System.Drawing.Size(1236, 121);
            this.ContextPanel.TabIndex = 1;
            // 
            // _modulePathBtn
            // 
            this._modulePathBtn.Location = new System.Drawing.Point(900, 83);
            this._modulePathBtn.Name = "_modulePathBtn";
            this._modulePathBtn.Size = new System.Drawing.Size(75, 23);
            this._modulePathBtn.TabIndex = 9;
            this._modulePathBtn.Text = "Browse";
            this._modulePathBtn.UseVisualStyleBackColor = true;
            this._modulePathBtn.Click += new System.EventHandler(this._modulePathBtn_Click);
            // 
            // _modulePathTxt
            // 
            this._modulePathTxt.Enabled = false;
            this._modulePathTxt.Location = new System.Drawing.Point(135, 86);
            this._modulePathTxt.Name = "_modulePathTxt";
            this._modulePathTxt.Size = new System.Drawing.Size(759, 20);
            this._modulePathTxt.TabIndex = 8;
            // 
            // _modulePathLbl
            // 
            this._modulePathLbl.AutoSize = true;
            this._modulePathLbl.Location = new System.Drawing.Point(11, 89);
            this._modulePathLbl.Name = "_modulePathLbl";
            this._modulePathLbl.Size = new System.Drawing.Size(105, 13);
            this._modulePathLbl.TabIndex = 7;
            this._modulePathLbl.Text = "Output Module Path:";
            // 
            // _loadImageBtn
            // 
            this._loadImageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._loadImageBtn.Location = new System.Drawing.Point(1012, 16);
            this._loadImageBtn.Margin = new System.Windows.Forms.Padding(0);
            this._loadImageBtn.Name = "_loadImageBtn";
            this._loadImageBtn.Size = new System.Drawing.Size(93, 86);
            this._loadImageBtn.TabIndex = 6;
            this._loadImageBtn.Text = "Load and Split Atlas";
            this._loadImageBtn.UseVisualStyleBackColor = true;
            this._loadImageBtn.Click += new System.EventHandler(this._loadImageBtn_click);
            // 
            // _spritesheetXMLBtn
            // 
            this._spritesheetXMLBtn.Location = new System.Drawing.Point(900, 45);
            this._spritesheetXMLBtn.Name = "_spritesheetXMLBtn";
            this._spritesheetXMLBtn.Size = new System.Drawing.Size(75, 23);
            this._spritesheetXMLBtn.TabIndex = 5;
            this._spritesheetXMLBtn.Text = "Browse";
            this._spritesheetXMLBtn.UseVisualStyleBackColor = true;
            this._spritesheetXMLBtn.Click += new System.EventHandler(this._spritesheetXMLBtn_Click);
            // 
            // _atlasImageBtn
            // 
            this._atlasImageBtn.Location = new System.Drawing.Point(900, 10);
            this._atlasImageBtn.Name = "_atlasImageBtn";
            this._atlasImageBtn.Size = new System.Drawing.Size(75, 23);
            this._atlasImageBtn.TabIndex = 4;
            this._atlasImageBtn.Text = "Browse";
            this._atlasImageBtn.UseVisualStyleBackColor = true;
            this._atlasImageBtn.Click += new System.EventHandler(this._atlasImageBtn_Click);
            // 
            // _spritesheetXMLPathTxt
            // 
            this._spritesheetXMLPathTxt.Enabled = false;
            this._spritesheetXMLPathTxt.Location = new System.Drawing.Point(135, 48);
            this._spritesheetXMLPathTxt.Name = "_spritesheetXMLPathTxt";
            this._spritesheetXMLPathTxt.Size = new System.Drawing.Size(759, 20);
            this._spritesheetXMLPathTxt.TabIndex = 3;
            // 
            // _atlasImagePathTxt
            // 
            this._atlasImagePathTxt.Enabled = false;
            this._atlasImagePathTxt.Location = new System.Drawing.Point(135, 13);
            this._atlasImagePathTxt.Name = "_atlasImagePathTxt";
            this._atlasImagePathTxt.Size = new System.Drawing.Size(759, 20);
            this._atlasImagePathTxt.TabIndex = 2;
            // 
            // _spritesheetXMLPathLbl
            // 
            this._spritesheetXMLPathLbl.AutoSize = true;
            this._spritesheetXMLPathLbl.Location = new System.Drawing.Point(11, 51);
            this._spritesheetXMLPathLbl.Name = "_spritesheetXMLPathLbl";
            this._spritesheetXMLPathLbl.Size = new System.Drawing.Size(113, 13);
            this._spritesheetXMLPathLbl.TabIndex = 1;
            this._spritesheetXMLPathLbl.Text = "Spritesheet XML Path:";
            // 
            // _atlasImagePathLbl
            // 
            this._atlasImagePathLbl.AutoSize = true;
            this._atlasImagePathLbl.Location = new System.Drawing.Point(11, 16);
            this._atlasImagePathLbl.Name = "_atlasImagePathLbl";
            this._atlasImagePathLbl.Size = new System.Drawing.Size(90, 13);
            this._atlasImagePathLbl.TabIndex = 0;
            this._atlasImagePathLbl.Text = "Atlas Image Path:";
            // 
            // MainPanel
            // 
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.Controls.Add(this.MainPicturePanel);
            this.MainPanel.Controls.Add(this.ResultsPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 145);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1236, 432);
            this.MainPanel.TabIndex = 2;
            // 
            // ResultsPanel
            // 
            this.ResultsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultsPanel.Controls.Add(this._resultsListBox);
            this.ResultsPanel.Controls.Add(this.ExportPanel);
            this.ResultsPanel.Controls.Add(this.FoundPanel);
            this.ResultsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ResultsPanel.Location = new System.Drawing.Point(0, 0);
            this.ResultsPanel.Name = "ResultsPanel";
            this.ResultsPanel.Size = new System.Drawing.Size(281, 432);
            this.ResultsPanel.TabIndex = 0;
            // 
            // _resultsListBox
            // 
            this._resultsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._resultsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._resultsListBox.FormattingEnabled = true;
            this._resultsListBox.Location = new System.Drawing.Point(0, 43);
            this._resultsListBox.Name = "_resultsListBox";
            this._resultsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this._resultsListBox.Size = new System.Drawing.Size(279, 327);
            this._resultsListBox.TabIndex = 2;
            this._resultsListBox.SelectedValueChanged += new System.EventHandler(this._resultsListBox_SelectedValueChanged);
            // 
            // ExportPanel
            // 
            this.ExportPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ExportPanel.Controls.Add(this._clearSelectionBtn);
            this.ExportPanel.Controls.Add(this._exportAllBtn);
            this.ExportPanel.Controls.Add(this._exportSingleBtn);
            this.ExportPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExportPanel.Location = new System.Drawing.Point(0, 370);
            this.ExportPanel.Name = "ExportPanel";
            this.ExportPanel.Size = new System.Drawing.Size(279, 60);
            this.ExportPanel.TabIndex = 1;
            // 
            // _clearSelectionBtn
            // 
            this._clearSelectionBtn.Location = new System.Drawing.Point(183, 8);
            this._clearSelectionBtn.Name = "_clearSelectionBtn";
            this._clearSelectionBtn.Size = new System.Drawing.Size(75, 41);
            this._clearSelectionBtn.TabIndex = 2;
            this._clearSelectionBtn.Text = "Clear Selection";
            this._clearSelectionBtn.UseVisualStyleBackColor = true;
            this._clearSelectionBtn.Click += new System.EventHandler(this._clearSelectionBtn_Click);
            // 
            // _exportAllBtn
            // 
            this._exportAllBtn.Location = new System.Drawing.Point(102, 8);
            this._exportAllBtn.Name = "_exportAllBtn";
            this._exportAllBtn.Size = new System.Drawing.Size(75, 41);
            this._exportAllBtn.TabIndex = 1;
            this._exportAllBtn.Text = "Export All";
            this._exportAllBtn.UseVisualStyleBackColor = true;
            this._exportAllBtn.Click += new System.EventHandler(this._exportAllBtn_Click);
            // 
            // _exportSingleBtn
            // 
            this._exportSingleBtn.Location = new System.Drawing.Point(23, 8);
            this._exportSingleBtn.Name = "_exportSingleBtn";
            this._exportSingleBtn.Size = new System.Drawing.Size(75, 41);
            this._exportSingleBtn.TabIndex = 0;
            this._exportSingleBtn.Text = "Export Selected";
            this._exportSingleBtn.UseVisualStyleBackColor = true;
            this._exportSingleBtn.Click += new System.EventHandler(this._exportSingleBtn_Click);
            // 
            // FoundPanel
            // 
            this.FoundPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.FoundPanel.Controls.Add(this._searchBoxTxt);
            this.FoundPanel.Controls.Add(this._partsFoundLbl);
            this.FoundPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FoundPanel.Location = new System.Drawing.Point(0, 0);
            this.FoundPanel.Name = "FoundPanel";
            this.FoundPanel.Size = new System.Drawing.Size(279, 43);
            this.FoundPanel.TabIndex = 0;
            // 
            // _partsFoundLbl
            // 
            this._partsFoundLbl.AutoSize = true;
            this._partsFoundLbl.Location = new System.Drawing.Point(11, 15);
            this._partsFoundLbl.Name = "_partsFoundLbl";
            this._partsFoundLbl.Size = new System.Drawing.Size(101, 13);
            this._partsFoundLbl.TabIndex = 0;
            this._partsFoundLbl.Text = "Sprite Parts Search:";
            // 
            // _searchBoxTxt
            // 
            this._searchBoxTxt.Location = new System.Drawing.Point(114, 12);
            this._searchBoxTxt.Name = "_searchBoxTxt";
            this._searchBoxTxt.Size = new System.Drawing.Size(144, 20);
            this._searchBoxTxt.TabIndex = 1;
            this._searchBoxTxt.TextChanged += new System.EventHandler(this._searchBoxTxt_TextChanged);
            // 
            // MainPicturePanel
            // 
            this.MainPicturePanel.AutoScroll = true;
            this.MainPicturePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPicturePanel.Location = new System.Drawing.Point(281, 0);
            this.MainPicturePanel.Name = "MainPicturePanel";
            this.MainPicturePanel.Size = new System.Drawing.Size(955, 432);
            this.MainPicturePanel.TabIndex = 1;
            // 
            // selectSpriteToolStripMenuItem
            // 
            this.selectSpriteToolStripMenuItem.Name = "selectSpriteToolStripMenuItem";
            this.selectSpriteToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.selectSpriteToolStripMenuItem.Text = "Set SpriteSheetGenerator Path";
            this.selectSpriteToolStripMenuItem.Click += new System.EventHandler(this.selectSpriteToolStripMenuItem_Click);
            // 
            // _packAtlasBtn
            // 
            this._packAtlasBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._packAtlasBtn.Location = new System.Drawing.Point(1122, 16);
            this._packAtlasBtn.Margin = new System.Windows.Forms.Padding(0);
            this._packAtlasBtn.Name = "_packAtlasBtn";
            this._packAtlasBtn.Size = new System.Drawing.Size(93, 86);
            this._packAtlasBtn.TabIndex = 10;
            this._packAtlasBtn.Text = "Pack Atlas";
            this._packAtlasBtn.UseVisualStyleBackColor = true;
            this._packAtlasBtn.Click += new System.EventHandler(this._packAtlasBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 577);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ContextPanel);
            this.Controls.Add(this._mainMenuStrip);
            this.MainMenuStrip = this._mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "BannerEdge";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this._mainMenuStrip.ResumeLayout(false);
            this._mainMenuStrip.PerformLayout();
            this.ContextPanel.ResumeLayout(false);
            this.ContextPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.ResultsPanel.ResumeLayout(false);
            this.ExportPanel.ResumeLayout(false);
            this.FoundPanel.ResumeLayout(false);
            this.FoundPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel ContextPanel;
        private System.Windows.Forms.Button _spritesheetXMLBtn;
        private System.Windows.Forms.Button _atlasImageBtn;
        private System.Windows.Forms.TextBox _spritesheetXMLPathTxt;
        private System.Windows.Forms.TextBox _atlasImagePathTxt;
        private System.Windows.Forms.Label _spritesheetXMLPathLbl;
        private System.Windows.Forms.Label _atlasImagePathLbl;
        private System.Windows.Forms.Button _loadImageBtn;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel ResultsPanel;
        private System.Windows.Forms.ListBox _resultsListBox;
        private System.Windows.Forms.Panel ExportPanel;
        private System.Windows.Forms.Panel FoundPanel;
        private System.Windows.Forms.Label _partsFoundLbl;
        private System.Windows.Forms.Button _exportAllBtn;
        private System.Windows.Forms.Button _exportSingleBtn;
        private System.Windows.Forms.Button _clearSelectionBtn;
        private System.Windows.Forms.Button _modulePathBtn;
        private System.Windows.Forms.TextBox _modulePathTxt;
        private System.Windows.Forms.Label _modulePathLbl;
        private System.Windows.Forms.TextBox _searchBoxTxt;
        private System.Windows.Forms.FlowLayoutPanel MainPicturePanel;
        private System.Windows.Forms.ToolStripMenuItem selectSpriteToolStripMenuItem;
        private System.Windows.Forms.Button _packAtlasBtn;
    }
}

