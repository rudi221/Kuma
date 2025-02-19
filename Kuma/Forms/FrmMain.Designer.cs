namespace Kuma
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            menuStrip1 = new MenuStrip();
            tsmProgramm = new ToolStripMenuItem();
            tsmCloseItem = new ToolStripMenuItem();
            tsmSettings = new ToolStripMenuItem();
            tsmKategorieItem = new ToolStripMenuItem();
            tsmEmailItem = new ToolStripMenuItem();
            tsmFtpItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            tlpMain = new TableLayoutPanel();
            tlpData = new TableLayoutPanel();
            tplArtistData = new TableLayoutPanel();
            pnlAddress = new Panel();
            pnlArtistData = new Panel();
            pnlArtistFiles = new Panel();
            pnlMenu = new Panel();
            menuStrip1.SuspendLayout();
            tlpMain.SuspendLayout();
            tlpData.SuspendLayout();
            tplArtistData.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmProgramm, tsmSettings });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1194, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmProgramm
            // 
            tsmProgramm.DropDownItems.AddRange(new ToolStripItem[] { tsmCloseItem });
            tsmProgramm.Name = "tsmProgramm";
            tsmProgramm.Size = new Size(76, 20);
            tsmProgramm.Text = "Programm";
            // 
            // tsmCloseItem
            // 
            tsmCloseItem.Name = "tsmCloseItem";
            tsmCloseItem.Size = new Size(180, 22);
            tsmCloseItem.Text = "Schließen";
            tsmCloseItem.Click += tsmCloseItem_Click;
            // 
            // tsmSettings
            // 
            tsmSettings.DropDownItems.AddRange(new ToolStripItem[] { tsmKategorieItem, tsmEmailItem, tsmFtpItem });
            tsmSettings.Name = "tsmSettings";
            tsmSettings.Size = new Size(90, 20);
            tsmSettings.Text = "Einstellungen";
            // 
            // tsmKategorieItem
            // 
            tsmKategorieItem.Name = "tsmKategorieItem";
            tsmKategorieItem.Size = new Size(180, 22);
            tsmKategorieItem.Text = "Kategorie";
            tsmKategorieItem.Click += tsmKategorieItem_Click;
            // 
            // tsmEmailItem
            // 
            tsmEmailItem.Name = "tsmEmailItem";
            tsmEmailItem.Size = new Size(180, 22);
            tsmEmailItem.Text = "E-Mail";
            tsmEmailItem.Click += tsmEmailItem_Click;
            // 
            // tsmFtpItem
            // 
            tsmFtpItem.Name = "tsmFtpItem";
            tsmFtpItem.Size = new Size(180, 22);
            tsmFtpItem.Text = "FTP";
            tsmFtpItem.Click += tsmFtpItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 839);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1194, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 3;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpMain.Controls.Add(tlpData, 1, 3);
            tlpMain.Controls.Add(pnlMenu, 1, 1);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 24);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 5;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.Size = new Size(1194, 815);
            tlpMain.TabIndex = 2;
            // 
            // tlpData
            // 
            tlpData.ColumnCount = 3;
            tlpData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlpData.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpData.Controls.Add(tplArtistData, 0, 0);
            tlpData.Controls.Add(pnlArtistFiles, 2, 0);
            tlpData.Dock = DockStyle.Fill;
            tlpData.Location = new Point(20, 153);
            tlpData.Margin = new Padding(0);
            tlpData.Name = "tlpData";
            tlpData.RowCount = 1;
            tlpData.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpData.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpData.Size = new Size(1154, 641);
            tlpData.TabIndex = 0;
            // 
            // tplArtistData
            // 
            tplArtistData.ColumnCount = 1;
            tplArtistData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tplArtistData.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tplArtistData.Controls.Add(pnlAddress, 0, 0);
            tplArtistData.Controls.Add(pnlArtistData, 0, 2);
            tplArtistData.Dock = DockStyle.Fill;
            tplArtistData.Location = new Point(0, 0);
            tplArtistData.Margin = new Padding(0);
            tplArtistData.Name = "tplArtistData";
            tplArtistData.RowCount = 3;
            tplArtistData.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tplArtistData.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tplArtistData.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tplArtistData.Size = new Size(793, 641);
            tplArtistData.TabIndex = 0;
            // 
            // pnlAddress
            // 
            pnlAddress.BackColor = SystemColors.Control;
            pnlAddress.Dock = DockStyle.Fill;
            pnlAddress.Location = new Point(0, 0);
            pnlAddress.Margin = new Padding(0);
            pnlAddress.Name = "pnlAddress";
            pnlAddress.Size = new Size(793, 186);
            pnlAddress.TabIndex = 0;
            // 
            // pnlArtistData
            // 
            pnlArtistData.BackColor = SystemColors.Control;
            pnlArtistData.Dock = DockStyle.Fill;
            pnlArtistData.Location = new Point(0, 206);
            pnlArtistData.Margin = new Padding(0);
            pnlArtistData.Name = "pnlArtistData";
            pnlArtistData.Size = new Size(793, 435);
            pnlArtistData.TabIndex = 1;
            // 
            // pnlArtistFiles
            // 
            pnlArtistFiles.BackColor = SystemColors.Control;
            pnlArtistFiles.Dock = DockStyle.Fill;
            pnlArtistFiles.Location = new Point(813, 0);
            pnlArtistFiles.Margin = new Padding(0);
            pnlArtistFiles.Name = "pnlArtistFiles";
            pnlArtistFiles.Size = new Size(341, 641);
            pnlArtistFiles.TabIndex = 1;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = SystemColors.Control;
            pnlMenu.Dock = DockStyle.Fill;
            pnlMenu.Location = new Point(20, 20);
            pnlMenu.Margin = new Padding(0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(1154, 113);
            pnlMenu.TabIndex = 1;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1194, 861);
            Controls.Add(tlpMain);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            Text = "Kuma";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tlpMain.ResumeLayout(false);
            tlpData.ResumeLayout(false);
            tplArtistData.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmProgramm;
        private ToolStripMenuItem tsmCloseItem;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem tsmSettings;
        private ToolStripMenuItem tsmKategorieItem;
        private ToolStripMenuItem tsmEmailItem;
        private ToolStripMenuItem tsmFtpItem;
        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tlpData;
        private TableLayoutPanel tplArtistData;
        private Panel pnlAddress;
        private Panel pnlArtistFiles;
        private Panel pnlMenu;
        private Panel pnlArtistData;
    }
}
