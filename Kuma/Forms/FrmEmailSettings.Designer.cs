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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmailSettings));
            tlpMain = new TableLayoutPanel();
            pnlField = new Panel();
            tbxPassword = new TextBox();
            lblPassword = new Label();
            tbxUser = new TextBox();
            lblUser = new Label();
            tbxServer = new TextBox();
            lblServer = new Label();
            pnlButtons = new Panel();
            btnCancel = new Button();
            btnUpdate = new Button();
            tlpMain.SuspendLayout();
            pnlField.SuspendLayout();
            pnlButtons.SuspendLayout();
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
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlpMain.Size = new Size(348, 214);
            tlpMain.TabIndex = 0;
            // 
            // pnlField
            // 
            pnlField.BackColor = SystemColors.Control;
            pnlField.Controls.Add(tbxPassword);
            pnlField.Controls.Add(lblPassword);
            pnlField.Controls.Add(tbxUser);
            pnlField.Controls.Add(lblUser);
            pnlField.Controls.Add(tbxServer);
            pnlField.Controls.Add(lblServer);
            pnlField.Dock = DockStyle.Fill;
            pnlField.Location = new Point(15, 15);
            pnlField.Margin = new Padding(0);
            pnlField.Name = "pnlField";
            pnlField.Size = new Size(318, 126);
            pnlField.TabIndex = 0;
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(99, 77);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PasswordChar = '*';
            tbxPassword.Size = new Size(169, 23);
            tbxPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(40, 80);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(54, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Passwort";
            // 
            // tbxUser
            // 
            tbxUser.Location = new Point(99, 48);
            tbxUser.Name = "tbxUser";
            tbxUser.Size = new Size(169, 23);
            tbxUser.TabIndex = 3;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(40, 51);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(53, 15);
            lblUser.TabIndex = 2;
            lblUser.Text = "Benutzer";
            lblUser.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbxServer
            // 
            tbxServer.Location = new Point(99, 19);
            tbxServer.Name = "tbxServer";
            tbxServer.Size = new Size(169, 23);
            tbxServer.TabIndex = 1;
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
            pnlButtons.Location = new Point(18, 159);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(312, 36);
            pnlButtons.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(134, 7);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Abbrechen";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(215, 7);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(85, 23);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Übernehmen";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // FrmEmailSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(348, 214);
            Controls.Add(tlpMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmEmailSettings";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Email Einstellungen";
            tlpMain.ResumeLayout(false);
            pnlField.ResumeLayout(false);
            pnlField.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Panel pnlField;
        private Panel pnlButtons;
        private Label lblServer;
        private TextBox tbxPassword;
        private Label lblPassword;
        private TextBox tbxUser;
        private Label lblUser;
        private TextBox tbxServer;
        private Button btnCancel;
        private Button btnUpdate;
    }
}