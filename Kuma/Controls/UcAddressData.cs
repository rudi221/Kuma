using Kuma.Forms;
using Kuma.Models;
using Kuma.Services;

namespace Kuma.Controls
{


    public partial class UcAddressData : UserControl
    {

        #region Deklaration

        private int filladress = 0;



        public string Titel
        {
            get { return cbxTitel.Text; }
            set { cbxTitel.Text = value; }
        }

        public string Campany
        {
            get { return tbxCompany.Text; }
            set { tbxCompany.Text = value; }
        }

        public string Firstname
        {
            get { return tbxFirstName.Text; }
            set { tbxFirstName.Text = value; }
        }

        public string Lastname
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
            filladress = 1;

            this.Titel = e.AddressData.Titel;
            this.Campany = e.AddressData.Company;
            this.Firstname = e.AddressData.Firstname;
            this.Lastname = e.AddressData.Lastname;
            this.Email = e.AddressData.Email;
        }


        private bool GetClientData(out AddressData addressData)
        {
            addressData = null;

            if (filladress == 1)
            {
                addressData = new AddressData(
                    Titel,
                    Campany,
                    Firstname,
                    Lastname,
                    Email
                );
                filladress = 0;
                return true;
            }

            return false;
        }



        #endregion

    }

}
