namespace Kuma.Forms
{
    partial class FrmSendData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSendData));
            tlpMain = new TableLayoutPanel();
            bnlButtons = new Panel();
            btnSendData = new Button();
            pnlStatus = new Label();
            btnCancel = new Button();
            progressBar1 = new ProgressBar();
            pnlArtist = new Panel();
            lblCustomerName = new Label();
            lblArtisttour = new Label();
            lblArtistName = new Label();
            lblCustomer = new Label();
            lblTour = new Label();
            lblArtist = new Label();
            pnlMessage = new Panel();
            lblMessage = new Label();
            txbMessageContent = new TextBox();
            txbCc = new TextBox();
            lblEmail = new Label();
            tlpMain.SuspendLayout();
            bnlButtons.SuspendLayout();
            pnlArtist.SuspendLayout();
            pnlMessage.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 3;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpMain.Controls.Add(bnlButtons, 1, 5);
            tlpMain.Controls.Add(pnlArtist, 1, 1);
            tlpMain.Controls.Add(pnlMessage, 1, 3);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 6;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.Size = new Size(800, 430);
            tlpMain.TabIndex = 0;
            // 
            // bnlButtons
            // 
            bnlButtons.BackColor = SystemColors.Control;
            bnlButtons.Controls.Add(btnSendData);
            bnlButtons.Controls.Add(pnlStatus);
            bnlButtons.Controls.Add(btnCancel);
            bnlButtons.Controls.Add(progressBar1);
            bnlButtons.Dock = DockStyle.Fill;
            bnlButtons.Location = new Point(23, 377);
            bnlButtons.Name = "bnlButtons";
            bnlButtons.Size = new Size(754, 50);
            bnlButtons.TabIndex = 0;
            // 
            // btnSendData
            // 
            btnSendData.Location = new Point(650, 16);
            btnSendData.Name = "btnSendData";
            btnSendData.Size = new Size(75, 23);
            btnSendData.TabIndex = 2;
            btnSendData.Text = "Versenden";
            btnSendData.UseVisualStyleBackColor = true;
            btnSendData.Click += btnSendData_Click;
            // 
            // pnlStatus
            // 
            pnlStatus.AutoSize = true;
            pnlStatus.Location = new Point(372, 20);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Size = new Size(35, 15);
            pnlStatus.TabIndex = 1;
            pnlStatus.Text = "Staus";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(556, 16);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Abbrechen";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(19, 16);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(329, 23);
            progressBar1.TabIndex = 0;
            // 
            // pnlArtist
            // 
            pnlArtist.BackColor = SystemColors.Control;
            pnlArtist.Controls.Add(lblCustomerName);
            pnlArtist.Controls.Add(lblArtisttour);
            pnlArtist.Controls.Add(lblArtistName);
            pnlArtist.Controls.Add(lblCustomer);
            pnlArtist.Controls.Add(lblTour);
            pnlArtist.Controls.Add(lblArtist);
            pnlArtist.Dock = DockStyle.Fill;
            pnlArtist.Location = new Point(23, 23);
            pnlArtist.Name = "pnlArtist";
            pnlArtist.Size = new Size(754, 49);
            pnlArtist.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(532, 14);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(0, 15);
            lblCustomerName.TabIndex = 5;
            // 
            // lblArtisttour
            // 
            lblArtisttour.AutoSize = true;
            lblArtisttour.Location = new Point(320, 18);
            lblArtisttour.Name = "lblArtisttour";
            lblArtisttour.Size = new Size(0, 15);
            lblArtisttour.TabIndex = 4;
            // 
            // lblArtistName
            // 
            lblArtistName.AutoSize = true;
            lblArtistName.Location = new Point(75, 17);
            lblArtistName.Name = "lblArtistName";
            lblArtistName.Size = new Size(0, 15);
            lblArtistName.TabIndex = 3;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomer.Location = new Point(484, 17);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(43, 15);
            lblCustomer.TabIndex = 2;
            lblCustomer.Text = "Kunde";
            // 
            // lblTour
            // 
            lblTour.AutoSize = true;
            lblTour.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTour.Location = new Point(285, 17);
            lblTour.Name = "lblTour";
            lblTour.Size = new Size(32, 15);
            lblTour.TabIndex = 1;
            lblTour.Text = "Tour";
            // 
            // lblArtist
            // 
            lblArtist.AutoSize = true;
            lblArtist.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArtist.Location = new Point(19, 17);
            lblArtist.Name = "lblArtist";
            lblArtist.Size = new Size(54, 15);
            lblArtist.TabIndex = 0;
            lblArtist.Text = "Künstler";
            // 
            // pnlMessage
            // 
            pnlMessage.BackColor = SystemColors.Control;
            pnlMessage.Controls.Add(lblMessage);
            pnlMessage.Controls.Add(txbMessageContent);
            pnlMessage.Controls.Add(txbCc);
            pnlMessage.Controls.Add(lblEmail);
            pnlMessage.Dock = DockStyle.Fill;
            pnlMessage.Location = new Point(23, 98);
            pnlMessage.Name = "pnlMessage";
            pnlMessage.Size = new Size(754, 253);
            pnlMessage.TabIndex = 2;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(71, 47);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(59, 15);
            lblMessage.TabIndex = 3;
            lblMessage.Text = "Nachricht";
            // 
            // txbMessageContent
            // 
            txbMessageContent.Location = new Point(230, 47);
            txbMessageContent.Multiline = true;
            txbMessageContent.Name = "txbMessageContent";
            txbMessageContent.Size = new Size(459, 182);
            txbMessageContent.TabIndex = 2;
            // 
            // txbCc
            // 
            txbCc.Location = new Point(228, 14);
            txbCc.Name = "txbCc";
            txbCc.Size = new Size(459, 23);
            txbCc.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(71, 17);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(145, 15);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "zusätzliche E-Mail Adresse";
            // 
            // FrmSendData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 430);
            Controls.Add(tlpMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmSendData";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Daten Senden";
            tlpMain.ResumeLayout(false);
            bnlButtons.ResumeLayout(false);
            bnlButtons.PerformLayout();
            pnlArtist.ResumeLayout(false);
            pnlArtist.PerformLayout();
            pnlMessage.ResumeLayout(false);
            pnlMessage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private Panel bnlButtons;
        private Button btnCancel;
        private Panel pnlMessage;
        private TextBox txbMessageContent;
        private TextBox txbCc;
        private Label lblEmail;
        private Label pnlStatus;
        private ProgressBar progressBar1;
        private Panel pnlArtist;
        private Label lblCustomer;
        private Label lblTour;
        private Label lblArtist;
        private Label lblMessage;
        private Button btnSendData;
        private Label lblCustomerName;
        private Label lblArtisttour;
        private Label lblArtistName;
    }
}