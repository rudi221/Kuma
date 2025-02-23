namespace Kuma.Controls
{
    partial class UcArtistData
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvArtist = new DataGridView();
            panel1 = new Panel();
            btnArtistSearch = new Button();
            tbxArtistSearch = new TextBox();
            lblArtistSearch = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArtist).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ControlLight;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvArtist, 0, 2);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Size = new Size(793, 443);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // dgvArtist
            // 
            dgvArtist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArtist.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvArtist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArtist.Dock = DockStyle.Fill;
            dgvArtist.Location = new Point(3, 86);
            dgvArtist.Name = "dgvArtist";
            dgvArtist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArtist.Size = new Size(787, 354);
            dgvArtist.TabIndex = 2;
            dgvArtist.CellClick += dgvArtist_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btnArtistSearch);
            panel1.Controls.Add(tbxArtistSearch);
            panel1.Controls.Add(lblArtistSearch);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(787, 57);
            panel1.TabIndex = 3;
            // 
            // btnArtistSearch
            // 
            btnArtistSearch.Location = new Point(231, 19);
            btnArtistSearch.Name = "btnArtistSearch";
            btnArtistSearch.Size = new Size(75, 23);
            btnArtistSearch.TabIndex = 5;
            btnArtistSearch.Text = "Suche";
            btnArtistSearch.UseVisualStyleBackColor = true;
            btnArtistSearch.Click += btnArtistSearch_Click;
            // 
            // tbxArtistSearch
            // 
            tbxArtistSearch.Location = new Point(64, 20);
            tbxArtistSearch.Name = "tbxArtistSearch";
            tbxArtistSearch.Size = new Size(161, 23);
            tbxArtistSearch.TabIndex = 4;
            tbxArtistSearch.KeyDown += tbxArtistSearch_KeyDown;
            // 
            // lblArtistSearch
            // 
            lblArtistSearch.AutoSize = true;
            lblArtistSearch.Location = new Point(19, 23);
            lblArtistSearch.Name = "lblArtistSearch";
            lblArtistSearch.Size = new Size(39, 15);
            lblArtistSearch.TabIndex = 3;
            lblArtistSearch.Text = "Suche";
            // 
            // UcArtistData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UcArtistData";
            Size = new Size(793, 443);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvArtist).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvArtist;
        private Panel panel1;
        private Button btnArtistSearch;
        private TextBox tbxArtistSearch;
        private Label lblArtistSearch;
    }
}
