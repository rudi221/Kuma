namespace Kuma.Controls
{
    partial class UcArtistSearch
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
            lblArtistSearch = new Label();
            tbxArtistSearch = new TextBox();
            btnArtistSearch = new Button();
            SuspendLayout();
            // 
            // lblArtistSearch
            // 
            lblArtistSearch.AutoSize = true;
            lblArtistSearch.Location = new Point(21, 20);
            lblArtistSearch.Name = "lblArtistSearch";
            lblArtistSearch.Size = new Size(39, 15);
            lblArtistSearch.TabIndex = 0;
            lblArtistSearch.Text = "Suche";
            // 
            // tbxArtistSearch
            // 
            tbxArtistSearch.Location = new Point(66, 17);
            tbxArtistSearch.Name = "tbxArtistSearch";
            tbxArtistSearch.Size = new Size(161, 23);
            tbxArtistSearch.TabIndex = 1;
            // 
            // btnArtistSearch
            // 
            btnArtistSearch.Location = new Point(233, 16);
            btnArtistSearch.Name = "btnArtistSearch";
            btnArtistSearch.Size = new Size(75, 23);
            btnArtistSearch.TabIndex = 2;
            btnArtistSearch.Text = "Suche";
            btnArtistSearch.UseVisualStyleBackColor = true;
            // 
            // UcArtistSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnArtistSearch);
            Controls.Add(tbxArtistSearch);
            Controls.Add(lblArtistSearch);
            Name = "UcArtistSearch";
            Size = new Size(793, 60);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblArtistSearch;
        private TextBox tbxArtistSearch;
        private Button btnArtistSearch;
    }
}
