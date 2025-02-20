namespace Kuma.Forms
{
    partial class FrmCustomer
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomer));
            tlpMain = new TableLayoutPanel();
            plAddress = new Panel();
            btnAddCustomer = new Button();
            btnUpdateCustomer = new Button();
            tbMail = new TextBox();
            lbMail = new Label();
            tbLastName = new TextBox();
            tbFirstName = new TextBox();
            lbName = new Label();
            tbCompany = new TextBox();
            lbCompany = new Label();
            cbTitel = new ComboBox();
            lbTitel = new Label();
            plSearch = new Panel();
            btnSearch = new Button();
            tbSearch = new TextBox();
            lbSearch = new Label();
            dgvCustomer = new DataGridView();
            panel1 = new Panel();
            btnDeleteCustomer = new Button();
            btnNewCustomer = new Button();
            btnUpdatePerson = new Button();
            errorProvider1 = new ErrorProvider(components);
            tlpMain.SuspendLayout();
            plAddress.SuspendLayout();
            plSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.BackColor = SystemColors.ControlLight;
            tlpMain.ColumnCount = 3;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpMain.Controls.Add(plAddress, 1, 1);
            tlpMain.Controls.Add(plSearch, 1, 3);
            tlpMain.Controls.Add(dgvCustomer, 1, 5);
            tlpMain.Controls.Add(panel1, 1, 7);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Margin = new Padding(3, 2, 3, 2);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 9;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 34.48512F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.630537F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 43.524456F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.3598814F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpMain.Size = new Size(859, 565);
            tlpMain.TabIndex = 4;
            // 
            // plAddress
            // 
            plAddress.BackColor = SystemColors.Control;
            plAddress.Controls.Add(btnAddCustomer);
            plAddress.Controls.Add(btnUpdateCustomer);
            plAddress.Controls.Add(tbMail);
            plAddress.Controls.Add(lbMail);
            plAddress.Controls.Add(tbLastName);
            plAddress.Controls.Add(tbFirstName);
            plAddress.Controls.Add(lbName);
            plAddress.Controls.Add(tbCompany);
            plAddress.Controls.Add(lbCompany);
            plAddress.Controls.Add(cbTitel);
            plAddress.Controls.Add(lbTitel);
            plAddress.Dock = DockStyle.Fill;
            plAddress.Location = new Point(18, 17);
            plAddress.Margin = new Padding(3, 2, 3, 2);
            plAddress.Name = "plAddress";
            plAddress.Size = new Size(823, 164);
            plAddress.TabIndex = 0;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(298, 138);
            btnAddCustomer.Margin = new Padding(3, 2, 3, 2);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(109, 22);
            btnAddCustomer.TabIndex = 10;
            btnAddCustomer.Text = "Kunde einfügen";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnUpdateCustomer
            // 
            btnUpdateCustomer.Location = new Point(129, 138);
            btnUpdateCustomer.Margin = new Padding(3, 2, 3, 2);
            btnUpdateCustomer.Name = "btnUpdateCustomer";
            btnUpdateCustomer.Size = new Size(98, 22);
            btnUpdateCustomer.TabIndex = 9;
            btnUpdateCustomer.Text = "Kunde ändern";
            btnUpdateCustomer.UseVisualStyleBackColor = true;
            btnUpdateCustomer.Click += btnUpdateCustomer_Click;
            // 
            // tbMail
            // 
            tbMail.Location = new Point(130, 109);
            tbMail.Margin = new Padding(3, 2, 3, 2);
            tbMail.Name = "tbMail";
            tbMail.Size = new Size(278, 23);
            tbMail.TabIndex = 8;
            // 
            // lbMail
            // 
            lbMail.AutoSize = true;
            lbMail.Location = new Point(21, 111);
            lbMail.Name = "lbMail";
            lbMail.Size = new Size(41, 15);
            lbMail.TabIndex = 7;
            lbMail.Text = "E-Mail";
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(275, 76);
            tbLastName.Margin = new Padding(3, 2, 3, 2);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(133, 23);
            tbLastName.TabIndex = 6;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(130, 76);
            tbFirstName.Margin = new Padding(3, 2, 3, 2);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(133, 23);
            tbFirstName.TabIndex = 5;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(21, 79);
            lbName.Name = "lbName";
            lbName.Size = new Size(95, 15);
            lbName.TabIndex = 4;
            lbName.Text = "Ansprechpartner";
            // 
            // tbCompany
            // 
            tbCompany.Location = new Point(130, 46);
            tbCompany.Margin = new Padding(3, 2, 3, 2);
            tbCompany.Name = "tbCompany";
            tbCompany.Size = new Size(278, 23);
            tbCompany.TabIndex = 3;
            // 
            // lbCompany
            // 
            lbCompany.AutoSize = true;
            lbCompany.Location = new Point(21, 48);
            lbCompany.Name = "lbCompany";
            lbCompany.Size = new Size(37, 15);
            lbCompany.TabIndex = 2;
            lbCompany.Text = "Firma";
            // 
            // cbTitel
            // 
            cbTitel.FormattingEnabled = true;
            cbTitel.Items.AddRange(new object[] { "Herr", "Frau" });
            cbTitel.Location = new Point(130, 16);
            cbTitel.Margin = new Padding(3, 2, 3, 2);
            cbTitel.Name = "cbTitel";
            cbTitel.Size = new Size(133, 23);
            cbTitel.TabIndex = 1;
            // 
            // lbTitel
            // 
            lbTitel.AutoSize = true;
            lbTitel.Location = new Point(21, 16);
            lbTitel.Name = "lbTitel";
            lbTitel.Size = new Size(45, 15);
            lbTitel.TabIndex = 0;
            lbTitel.Text = "Anrede";
            // 
            // plSearch
            // 
            plSearch.BackColor = SystemColors.Control;
            plSearch.Controls.Add(btnSearch);
            plSearch.Controls.Add(tbSearch);
            plSearch.Controls.Add(lbSearch);
            plSearch.Dock = DockStyle.Fill;
            plSearch.Location = new Point(18, 200);
            plSearch.Margin = new Padding(3, 2, 3, 2);
            plSearch.Name = "plSearch";
            plSearch.Size = new Size(823, 48);
            plSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(325, 15);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 22);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Suche";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(129, 15);
            tbSearch.Margin = new Padding(3, 2, 3, 2);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(191, 23);
            tbSearch.TabIndex = 9;
            tbSearch.KeyDown += tbSearch_KeyDown;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(21, 18);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(39, 15);
            lbSearch.TabIndex = 8;
            lbSearch.Text = "Suche";
            // 
            // dgvCustomer
            // 
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Dock = DockStyle.Fill;
            dgvCustomer.Location = new Point(18, 267);
            dgvCustomer.Margin = new Padding(3, 2, 3, 2);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomer.Size = new Size(823, 209);
            dgvCustomer.TabIndex = 2;
            dgvCustomer.SelectionChanged += dgvCustomer_SelectionChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btnDeleteCustomer);
            panel1.Controls.Add(btnNewCustomer);
            panel1.Controls.Add(btnUpdatePerson);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(18, 496);
            panel1.Name = "panel1";
            panel1.Size = new Size(823, 49);
            panel1.TabIndex = 3;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Location = new Point(125, 15);
            btnDeleteCustomer.Margin = new Padding(3, 2, 3, 2);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(102, 22);
            btnDeleteCustomer.TabIndex = 4;
            btnDeleteCustomer.Text = "Kunde löschen";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // btnNewCustomer
            // 
            btnNewCustomer.Location = new Point(9, 15);
            btnNewCustomer.Margin = new Padding(3, 2, 3, 2);
            btnNewCustomer.Name = "btnNewCustomer";
            btnNewCustomer.Size = new Size(102, 22);
            btnNewCustomer.TabIndex = 3;
            btnNewCustomer.Text = "Neuer Kunde";
            btnNewCustomer.UseVisualStyleBackColor = true;
            btnNewCustomer.Click += btnNewCustomer_Click;
            // 
            // btnUpdatePerson
            // 
            btnUpdatePerson.Location = new Point(711, 15);
            btnUpdatePerson.Margin = new Padding(3, 2, 3, 2);
            btnUpdatePerson.Name = "btnUpdatePerson";
            btnUpdatePerson.Size = new Size(87, 22);
            btnUpdatePerson.TabIndex = 2;
            btnUpdatePerson.Text = "Übernehmen";
            btnUpdatePerson.UseVisualStyleBackColor = true;
            btnUpdatePerson.Click += btnUpdatePerson_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 565);
            Controls.Add(tlpMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCustomer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kunden Übersicht";
            tlpMain.ResumeLayout(false);
            plAddress.ResumeLayout(false);
            plAddress.PerformLayout();
            plSearch.ResumeLayout(false);
            plSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Panel plAddress;
        private Button btnAddCustomer;
        private Button btnUpdateCustomer;
        private TextBox tbMail;
        private Label lbMail;
        private TextBox tbLastName;
        private TextBox tbFirstName;
        private Label lbName;
        private TextBox tbCompany;
        private Label lbCompany;
        private ComboBox cbTitel;
        private Label lbTitel;
        private Panel plSearch;
        private Button btnSearch;
        private TextBox tbSearch;
        private Label lbSearch;
        private DataGridView dgvCustomer;
        private Panel panel1;
        private Button btnDeleteCustomer;
        private Button btnNewCustomer;
        private Button btnUpdatePerson;
        private ErrorProvider errorProvider1;
    }
}