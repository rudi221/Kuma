namespace Kuma.Forms
{
    partial class FrmFtpSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFtpSettings));
            tlpMain = new TableLayoutPanel();
            pnlField = new Panel();
            tbxFolder = new TextBox();
            lblFolder = new Label();
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
            tlpMain.BackColor = SystemColors.ControlLight;
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
            tlpMain.Size = new Size(349, 255);
            tlpMain.TabIndex = 1;
            // 
            // pnlField
            // 
            pnlField.BackColor = SystemColors.Control;
            pnlField.Controls.Add(tbxFolder);
            pnlField.Controls.Add(lblFolder);
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
            pnlField.Size = new Size(319, 168);
            pnlField.TabIndex = 0;
            // 
            // tbxFolder
            // 
            tbxFolder.Location = new Point(108, 114);
            tbxFolder.Name = "tbxFolder";
            tbxFolder.Size = new Size(169, 23);
            tbxFolder.TabIndex = 7;
            // 
            // lblFolder
            // 
            lblFolder.AutoSize = true;
            lblFolder.Location = new Point(33, 117);
            lblFolder.Name = "lblFolder";
            lblFolder.Size = new Size(65, 15);
            lblFolder.TabIndex = 6;
            lblFolder.Text = "Verzeichnis";
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(108, 85);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PasswordChar = '*';
            tbxPassword.Size = new Size(169, 23);
            tbxPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(33, 88);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(54, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Passwort";
            // 
            // tbxUser
            // 
            tbxUser.Location = new Point(108, 56);
            tbxUser.Name = "tbxUser";
            tbxUser.Size = new Size(169, 23);
            tbxUser.TabIndex = 3;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(33, 59);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(53, 15);
            lblUser.TabIndex = 2;
            lblUser.Text = "Benutzer";
            lblUser.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbxServer
            // 
            tbxServer.Location = new Point(108, 27);
            tbxServer.Name = "tbxServer";
            tbxServer.Size = new Size(169, 23);
            tbxServer.TabIndex = 1;
            // 
            // lblServer
            // 
            lblServer.AutoSize = true;
            lblServer.Location = new Point(33, 30);
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
            pnlButtons.Location = new Point(18, 201);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(313, 36);
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
            // FrmFtpSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 255);
            Controls.Add(tlpMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmFtpSettings";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ftp Einstellungen";
            tlpMain.ResumeLayout(false);
            pnlField.ResumeLayout(false);
            pnlField.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Panel pnlField;
        private TextBox tbxFolder;
        private Label lblFolder;
        private TextBox tbxPassword;
        private Label lblPassword;
        private TextBox tbxUser;
        private Label lblUser;
        private TextBox tbxServer;
        private Label lblServer;
        private Panel pnlButtons;
        private Button btnCancel;
        private Button btnUpdate;
    }
}