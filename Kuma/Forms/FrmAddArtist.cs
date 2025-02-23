using Kuma.Controls;
using Kuma.Models;
using Kuma.Services;


namespace Kuma.Forms
{
    public partial class FrmAddArtist : Form
    {
        #region Deklarationen

        private readonly Validator _validator;
        private UcArtistData ucArtistData;

        #endregion

        #region Konstruktor
        public FrmAddArtist(UcArtistData ucArtistData)
        {
            InitializeComponent();

            this.ucArtistData = ucArtistData;
            _validator = new Validator(errorProvider1);
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


            bool isValid = true;
            isValid &= _validator.ValidateTextBox(tbxArtist, "Dieses Feld darf nicht leer sein.");
            isValid &= _validator.ValidateTextBox(tbxTour, "Dieses Feld darf nicht leer sein.");


            TourData artist = new TourData(artistID, artistName, tourName);

            ucArtistData.InsertArtistDataFromForm(artist);


            Close();
        }




        #endregion


    }

}
