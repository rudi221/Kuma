using Kuma.Services;

namespace Kuma.Forms
{
    public partial class FrmSendData : Form
    {
        public FrmSendData(CustomerTour customerTour)
        {
            InitializeComponent();

            lblArtistName.Text = customerTour.TourData.ArtistName;
            lblArtisttour.Text = customerTour.TourData.TourName;
            lblCustomerName.Text = customerTour.Customer.Firstname + " " + customerTour.Customer.Lastname;

        }

        private void btnSendData_Click(object sender, EventArgs e)
        {







        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
