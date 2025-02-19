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

            ArtistInfo artist = GetArtistFromForm();

            ucArtistData.InsertArtistDataFromForm(artist);

            Close();
        }


        private ArtistInfo GetArtistFromForm()
        {
            return new ArtistInfo
            {
                ArtistID = 0,
                ArtistName = tbxArtist.Text,
                TourName = tbxTour.Text,
            };
        }



        #endregion



    }

}
