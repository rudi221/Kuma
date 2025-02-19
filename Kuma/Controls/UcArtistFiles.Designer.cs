namespace Kuma.Controls
{
    partial class UcArtistFiles
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
            ltvArtistFiles = new ListView();
            SuspendLayout();
            // 
            // ltvArtistFiles
            // 
            ltvArtistFiles.Dock = DockStyle.Fill;
            ltvArtistFiles.Location = new Point(0, 0);
            ltvArtistFiles.Name = "ltvArtistFiles";
            ltvArtistFiles.Size = new Size(341, 566);
            ltvArtistFiles.TabIndex = 0;
            ltvArtistFiles.UseCompatibleStateImageBehavior = false;
            // 
            // UcArtistFiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ltvArtistFiles);
            Name = "UcArtistFiles";
            Size = new Size(341, 566);
            ResumeLayout(false);
        }

        #endregion

        private ListView ltvArtistFiles;
    }
}
