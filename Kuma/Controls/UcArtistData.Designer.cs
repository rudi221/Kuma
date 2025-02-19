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
            dgvArtist = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvArtist).BeginInit();
            SuspendLayout();
            // 
            // dgvArtist
            // 
            dgvArtist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArtist.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvArtist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArtist.Dock = DockStyle.Fill;
            dgvArtist.Location = new Point(0, 0);
            dgvArtist.Name = "dgvArtist";
            dgvArtist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArtist.Size = new Size(793, 383);
            dgvArtist.TabIndex = 0;
            // 
            // UcArtistData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvArtist);
            Name = "UcArtistData";
            Size = new Size(793, 383);
            ((System.ComponentModel.ISupportInitialize)dgvArtist).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvArtist;
    }
}
