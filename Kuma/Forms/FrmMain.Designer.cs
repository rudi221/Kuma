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
            statusStrip1 = new StatusStrip();
            tsmProgramm = new ToolStripMenuItem();
            tsmCloseItem = new ToolStripMenuItem();
            tsmSettings = new ToolStripMenuItem();
            tsmKategorieItem = new ToolStripMenuItem();
            tsmEmailItem = new ToolStripMenuItem();
            tsmFtpItem = new ToolStripMenuItem();
            tlpMain = new TableLayoutPanel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmProgramm, tsmSettings });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(804, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 429);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(804, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
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
            // 
            // tsmEmailItem
            // 
            tsmEmailItem.Name = "tsmEmailItem";
            tsmEmailItem.Size = new Size(180, 22);
            tsmEmailItem.Text = "E-Mail";
            // 
            // tsmFtpItem
            // 
            tsmFtpItem.Name = "tsmFtpItem";
            tsmFtpItem.Size = new Size(180, 22);
            tsmFtpItem.Text = "FTP";
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 3;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 24);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 5;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.Size = new Size(804, 405);
            tlpMain.TabIndex = 2;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(804, 451);
            Controls.Add(tlpMain);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            Text = "Kuma";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
    }
}
