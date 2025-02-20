using Kuma.Forms;
using Kuma.Services;

namespace Kuma.Controls
{


    public partial class UcAddressData : UserControl
    {

        #region Deklaration
        public string Anrede
        {
            get { return cbxTitel.Text; }
            set { cbxTitel.Text = value; }
        }

        public string Firma
        {
            get { return tbxCompany.Text; }
            set { tbxCompany.Text = value; }
        }

        public string Vorname
        {
            get { return tbxFirstName.Text; }
            set { tbxFirstName.Text = value; }
        }

        public string Nachname
        {
            get { return tbxLastName.Text; }
            set { tbxLastName.Text = value; }
        }

        public string Email
        {
            get { return tbxEmail.Text; }
            set { tbxEmail.Text = value; }
        }
        #endregion

        #region Konstruktor



        public UcAddressData()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers for Buttons
        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmCustomer frmCustomer = new FrmCustomer();
            frmCustomer.AddressSelected += frmCustomer_AddressSelected;
            frmCustomer.ShowDialog();
        }

        #endregion

        #region Methoden

        private void frmCustomer_AddressSelected(object sender, AddressSelectedEventArgs e)
        {
            this.Anrede = e.Adresse.Anrede;
            this.Firma = e.Adresse.Firma;
            this.Vorname = e.Adresse.Vorname;
            this.Nachname = e.Adresse.Nachname;
            this.Email = e.Adresse.Email;
        }


    }
    #endregion

}


