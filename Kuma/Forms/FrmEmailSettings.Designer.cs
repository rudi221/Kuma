namespace Kuma.Forms
{
    partial class FrmEmailSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmailSettings));
            tlpMain = new TableLayoutPanel();
            pnlField = new Panel();
            txbPort = new TextBox();
            label2 = new Label();
            txbEmail = new TextBox();
            label1 = new Label();
            txbDomain = new TextBox();
            lblDomain = new Label();
            txbPassword = new TextBox();
            lblPassword = new Label();
            txbUser = new TextBox();
            lblUser = new Label();
            txbServer = new TextBox();
            lblServer = new Label();
            pnlButtons = new Panel();
            btnCancel = new Button();
            btnUpdate = new Button();
            errorProvider1 = new ErrorProvider(components);
            tlpMain.SuspendLayout();
            pnlField.SuspendLayout();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 3;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            tlpMain.Controls.Add(pnlField, 1, 1);
            tlpMain.Controls.Add(pnlButtons, 1, 3);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 5;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpMain.Size = new Size(348, 302);
            tlpMain.TabIndex = 0;
            // 
            // pnlField
            // 
            pnlField.BackColor = SystemColors.Control;
            pnlField.Controls.Add(txbPort);
            pnlField.Controls.Add(label2);
            pnlField.Controls.Add(txbEmail);
            pnlField.Controls.Add(label1);
            pnlField.Controls.Add(txbDomain);
            pnlField.Controls.Add(lblDomain);
            pnlField.Controls.Add(txbPassword);
            pnlField.Controls.Add(lblPassword);
            pnlField.Controls.Add(txbUser);
            pnlField.Controls.Add(lblUser);
            pnlField.Controls.Add(txbServer);
            pnlField.Controls.Add(lblServer);
            pnlField.Dock = DockStyle.Fill;
            pnlField.Location = new Point(15, 15);
            pnlField.Margin = new Padding(0);
            pnlField.Name = "pnlField";
            pnlField.Size = new Size(318, 205);
            pnlField.TabIndex = 0;
            // 
            // txbPort
            // 
            txbPort.Location = new Point(99, 48);
            txbPort.Name = "txbPort";
            txbPort.Size = new Size(169, 23);
            txbPort.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 51);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 10;
            label2.Text = "Port";
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(101, 168);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(167, 23);
            txbEmail.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 167);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 8;
            label1.Text = "Email";
            // 
            // txbDomain
            // 
            txbDomain.Location = new Point(101, 137);
            txbDomain.Name = "txbDomain";
            txbDomain.Size = new Size(167, 23);
            txbDomain.TabIndex = 7;
            // 
            // lblDomain
            // 
            lblDomain.AutoSize = true;
            lblDomain.Location = new Point(40, 136);
            lblDomain.Name = "lblDomain";
            lblDomain.Size = new Size(49, 15);
            lblDomain.TabIndex = 6;
            lblDomain.Text = "Domain";
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(99, 106);
            txbPassword.Name = "txbPassword";
            txbPassword.PasswordChar = '*';
            txbPassword.Size = new Size(169, 23);
            txbPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(40, 105);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(54, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Passwort";
            // 
            // txbUser
            // 
            txbUser.Location = new Point(99, 77);
            txbUser.Name = "txbUser";
            txbUser.Size = new Size(169, 23);
            txbUser.TabIndex = 3;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(40, 76);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(53, 15);
            lblUser.TabIndex = 2;
            lblUser.Text = "Benutzer";
            lblUser.TextAlign = ContentAlignment.TopCenter;
            // 
            // txbServer
            // 
            txbServer.Location = new Point(99, 19);
            txbServer.Name = "txbServer";
            txbServer.Size = new Size(169, 23);
            txbServer.TabIndex = 1;
            // 
            // lblServer
            // 
            lblServer.AutoSize = true;
            lblServer.Location = new Point(40, 22);
            lblServer.Name = "lblServer";
            lblServer.Size = new Size(39, 15);
            lblServer.TabIndex = 0;
            lblServer.Text = "Server";
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = SystemColors.Control;
            pnlButtons.Controls.Add(btnCancel);
            pnlButtons.Controls.Add(btnUpdate);
            pnlButtons.Dock = DockStyle.Fill;
            pnlButtons.Location = new Point(18, 238);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(312, 45);
            pnlButtons.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(134, 10);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Abbrechen";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(215, 11);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(85, 23);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Übernehmen";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmEmailSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(348, 302);
            Controls.Add(tlpMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmEmailSettings";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Email Einstellungen";
            Load += FrmEmailSettings_Load;
            tlpMain.ResumeLayout(false);
            pnlField.ResumeLayout(false);
            pnlField.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Panel pnlField;
        private Panel pnlButtons;
        private Label lblServer;
        private TextBox txbPassword;
        private Label lblPassword;
        private TextBox txbUser;
        private Label lblUser;
        private TextBox txbServer;
        private Button btnCancel;
        private Button btnUpdate;
        private ErrorProvider errorProvider1;
        private TextBox txbDomain;
        private Label lblDomain;
        private TextBox txbEmail;
        private Label label1;
        private TextBox txbPort;
        private Label label2;
    }
}