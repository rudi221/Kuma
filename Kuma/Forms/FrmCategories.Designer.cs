namespace Kuma.Forms
{
    partial class FrmCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategories));
            tlpMain = new TableLayoutPanel();
            pnlSearch = new Panel();
            pnlData = new Panel();
            pnlButtons = new Panel();
            lblCategory = new Label();
            txbCategry = new TextBox();
            button1 = new Button();
            dgvCategories = new DataGridView();
            btnUpdate = new Button();
            btnDeleteCategory = new Button();
            tlpMain.SuspendLayout();
            pnlSearch.SuspendLayout();
            pnlData.SuspendLayout();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.BackColor = SystemColors.ControlLight;
            tlpMain.ColumnCount = 3;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpMain.Controls.Add(pnlSearch, 1, 1);
            tlpMain.Controls.Add(pnlData, 1, 3);
            tlpMain.Controls.Add(pnlButtons, 1, 5);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 7;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 19.35484F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 64.51613F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.1290321F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.Size = new Size(746, 299);
            tlpMain.TabIndex = 0;
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = SystemColors.Control;
            pnlSearch.Controls.Add(button1);
            pnlSearch.Controls.Add(txbCategry);
            pnlSearch.Controls.Add(lblCategory);
            pnlSearch.Dock = DockStyle.Fill;
            pnlSearch.Location = new Point(15, 15);
            pnlSearch.Margin = new Padding(0);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(716, 44);
            pnlSearch.TabIndex = 0;
            // 
            // pnlData
            // 
            pnlData.BackColor = SystemColors.Control;
            pnlData.Controls.Add(dgvCategories);
            pnlData.Dock = DockStyle.Fill;
            pnlData.Location = new Point(18, 77);
            pnlData.Name = "pnlData";
            pnlData.Size = new Size(710, 141);
            pnlData.TabIndex = 1;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = SystemColors.Control;
            pnlButtons.Controls.Add(btnDeleteCategory);
            pnlButtons.Controls.Add(btnUpdate);
            pnlButtons.Dock = DockStyle.Fill;
            pnlButtons.Location = new Point(15, 241);
            pnlButtons.Margin = new Padding(0);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(716, 36);
            pnlButtons.TabIndex = 2;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(27, 14);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(57, 15);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Kategorie";
            // 
            // txbCategry
            // 
            txbCategry.Location = new Point(99, 11);
            txbCategry.Name = "txbCategry";
            txbCategry.Size = new Size(139, 23);
            txbCategry.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(250, 11);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Einfügen";
            button1.UseVisualStyleBackColor = true;
            // 
            // dgvCategories
            // 
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Dock = DockStyle.Fill;
            dgvCategories.Location = new Point(0, 0);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.Size = new Size(710, 141);
            dgvCategories.TabIndex = 0;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(617, 6);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(87, 23);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Übernehmen";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(27, 7);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(123, 23);
            btnDeleteCategory.TabIndex = 1;
            btnDeleteCategory.Text = "Kategorie löschen";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // FrmCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 299);
            Controls.Add(tlpMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCategories";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kategorie Liste";
            tlpMain.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            pnlData.ResumeLayout(false);
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Panel pnlSearch;
        private Panel pnlData;
        private Panel pnlButtons;
        private Button button1;
        private TextBox txbCategry;
        private Label lblCategory;
        private DataGridView dgvCategories;
        private Button btnDeleteCategory;
        private Button btnUpdate;
    }
}