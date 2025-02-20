using Kuma.Controls;
using Kuma.Models;


namespace Kuma.Forms
{
    public partial class FrmAddArtist : Form
    {
        #region Deklarationen

        private UcArtistData ucArtistData;

        #endregion

        #region Konstruktor
        public FrmAddArtist(UcArtistData ucArtistData)
        {
            InitializeComponent();

            this.ucArtistData = ucArtistData;
        }

        #endregion

        #region Event Handlers for Buttons

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            int artistID = 0;
            string artistName = tbxArtist.Text;
            string tourName = tbxTour.Text;


            TourData artist = new TourData(artistID, artistName, tourName);

            ucArtistData.InsertArtistDataFromForm(artist);


            Close();
        }




        #endregion



    }

}
