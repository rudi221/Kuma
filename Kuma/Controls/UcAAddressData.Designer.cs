namespace Kuma.Controls
{
    partial class UcAAddressData
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
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            lblEmail = new Label();
            tbxFirstname = new TextBox();
            iblName = new Label();
            textBox1 = new TextBox();
            lblCampany = new Label();
            comboBox1 = new ComboBox();
            lblTitel = new Label();
            btnSearch = new Button();
            gbxAddArtisz.SuspendLayout();
            SuspendLayout();
            // 
            // gbxAddArtisz
            // 
            gbxAddArtisz.Controls.Add(btnSearch);
            gbxAddArtisz.Controls.Add(textBox3);
            gbxAddArtisz.Controls.Add(textBox2);
            gbxAddArtisz.Controls.Add(lblEmail);
            gbxAddArtisz.Controls.Add(tbxFirstname);
            gbxAddArtisz.Controls.Add(iblName);
            gbxAddArtisz.Controls.Add(textBox1);
            gbxAddArtisz.Controls.Add(lblCampany);
            gbxAddArtisz.Controls.Add(comboBox1);
            gbxAddArtisz.Controls.Add(lblTitel);
            gbxAddArtisz.Location = new Point(16, 18);
            gbxAddArtisz.Name = "gbxAddArtisz";
            gbxAddArtisz.Size = new Size(756, 153);
            gbxAddArtisz.TabIndex = 0;
            gbxAddArtisz.TabStop = false;
            gbxAddArtisz.Text = "Neuer Kunde";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(209, 90);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(142, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(84, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 23);
            textBox2.TabIndex = 7;
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
            // tbxFirstname
            // 
            tbxFirstname.Location = new Point(84, 89);
            tbxFirstname.Name = "tbxFirstname";
            tbxFirstname.Size = new Size(119, 23);
            tbxFirstname.TabIndex = 5;
            // 
            // iblName
            // 
            iblName.AutoSize = true;
            iblName.Location = new Point(22, 92);
            iblName.Name = "iblName";
            iblName.Size = new Size(37, 15);
            iblName.TabIndex = 4;
            iblName.Text = "Firma";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(84, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 23);
            textBox1.TabIndex = 3;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(84, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(179, 23);
            comboBox1.TabIndex = 1;
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
            // btnSearch
            // 
            btnSearch.Location = new Point(276, 31);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Suche";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // UcAAddressData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbxAddArtisz);
            Name = "UcAAddressData";
            Size = new Size(793, 189);
            gbxAddArtisz.ResumeLayout(false);
            gbxAddArtisz.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxAddArtisz;
        private TextBox tbxFirstname;
        private Label iblName;
        private TextBox textBox1;
        private Label lblCampany;
        private ComboBox comboBox1;
        private Label lblTitel;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label lblEmail;
        private Button btnSearch;
    }
}
