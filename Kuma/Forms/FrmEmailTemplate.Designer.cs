namespace Kuma.Forms
{
    partial class FrmEmailTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmailTemplate));
            tlpMain = new TableLayoutPanel();
            pnlText = new Panel();
            tbxEmailText = new TextBox();
            pnlButton = new Panel();
            btnClose = new Button();
            btnUpdate = new Button();
            tlpMain.SuspendLayout();
            pnlText.SuspendLayout();
            pnlButton.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.BackColor = SystemColors.ControlLight;
            tlpMain.ColumnCount = 3;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpMain.Controls.Add(pnlText, 1, 1);
            tlpMain.Controls.Add(pnlButton, 1, 3);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 5;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.Size = new Size(800, 450);
            tlpMain.TabIndex = 0;
            // 
            // pnlText
            // 
            pnlText.BackColor = SystemColors.Control;
            pnlText.Controls.Add(tbxEmailText);
            pnlText.Dock = DockStyle.Fill;
            pnlText.Location = new Point(23, 23);
            pnlText.Name = "pnlText";
            pnlText.Size = new Size(754, 325);
            pnlText.TabIndex = 0;
            // 
            // tbxEmailText
            // 
            tbxEmailText.Dock = DockStyle.Fill;
            tbxEmailText.Location = new Point(0, 0);
            tbxEmailText.Multiline = true;
            tbxEmailText.Name = "tbxEmailText";
            tbxEmailText.Size = new Size(754, 325);
            tbxEmailText.TabIndex = 0;
            // 
            // pnlButton
            // 
            pnlButton.BackColor = SystemColors.Control;
            pnlButton.Controls.Add(btnClose);
            pnlButton.Controls.Add(btnUpdate);
            pnlButton.Dock = DockStyle.Fill;
            pnlButton.Location = new Point(23, 374);
            pnlButton.Name = "pnlButton";
            pnlButton.Size = new Size(754, 52);
            pnlButton.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(555, 16);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 1;
            btnClose.Text = "Abbrechen";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(637, 16);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 23);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Übernehmen";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // FrmEmailTemplate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tlpMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmEmailTemplate";
            StartPosition = FormStartPosition.CenterParent;
            Text = "E-Mail Template";
            tlpMain.ResumeLayout(false);
            pnlText.ResumeLayout(false);
            pnlText.PerformLayout();
            pnlButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Panel pnlText;
        private Panel pnlButton;
        private Button btnClose;
        private Button btnUpdate;
        private TextBox tbxEmailText;
    }
}