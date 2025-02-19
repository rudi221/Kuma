namespace Kuma.Forms
{
    partial class FrmAddArtist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddArtist));
            tlpMain = new TableLayoutPanel();
            pnlButtons = new Panel();
            btnCancel = new Button();
            btnUpdate = new Button();
            pnlData = new Panel();
            tbxTour = new TextBox();
            lblTour = new Label();
            tbxArtist = new TextBox();
            lblArtist = new Label();
            tlpMain.SuspendLayout();
            pnlButtons.SuspendLayout();
            pnlData.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.BackColor = SystemColors.ControlLight;
            tlpMain.ColumnCount = 3;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpMain.Controls.Add(pnlButtons, 1, 3);
            tlpMain.Controls.Add(pnlData, 1, 1);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 5;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpMain.Size = new Size(345, 172);
            tlpMain.TabIndex = 1;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = SystemColors.Control;
            pnlButtons.Controls.Add(btnCancel);
            pnlButtons.Controls.Add(btnUpdate);
            pnlButtons.Dock = DockStyle.Fill;
            pnlButtons.Location = new Point(15, 118);
            pnlButtons.Margin = new Padding(0);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(315, 38);
            pnlButtons.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(131, 8);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Abbrechen";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(212, 8);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 23);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Übernehmen";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // pnlData
            // 
            pnlData.BackColor = SystemColors.Control;
            pnlData.Controls.Add(tbxTour);
            pnlData.Controls.Add(lblTour);
            pnlData.Controls.Add(tbxArtist);
            pnlData.Controls.Add(lblArtist);
            pnlData.Dock = DockStyle.Fill;
            pnlData.Location = new Point(15, 15);
            pnlData.Margin = new Padding(0);
            pnlData.Name = "pnlData";
            pnlData.Size = new Size(315, 88);
            pnlData.TabIndex = 1;
            // 
            // tbxTour
            // 
            tbxTour.Location = new Point(93, 47);
            tbxTour.Name = "tbxTour";
            tbxTour.Size = new Size(150, 23);
            tbxTour.TabIndex = 3;
            // 
            // lblTour
            // 
            lblTour.AutoSize = true;
            lblTour.Location = new Point(39, 50);
            lblTour.Name = "lblTour";
            lblTour.RightToLeft = RightToLeft.Yes;
            lblTour.Size = new Size(31, 15);
            lblTour.TabIndex = 2;
            lblTour.Text = "Tour";
            // 
            // tbxArtist
            // 
            tbxArtist.Location = new Point(93, 18);
            tbxArtist.Name = "tbxArtist";
            tbxArtist.Size = new Size(150, 23);
            tbxArtist.TabIndex = 1;
            // 
            // lblArtist
            // 
            lblArtist.AutoSize = true;
            lblArtist.Location = new Point(39, 21);
            lblArtist.Name = "lblArtist";
            lblArtist.Size = new Size(50, 15);
            lblArtist.TabIndex = 0;
            lblArtist.Text = "Künstler";
            // 
            // FrmAddArtist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 172);
            Controls.Add(tlpMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmAddArtist";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Neue Tour";
            tlpMain.ResumeLayout(false);
            pnlButtons.ResumeLayout(false);
            pnlData.ResumeLayout(false);
            pnlData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Panel pnlButtons;
        private Button btnCancel;
        private Button btnUpdate;
        private Panel pnlData;
        private TextBox tbxTour;
        private Label lblTour;
        private TextBox tbxArtist;
        private Label lblArtist;
    }
}