namespace Kuma.Controls
{
    partial class UcAddressData
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
            gbxAddArtisz = new GroupBox();
            btnSearch = new Button();
            tbxLastName = new TextBox();
            tbxEmail = new TextBox();
            lblEmail = new Label();
            tbxFirstName = new TextBox();
            iblName = new Label();
            tbxCompany = new TextBox();
            lblCampany = new Label();
            cbxTitel = new ComboBox();
            lblTitel = new Label();
            gbxAddArtisz.SuspendLayout();
            SuspendLayout();
            // 
            // gbxAddArtisz
            // 
            gbxAddArtisz.Controls.Add(btnSearch);
            gbxAddArtisz.Controls.Add(tbxLastName);
            gbxAddArtisz.Controls.Add(tbxEmail);
            gbxAddArtisz.Controls.Add(lblEmail);
            gbxAddArtisz.Controls.Add(tbxFirstName);
            gbxAddArtisz.Controls.Add(iblName);
            gbxAddArtisz.Controls.Add(tbxCompany);
            gbxAddArtisz.Controls.Add(lblCampany);
            gbxAddArtisz.Controls.Add(cbxTitel);
            gbxAddArtisz.Controls.Add(lblTitel);
            gbxAddArtisz.Location = new Point(16, 18);
            gbxAddArtisz.Name = "gbxAddArtisz";
            gbxAddArtisz.Size = new Size(756, 153);
            gbxAddArtisz.TabIndex = 0;
            gbxAddArtisz.TabStop = false;
            gbxAddArtisz.Text = "Neuer Kunde";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(276, 31);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Suche";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbxLastName
            // 
            tbxLastName.Location = new Point(209, 90);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.Size = new Size(142, 23);
            tbxLastName.TabIndex = 8;
            // 
            // tbxEmail
            // 
            tbxEmail.BackColor = SystemColors.Window;
            tbxEmail.Location = new Point(84, 118);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(267, 23);
            tbxEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(22, 121);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "E-Mail";
            // 
            // tbxFirstName
            // 
            tbxFirstName.Location = new Point(84, 89);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.Size = new Size(119, 23);
            tbxFirstName.TabIndex = 5;
            // 
            // iblName
            // 
            iblName.AutoSize = true;
            iblName.Location = new Point(22, 92);
            iblName.Name = "iblName";
            iblName.Size = new Size(39, 15);
            iblName.TabIndex = 4;
            iblName.Text = "Name";
            // 
            // tbxCompany
            // 
            tbxCompany.Location = new Point(84, 60);
            tbxCompany.Name = "tbxCompany";
            tbxCompany.Size = new Size(267, 23);
            tbxCompany.TabIndex = 3;
            // 
            // lblCampany
            // 
            lblCampany.AutoSize = true;
            lblCampany.Location = new Point(22, 63);
            lblCampany.Name = "lblCampany";
            lblCampany.Size = new Size(37, 15);
            lblCampany.TabIndex = 2;
            lblCampany.Text = "Firma";
            // 
            // cbxTitel
            // 
            cbxTitel.FormattingEnabled = true;
            cbxTitel.Location = new Point(84, 31);
            cbxTitel.Name = "cbxTitel";
            cbxTitel.Size = new Size(179, 23);
            cbxTitel.TabIndex = 1;
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Location = new Point(22, 34);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(45, 15);
            lblTitel.TabIndex = 0;
            lblTitel.Text = "Anrede";
            // 
            // UcAddressData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbxAddArtisz);
            Name = "UcAddressData";
            Size = new Size(793, 189);
            gbxAddArtisz.ResumeLayout(false);
            gbxAddArtisz.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxAddArtisz;
        private TextBox tbxFirstName;
        private Label iblName;
        private TextBox tbxCompany;
        private Label lblCampany;
        private ComboBox cbxTitel;
        private Label lblTitel;
        private TextBox tbxLastName;
        private TextBox tbxEmail;
        private Label lblEmail;
        private Button btnSearch;
    }
}
