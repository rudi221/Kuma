namespace Kuma.Controls
{
    partial class UcMenu
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
            btnAddArtist = new Button();
            btnDeleteArtist = new Button();
            btnSendData = new Button();
            btnDeleteArtistFile = new Button();
            btnAddArtistFile = new Button();
            SuspendLayout();
            // 
            // btnAddArtist
            // 
            btnAddArtist.Image = Properties.Resources.User58;
            btnAddArtist.Location = new Point(13, 13);
            btnAddArtist.Name = "btnAddArtist";
            btnAddArtist.Size = new Size(85, 85);
            btnAddArtist.TabIndex = 0;
            btnAddArtist.Text = "Neu";
            btnAddArtist.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAddArtist.UseVisualStyleBackColor = true;
            btnAddArtist.Click += btnAddArtist_Click;
            // 
            // btnDeleteArtist
            // 
            btnDeleteArtist.Image = Properties.Resources.userDelete58;
            btnDeleteArtist.Location = new Point(109, 13);
            btnDeleteArtist.Name = "btnDeleteArtist";
            btnDeleteArtist.Size = new Size(85, 85);
            btnDeleteArtist.TabIndex = 1;
            btnDeleteArtist.Text = "Löschen";
            btnDeleteArtist.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDeleteArtist.UseVisualStyleBackColor = true;
            btnDeleteArtist.Click += btnDeleteArtist_Click;
            // 
            // btnSendData
            // 
            btnSendData.Image = Properties.Resources.Mail58;
            btnSendData.Location = new Point(1055, 13);
            btnSendData.Name = "btnSendData";
            btnSendData.Size = new Size(85, 85);
            btnSendData.TabIndex = 2;
            btnSendData.Text = "Versenden";
            btnSendData.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSendData.UseVisualStyleBackColor = true;
            // 
            // btnDeleteArtistFile
            // 
            btnDeleteArtistFile.Image = Properties.Resources.FolderDelete58;
            btnDeleteArtistFile.Location = new Point(959, 13);
            btnDeleteArtistFile.Name = "btnDeleteArtistFile";
            btnDeleteArtistFile.Size = new Size(85, 85);
            btnDeleteArtistFile.TabIndex = 3;
            btnDeleteArtistFile.Text = "Löschen";
            btnDeleteArtistFile.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDeleteArtistFile.UseVisualStyleBackColor = true;
            btnDeleteArtistFile.Click += btnDeleteArtistFile_Click;
            // 
            // btnAddArtistFile
            // 
            btnAddArtistFile.Image = Properties.Resources.FolderAdd58;
            btnAddArtistFile.Location = new Point(861, 13);
            btnAddArtistFile.Name = "btnAddArtistFile";
            btnAddArtistFile.Size = new Size(85, 85);
            btnAddArtistFile.TabIndex = 4;
            btnAddArtistFile.Text = "Neu";
            btnAddArtistFile.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAddArtistFile.UseVisualStyleBackColor = true;
            btnAddArtistFile.Click += btnAddArtistFile_Click;
            // 
            // UcMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(btnAddArtistFile);
            Controls.Add(btnDeleteArtistFile);
            Controls.Add(btnSendData);
            Controls.Add(btnDeleteArtist);
            Controls.Add(btnAddArtist);
            Name = "UcMenu";
            Size = new Size(1154, 113);
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddArtist;
        private Button btnDeleteArtist;
        private Button btnSendData;
        private Button btnDeleteArtistFile;
        private Button btnAddArtistFile;
    }
}
