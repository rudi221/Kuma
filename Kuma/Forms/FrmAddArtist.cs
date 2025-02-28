
using Kuma.Controls;
using Kuma.Models;
using Kuma.Services;

namespace Kuma.Forms
{
    public partial class FrmAddArtist : Form
    {
        #region Deklarationen

        // Validator-Instanz zur Validierung der Benutzereingaben
        private readonly Validator _validator;

        // Benutzersteuerung für Künstlerdaten
        private readonly UcArtistData ucArtistData;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Initialisiert eine neue Instanz der FrmAddArtist-Klasse.
        /// </summary>
        /// <param name="ucArtistData">Die Benutzersteuerung für Künstlerdaten.</param>
        public FrmAddArtist(UcArtistData ucArtistData)
        {
            InitializeComponent();

            // Initialisierung der Felder
            this.ucArtistData = ucArtistData;
            _validator = new Validator(errorProvider1);
        }

        #endregion

        #region Event Handlers für Buttons

        /// <summary>
        /// Behandelt das Klick-Ereignis des Abbrechen-Buttons.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Behandelt das Klick-Ereignis des Aktualisieren-Buttons.
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Überprüft, ob das Formular gültig ist
            if (ValidateForm())
            {
                // Erstellt eine neue Instanz von TourData mit den angegebenen Künstler- und Tournamen
                TourData artist = new TourData(0, tbxArtist.Text, tbxTour.Text);

                // Fügt die Künstlerdaten in die Benutzersteuerung ein
                ucArtistData.InsertArtistDataFromForm(artist);

                // Schließt das Formular
                Close();
            }
        }

        #endregion

        #region Methoden

        /// <summary>
        /// Validiert das Formular und überprüft, ob die erforderlichen Felder ausgefüllt sind.
        /// </summary>
        /// <returns>True, wenn das Formular gültig ist, andernfalls False.</returns>
        private bool ValidateForm()
        {
            bool isValid = true;
            isValid &= _validator.ValidateTextBox(tbxArtist, "Dieses Feld darf nicht leer sein.");
            isValid &= _validator.ValidateTextBox(tbxTour, "Dieses Feld darf nicht leer sein.");

            return isValid;
        }

        #endregion
    }
}