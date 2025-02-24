using Kuma.Forms;
using Kuma.Models;
using Kuma.Services;

namespace Kuma.Controls
{

    public delegate void ReceivingAddressDataEventHandler(AddressData addressData);

    public partial class UcAddressData : UserControl
    {

        #region Deklaration


        public event ReceivingAddressDataEventHandler GetAdressData;
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

        private AddressData addressData;
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


            addressData = new AddressData(
                   Titel = e.AddressData.Titel,
                     Campany = e.AddressData.Company,
                        Firstname = e.AddressData.Firstname,
                            Lastname = e.AddressData.Lastname,
                                Email = e.AddressData.Email

               );


            OnGetAdressData(addressData);



        }

        protected virtual void OnGetAdressData(AddressData addressData)
        {
            GetAdressData?.Invoke(addressData);
        }


        private bool GetClientData(out AddressData addressData)
        {
            addressData = null;

            if (filladress == 1)
            {

                filladress = 0;
                return true;
            }

            return false;
        }




        #endregion

    }

}
